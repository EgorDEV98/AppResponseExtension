using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class RequestTimeoutException : ExceptionResponse
{
    public static RequestTimeoutException Throw(string message)
        => throw new RequestTimeoutException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.RequestTimeout
     };
}
