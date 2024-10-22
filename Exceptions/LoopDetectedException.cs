using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class LoopDetectedException : ExceptionResponse
{
    public static LoopDetectedException Throw(string message)
        => throw new LoopDetectedException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.LoopDetected
     };
}
