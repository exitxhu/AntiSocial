using Microsoft.AspNetCore.Mvc;

namespace ChatService.Controllers;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{

    private readonly ILogger<ChatController> _logger;

    public ChatController(ILogger<ChatController> logger)
    {
        _logger = logger;
    }
    public async Task<IActionResult> GetChat(int chatid) => Ok(new List<object>());
    public async Task<IActionResult> GetForUser(int userId) => Ok(Random.Shared.Next() % 2 == 0 ? new object() : null);
    public async Task<IActionResult> CreateChatSession(int userId) => Ok(new object());
    public async Task<IActionResult> Send(int userid, object chat) => Ok();
    public async Task<IActionResult> FlagAsSeen(int messageId) => Ok();
    public async Task<IActionResult> DeleteMessages(int[] messageIds) => Ok();
    public async Task<IActionResult> DeleteChat(int[] chatIds) => Ok();
}
