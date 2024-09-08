using AppResponse.Response;
namespace AppResponse.Exceptions;

public class PreconditionRequiredException : ExceptionResponse
{
    public static PreconditionRequiredException Throw(string message)
        => throw new PreconditionRequiredException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.PreconditionRequired
     };
}
