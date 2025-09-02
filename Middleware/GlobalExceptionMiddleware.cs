using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json;
using WebApplicationETS.Model.otherModel;

namespace WebApplicationETS.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;
        private readonly IHostEnvironment _env;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger, IHostEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (DbUpdateException dbEx) // EF save failures
            {
                _logger.LogError(dbEx, "DbUpdateException");

                var (status, message) = MapDbUpdateException(dbEx);

                context.Response.StatusCode = (int)status;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(
                    new ApiResponse<string>(false, null,
                        _env.IsDevelopment() ? message : "A database error occurred.")
                );
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(
                    new ApiResponse<string>(false, null,
                        _env.IsDevelopment() ? $"Something went wrong. Details: {ex.Message}" : "Something went wrong! Please try again later.")
                );
            }
        }

        private static (HttpStatusCode, string) MapDbUpdateException(DbUpdateException ex)
        {
            if (ex.InnerException is SqlException sqlEx)
            {
                if (sqlEx.Number == 2601 || sqlEx.Number == 2627)
                {
                    // Extract which column caused the error
                    var message = sqlEx.Message;

                    string fieldName = "Unknown field";

                    // Example: looks for 'IX_Vehicles_VehicleRegistrationNo'
                    var match = System.Text.RegularExpressions.Regex.Match(message, @"IX_\w+_(\w+)");
                    if (match.Success)
                    {
                        fieldName = match.Groups[1].Value;
                    }

                    return (HttpStatusCode.Conflict, $"Duplicate value in field '{fieldName}'.");
                }
            }

            // Fallback
            return (HttpStatusCode.BadRequest, ex.InnerException?.Message ?? ex.Message);
        }

    }
}




