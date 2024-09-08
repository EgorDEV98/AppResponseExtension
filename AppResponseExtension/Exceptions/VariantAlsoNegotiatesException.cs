using AppResponse.Response;
namespace AppResponse.Exceptions;

public class VariantAlsoNegotiatesException : ExceptionResponse
{
    public static VariantAlsoNegotiatesException Throw(string message)
        => throw new VariantAlsoNegotiatesException()
     {
            StatusMessage = message,
            HttpStatusCode = System.Net.HttpStatusCode.VariantAlsoNegotiates
     };
}
