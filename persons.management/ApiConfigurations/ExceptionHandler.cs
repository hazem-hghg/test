using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace persons.management.ApiConfigurations;

[ExcludeFromCodeCoverage]
public class ExceptionHandler
{
 
    private readonly RequestDelegate _next;

    public ExceptionHandler( RequestDelegate next)
    {
  
        _next = next;
    }

    public async Task Invoke(HttpContext context)
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

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        Envelope result = Envelope.Error(exception.Message);
        context.Response.ContentType = "application/json";
        return context.Response.WriteAsync(JsonConvert.SerializeObject(result));
    }
}