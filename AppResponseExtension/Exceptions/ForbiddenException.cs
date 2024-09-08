using AppResponse.Response;
namespace AppResponse.Exceptions;

public class ForbiddenException : ExceptionResponse
{
    public static ForbiddenException Throw(string message)
        => throw new ForbiddenException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.Forbidden
     };
}
