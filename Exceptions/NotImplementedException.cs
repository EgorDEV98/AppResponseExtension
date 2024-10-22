using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class NotImplementedException : ExceptionResponse
{
    public static NotImplementedException Throw(string message)
        => throw new NotImplementedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.NotImplemented
     };
}
