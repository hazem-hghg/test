using Microsoft.AspNetCore.Mvc;
using persons.management.ApiConfigurations;

namespace persons.management.Controllers;

public class ApiController:ControllerBase
{
    public ApiController() {}
    protected new IActionResult Ok()
    {
        return base.Ok(Envelope.OK());
    }
    protected IActionResult Ok<T>(T result)
    {
        return base.Ok(Envelope.OK(result));
    }
    protected IActionResult Ok(string errorMessage)
    {
        return base.Ok(Envelope.OK(errorMessage));
    }
}