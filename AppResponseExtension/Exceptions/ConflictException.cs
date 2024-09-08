using AppResponse.Response;
namespace AppResponse.Exceptions;

public class ConflictException : ExceptionResponse
{
    public static ConflictException Throw(string message)
        => throw new ConflictException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.Conflict
     };
}