using AppResponseExtension.Response;

namespace AppResponseExtension.Exceptions;

public class InsufficientStorageException : ExceptionResponse
{
    public static InsufficientStorageException Throw(string message)
        => throw new InsufficientStorageException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.InsufficientStorage
     };
}
