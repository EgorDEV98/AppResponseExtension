using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class RequestEntityTooLargeException : ExceptionResponse
{
    public static RequestEntityTooLargeException Throw(string message)
        => throw new RequestEntityTooLargeException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.RequestEntityTooLarge
     };
}
