using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class UnsupportedMediaTypeException : ExceptionResponse
{
    public static UnsupportedMediaTypeException Throw(string message)
        => throw new UnsupportedMediaTypeException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.UnsupportedMediaType
     };
}
