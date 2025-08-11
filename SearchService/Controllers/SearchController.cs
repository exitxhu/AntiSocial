using Microsoft.AspNetCore.Mvc;

namespace SearchService.Controllers;

[ApiController]
[Route("[controller]")]
public class SearchController : ControllerBase
{
    
    private readonly ILogger<SearchController> _logger;

    public SearchController(ILogger<SearchController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> SearchChats(object terms) => Ok();
    public async Task<IActionResult> SearchUsers(object terms) => Ok();
    public async Task<IActionResult> SearchPosts(object terms) => Ok();
    public async Task<IActionResult> SearchComments(object terms) => Ok();
}
