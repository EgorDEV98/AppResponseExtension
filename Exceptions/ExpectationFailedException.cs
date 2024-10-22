using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class ExpectationFailedException : ExceptionResponse
{
    public static ExpectationFailedException Throw(string message)
        => throw new ExpectationFailedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.ExpectationFailed
     };
}
