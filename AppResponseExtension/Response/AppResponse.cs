using System.Net;
using AppResponse.Enums;

namespace AppResponse.Response;

public static class AppResponse
{
    /// <summary>
    /// Ответ без данных
    /// </summary>
    /// <returns></returns>
    public static BaseResponse CreateSuccess(ResponseStatus status = ResponseStatus.Success, string? statusMessage = null)
    {
        return new BaseResponse()
        {
            Status = status,
            StatusMessage = statusMessage,
        };
    }
    
    /// <summary>
    /// Ответ с данными
    /// </summary>
    /// <param name="data"></param>
    /// <param name="status"></param>
    /// <param name="message"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static BaseResponse<T> CreateSuccess<T>(T data, ResponseStatus status = ResponseStatus.Success, 
        string? message = null)
        => new()
        {
            Data = data,
            Status = status,
            StatusMessage = message
        };

    /// <summary>
    /// Прокинуть ошибку
    /// </summary>
    /// <param name="status">status</param>
    /// <param name="statusMessage">statusMessage</param>
    /// <param name="httpStatusCode">HTTP код ошибки</param>
    /// <returns></returns>
    public static ExceptionResponse CreateError(ResponseStatus status = ResponseStatus.Error,
        string? statusMessage = null, HttpStatusCode httpStatusCode = HttpStatusCode.InternalServerError)
        => new ExceptionResponse()
        {
            Status = status,
            StatusMessage = statusMessage,
            HttpStatusCode = httpStatusCode
        };
}