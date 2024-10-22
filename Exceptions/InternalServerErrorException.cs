using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class InternalServerErrorException : ExceptionResponse
{
    public static InternalServerErrorException Throw(string message)
        => throw new InternalServerErrorException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.InternalServerError
     };
}
