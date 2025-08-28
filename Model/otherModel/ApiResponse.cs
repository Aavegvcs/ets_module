namespace WebApplicationETS.Model.otherModel
{
    public class ApiResponse<T>
    {
        public string Status { get; set; }   // "success" / "failed"
        public T Result { get; set; }        // actual data
        public bool Error { get; set; }      // true/false
        public string Message { get; set; }  // extra info (optional)

        public ApiResponse(string status, T result, bool error, string message = "")
        {
            Status = status;
            Result = result;
            Error = error;
            Message = message;
        }
    }
}
