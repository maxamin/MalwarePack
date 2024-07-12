using Microsoft.EntityFrameworkCore;
using TelegramInjectionBot.Data;
using TelegramInjectionBot.Services;

namespace TelegramInjectionBot.Workers;

public class SendNewMessagesWorker : BackgroundService
{
    private readonly EFContext context;
    private readonly TelegramBotCustomClient telegramClient;

    public SendNewMessagesWorker(IServiceProvider provider, TelegramBotCustomClient telegramClient)
    {
        context = provider.CreateScope().ServiceProvider.GetRequiredService<EFContext>();
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Iteration();

            await Task.Delay(2000, stoppingToken);
        }
    }

    protected async Task Iteration()
    {
        var now = DateTime.UtcNow;

        var startDate = now.AddMinutes(-1);

        var messages = await context.UserTelegramMessages
            .Include(message => message.User)
            .Where(message => message.User.TelegramId != null)
            .Where(message => !message.IsSend)
            .ToListAsync();

        foreach (var message in messages)
        {
            telegramClient.SendMessage(message.User.TelegramId, $"{message.Message}");
            message.IsSend = true;
            await context.SaveChangesAsync();
            context.Entry(message).State = EntityState.Detached;
        }
    }
}