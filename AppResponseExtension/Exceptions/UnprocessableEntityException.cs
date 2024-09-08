using AppResponse.Response;
namespace AppResponse.Exceptions;

public class UnprocessableEntityException : ExceptionResponse
{
    public static UnprocessableEntityException Throw(string message)
        => throw new UnprocessableEntityException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.UnprocessableEntity
     };
}