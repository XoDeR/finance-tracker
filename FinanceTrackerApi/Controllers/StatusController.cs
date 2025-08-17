using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public IActionResult Get() => Ok(new { status = "Finance Tracker API is running" });
}