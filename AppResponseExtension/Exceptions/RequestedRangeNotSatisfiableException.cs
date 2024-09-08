using AppResponse.Response;
namespace AppResponse.Exceptions;

public class RequestedRangeNotSatisfiableException : ExceptionResponse
{
    public static RequestedRangeNotSatisfiableException Throw(string message)
        => throw new RequestedRangeNotSatisfiableException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.RequestedRangeNotSatisfiable
     };
}
