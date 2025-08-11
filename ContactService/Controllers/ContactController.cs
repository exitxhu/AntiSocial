using Microsoft.AspNetCore.Mvc;

namespace ContactService.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly ILogger<ContactController> _logger;

    public ContactController(ILogger<ContactController> logger)
    {
        _logger = logger;
    }
    public async Task<IActionResult> Follow(int userid) => Ok();
    public async Task<IActionResult> Unfollow(object profile) => Ok();
    public async Task<IActionResult> Block(int userid, object profile) => Ok();
    public async Task<IActionResult> Unblock(int userid) => Ok();
}
