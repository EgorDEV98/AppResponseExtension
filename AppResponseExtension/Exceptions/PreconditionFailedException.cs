using AppResponse.Response;
namespace AppResponse.Exceptions;

public class PreconditionFailedException : ExceptionResponse
{
    public static PreconditionFailedException Throw(string message)
        => throw new PreconditionFailedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.PreconditionFailed
     };
}
