using Microsoft.AspNetCore.Mvc;

namespace CommentService.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    private readonly ILogger<PostController> _logger;

    public PostController(ILogger<PostController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Get(int postId) => Ok();
    public async Task<IActionResult> Post(object post) => Ok();
    public async Task<IActionResult> Put(int postId, object post) => Ok();
    public async Task<IActionResult> Delete(int postId) => Ok();
}