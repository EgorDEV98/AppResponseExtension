using AppResponse.Response;
namespace AppResponse.Exceptions;

public class BadGatewayException : ExceptionResponse
{
    public static BadGatewayException Throw(string message)
        => throw new BadGatewayException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.BadGateway
     };
}
