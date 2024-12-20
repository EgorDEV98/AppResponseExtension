using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class BadRequestException : ExceptionResponse
{
    public static BadRequestException Throw(string message)
        => throw new BadRequestException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.BadRequest
     };
}
