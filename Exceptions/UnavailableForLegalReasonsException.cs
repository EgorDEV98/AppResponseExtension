using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class UnavailableForLegalReasonsException : ExceptionResponse
{
    public static UnavailableForLegalReasonsException Throw(string message)
        => throw new UnavailableForLegalReasonsException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.UnavailableForLegalReasons
     };
}
