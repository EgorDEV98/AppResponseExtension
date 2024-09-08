using AppResponse.Response;
namespace AppResponse.Exceptions;

public class UnauthorizedException : ExceptionResponse
{
    public static UnauthorizedException Throw(string message)
        => throw new UnauthorizedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.Unauthorized
     };
}
