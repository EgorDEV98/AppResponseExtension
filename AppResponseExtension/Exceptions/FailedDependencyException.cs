using AppResponse.Response;
namespace AppResponse.Exceptions;

public class FailedDependencyException : ExceptionResponse
{
    public static FailedDependencyException Throw(string message)
        => throw new FailedDependencyException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.FailedDependency
     };
}