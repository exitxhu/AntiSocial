using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProfileService.Controllers;

[ApiController]
[Route("[controller]")]
public class ProfileController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ProfileController> _logger;

    public ProfileController(ILogger<ProfileController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Get(int userid) => Ok();
    public async Task<IActionResult> Post(object profile) => Ok();
    public async Task<IActionResult> Put(int userid, object profile) => Ok();
    public async Task<IActionResult> Delete(int userid) => Ok();
}
