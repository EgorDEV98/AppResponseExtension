using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class MisdirectedRequestException : ExceptionResponse
{
    public static MisdirectedRequestException Throw(string message)
        => throw new MisdirectedRequestException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.MisdirectedRequest
     };
}
