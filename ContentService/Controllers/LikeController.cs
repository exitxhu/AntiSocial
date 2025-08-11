using Microsoft.AspNetCore.Mvc;

namespace LikeService.Controllers;

[ApiController]
[Route("[controller]")]
public class LikeController : ControllerBase
{
    
    private readonly ILogger<LikeController> _logger;

    public LikeController(ILogger<LikeController> logger)
    {
        _logger = logger;
    }
    public async Task<IActionResult> Like(int postId) => Ok();
    public async Task<IActionResult> Unlike(int postId) => Ok();
}
