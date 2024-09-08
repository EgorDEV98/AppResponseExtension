using AppResponse.Response;
namespace AppResponse.Exceptions;

public class UpgradeRequiredException : ExceptionResponse
{
    public static UpgradeRequiredException Throw(string message)
        => throw new UpgradeRequiredException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.UpgradeRequired
     };
}
