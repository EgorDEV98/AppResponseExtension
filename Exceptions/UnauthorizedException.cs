using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class UnauthorizedException : ExceptionResponse
{
    public static UnauthorizedException Throw(string message)
        => throw new UnauthorizedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.Unauthorized
     };
}
