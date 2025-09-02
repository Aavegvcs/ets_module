namespace WebApplicationETS.Model.otherModel
{
    public class ApiResponse<T>
    {
        public bool Status { get; set; }   // "success" / "failed"
        public T Result { get; set; }        // actual data
        public string Message { get; set; }  // extra info (optional)

        public ApiResponse(bool status, T result, string message = "")
        {
            Status = status;
            Result = result;
            Message = message;
        }
    }
}
