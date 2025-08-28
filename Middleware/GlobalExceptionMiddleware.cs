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
                await _next(context); // Continue request pipeline
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");

                // Map exception → status code and message
                var (statusCode, message) = ex switch
                {
                    JsonException => ((int)HttpStatusCode.BadRequest, "Invalid JSON format in request body."),
                    ArgumentException => ((int)HttpStatusCode.BadRequest, "Bad request – your input is invalid."),
                    KeyNotFoundException => ((int)HttpStatusCode.NotFound, "Resource not found."),
                    UnauthorizedAccessException => ((int)HttpStatusCode.Unauthorized, "Unauthorized – you do not have access."),
                    _ => ((int)HttpStatusCode.InternalServerError, "Something went wrong! Please try again later.")
                };

                context.Response.StatusCode = statusCode;
                context.Response.ContentType = "application/json";

                var errorResponse = new ApiResponse<object>(
                    status: statusCode == (int)HttpStatusCode.InternalServerError ? "failed" : "error",
                    result: null,
                    error: true,
                    message: _env.IsDevelopment() ? $"{message} Details: {ex.Message}" : message
                );

                var json = JsonSerializer.Serialize(errorResponse, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                });

                await context.Response.WriteAsync(json);
            }
        }
    }
}
