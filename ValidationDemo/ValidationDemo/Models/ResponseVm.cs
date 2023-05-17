namespace ValidationDemo.Models
{
    public class ResponseVm
    {
        public ResponseVm(string message, int statusCode = 200, bool isSuccess = true)
        {
            IsSuccess = isSuccess;
            Message = message;
            StatusCode = statusCode;
        }

        public bool IsSuccess { get; set; }

        public int StatusCode { get; set; } = 200;

        public string Message { get; set; } = string.Empty;

    }
}
