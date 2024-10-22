using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class FailedDependencyException : ExceptionResponse
{
    public static FailedDependencyException Throw(string message)
        => throw new FailedDependencyException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.FailedDependency
     };
}
