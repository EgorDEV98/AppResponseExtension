using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using AppResponse.Enums;
using AppResponse.Response;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AppResponse.Middleware;

public static class ExceptionMiddlewareExtention
{
    public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder builder)
        => builder.UseMiddleware<GlobalExceptionMiddleware>();
}

public class GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (ValidationException exception)
        {
            context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
            var response = new BaseResponse()
            {
                Status = ResponseStatus.Error,
                StatusMessage = exception.Message,
            };
            var msg = $"{exception.GetType()}\n {exception.Message}\n {exception.InnerException?.Message}\n {exception.StackTrace}";
            
            logger.LogError(msg);
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
        catch (ExceptionResponse exception)
        {
            context.Response.StatusCode = (int)(exception.HttpStatusCode ?? HttpStatusCode.InternalServerError);
            
            var response = new BaseResponse()
            {
                Status = exception.Status,
                StatusMessage = exception.StatusMessage,
            };
            logger.LogError(
                "(ResponseException:Status:{Status}, StatusMessage:{StatusMessage}, Unavailables:{Unavailables}",
                response.Status, response.StatusMessage);
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
        catch (Exception exception)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            var msg = $"{exception.GetType()}\n {exception.Message}\n {exception.InnerException?.Message}\n {exception.StackTrace}";
            var response = new BaseResponse()
            {
                Status = ResponseStatus.Error,
                StatusMessage = msg
            };
            logger.LogError(msg);
            await context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}