using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class ServiceUnavailableException : ExceptionResponse
{
    public static ServiceUnavailableException Throw(string message)
        => throw new ServiceUnavailableException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.ServiceUnavailable
     };
}
