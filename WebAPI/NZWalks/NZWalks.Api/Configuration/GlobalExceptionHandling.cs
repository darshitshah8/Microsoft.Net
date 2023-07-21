using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using System.Text.Json;
using static NZWalks.Api.Exceptions.GlobalException;
using KeyNotFoundException = NZWalks.Api.Exceptions.GlobalException.KeyNotFoundException;
using NotImplementedException = NZWalks.Api.Exceptions.GlobalException.NotImplementedException;

namespace NZWalks.Api.Configuration;

public class GlobalExceptionHandling
{ 
    private readonly RequestDelegate _next;
    public GlobalExceptionHandling(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke (HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(context, ex);
                
        }
    }
    private static Task HandleExceptionAsync(HttpContext context, Exception ex)
    {
        HttpStatusCode status;
        var stackTrace = string.Empty;
        string message = " ";

        var exceptionType = ex.GetType();

        if (exceptionType == typeof(NotFoundException)) 
        { 
            message = ex.Message;
            status = HttpStatusCode.NotFound;
            stackTrace = ex.StackTrace;
        }
        else if (exceptionType == typeof(BadRequestException))
        {
            message = ex.Message;
            status = HttpStatusCode.BadRequest;
            stackTrace = ex.StackTrace;
        }
        else if (exceptionType == typeof(KeyNotFoundException))
        {
            message = ex.Message;
            status = HttpStatusCode.NotFound;
            stackTrace = ex.StackTrace;
        }
        else if (exceptionType == typeof(NotImplementedException))
        {
            message = ex.Message;
            status = HttpStatusCode.NotImplemented;
            stackTrace = ex.StackTrace;
        }
        else
        {
            message = ex.Message;
            status = HttpStatusCode.InternalServerError;
            stackTrace = ex.StackTrace;
        }

        var exceptionResult = JsonSerializer.Serialize(new { error = message, stackTrace });
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int) status;

        return context.Response.WriteAsync(exceptionResult);

    }
}
