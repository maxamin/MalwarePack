using Microsoft.EntityFrameworkCore;
using TelegramInjectionBot.Data;
using TelegramInjectionBot.Services;

namespace TelegramInjectionBot.Workers;

public class CheckOfflineBotsWorker : BackgroundService
{
    private readonly EFContext _context;

    private readonly TelegramBotCustomClient _telegramClient;

    public CheckOfflineBotsWorker(IServiceProvider provider, TelegramBotCustomClient telegramClient)
    {
        _context = provider.CreateScope().ServiceProvider.GetRequiredService<EFContext>();
        _telegramClient = telegramClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Iteration();

            await Task.Delay(5000, stoppingToken);
        }
    }

    private async Task Iteration()
    {
        var now = DateTime.UtcNow;

        var startDate = now.AddMinutes(-1);

        var offlineBots = await _context.UserTelegramBots
            .Include(userTelegramBot => userTelegramBot.Bot)
            .Include(userTelegramBot => userTelegramBot.User)
            .Where(userTelegramBot => userTelegramBot.Bot.LastConnection >= startDate)
            .Where(userTelegramBot => userTelegramBot.User.TelegramId != null)
            .ToListAsync();

        foreach (var offlineBot in offlineBots)
        {
            _telegramClient.SendMessage(offlineBot.User.TelegramId, $"Bot {offlineBot.Bot.Id} online now!");

            _context.Remove(offlineBot);
            _context.SaveChanges();
        }
    }
}