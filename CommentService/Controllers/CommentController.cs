using Microsoft.AspNetCore.Mvc;

namespace CommentService.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<CommentController> _logger;

    public CommentController(ILogger<CommentController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Get(int postId) => Ok();
    public async Task<IActionResult> Post(int postId, object comment) => Ok();
    public async Task<IActionResult> Put(int commentId, object comment) => Ok();
    public async Task<IActionResult> Delete(int commentId) => Ok();
}
