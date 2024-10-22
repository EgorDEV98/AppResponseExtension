using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class RequestUriTooLongException : ExceptionResponse
{
    public static RequestUriTooLongException Throw(string message)
        => throw new RequestUriTooLongException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.RequestUriTooLong
     };
}
