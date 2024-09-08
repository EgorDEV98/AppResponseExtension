using AppResponse.Response;
namespace AppResponse.Exceptions;

public class RequestHeaderFieldsTooLargeException : ExceptionResponse
{
    public static RequestHeaderFieldsTooLargeException Throw(string message)
        => throw new RequestHeaderFieldsTooLargeException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge
     };
}
