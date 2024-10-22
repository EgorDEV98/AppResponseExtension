﻿using AppResponseExtension.Enums;

namespace AppResponseExtension.Response;

public static class AppResponse
{
    public static BaseResponse Create() => new();

    public static BaseResponse<T> Create<T>(T data) => new BaseResponse<T>()
    {
        Data = data
    };

    public static BaseResponse Create(ExceptionResponse exceptionResponse)
        => new BaseResponse()
        {
            Status = exceptionResponse.Status,
            StatusMessage = exceptionResponse.StatusMessage,
        };

}