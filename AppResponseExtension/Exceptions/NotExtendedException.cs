using AppResponse.Response;
namespace AppResponse.Exceptions;

public class NotExtendedException : ExceptionResponse
{
    public static NotExtendedException Throw(string message)
        => throw new NotExtendedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.NotExtended
     };
}