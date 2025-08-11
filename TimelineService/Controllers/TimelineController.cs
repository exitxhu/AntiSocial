using Microsoft.AspNetCore.Mvc;

namespace TimelineService.Controllers;

[ApiController]
[Route("[controller]")]
public class TimelineController : ControllerBase
{

    private readonly ILogger<TimelineController> _logger;

    public TimelineController(ILogger<TimelineController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Get() => Ok(new List<object>());
}
