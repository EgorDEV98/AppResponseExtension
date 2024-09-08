using AppResponse.Response;
namespace AppResponse.Exceptions;

public class HttpVersionNotSupportedException : ExceptionResponse
{
    public static HttpVersionNotSupportedException Throw(string message)
        => throw new HttpVersionNotSupportedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.HttpVersionNotSupported
     };
}
