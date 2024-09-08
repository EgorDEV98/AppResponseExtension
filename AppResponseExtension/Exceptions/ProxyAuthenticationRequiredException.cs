using AppResponse.Response;
namespace AppResponse.Exceptions;

public class ProxyAuthenticationRequiredException : ExceptionResponse
{
    public static ProxyAuthenticationRequiredException Throw(string message)
        => throw new ProxyAuthenticationRequiredException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.ProxyAuthenticationRequired
     };
}
