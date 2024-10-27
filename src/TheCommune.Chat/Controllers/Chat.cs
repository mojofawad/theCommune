using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TheCommune.Chat.Controllers;

[ApiController]
[Route("commune/[controller]")]
public class Chat(ILogger<Chat> logger) : ControllerBase
{
    private readonly ILogger<Chat> _logger = logger;

    [HttpGet(Name = "GetChat")]
    public IEnumerable<ChatString> Get()
    {
        return new List<ChatString>
        {
            new ChatString("Hello, world!"),
            new ChatString("Welcome to The Commune!")
        };
    }
}

public class ChatString(string description)
{
    public string Description { get; set; } = description;
}