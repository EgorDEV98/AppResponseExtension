using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class GatewayTimeoutException : ExceptionResponse
{
    public static GatewayTimeoutException Throw(string message)
        => throw new GatewayTimeoutException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.GatewayTimeout
     };
}
