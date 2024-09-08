using AppResponse.Response;
namespace AppResponse.Exceptions;

public class LoopDetectedException : ExceptionResponse
{
    public static LoopDetectedException Throw(string message)
        => throw new LoopDetectedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.LoopDetected
     };
}
