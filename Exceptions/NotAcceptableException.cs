using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class NotAcceptableException : ExceptionResponse
{
    public static NotAcceptableException Throw(string message)
        => throw new NotAcceptableException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.NotAcceptable
     };
}