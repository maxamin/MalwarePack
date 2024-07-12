using Microsoft.EntityFrameworkCore;
using TelegramInjectionBot.Data;
using TelegramInjectionBot.Services;

namespace TelegramInjectionBot.Workers;

public class SendUserAuthorizarionCodesToTelegramWorker : BackgroundService
{
    private static readonly Random random = new();
    private readonly EFContext context;
    private readonly ILogger<InjectionToTelegramWorker> logger;
    private readonly TelegramBotCustomClient telegramClient;

    public SendUserAuthorizarionCodesToTelegramWorker(ILogger<InjectionToTelegramWorker> logger,
        IServiceProvider provider, TelegramBotCustomClient telegramClient)
    {
        this.logger = logger;
        context = provider.CreateScope().ServiceProvider.GetRequiredService<EFContext>();
        this.telegramClient = telegramClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("UserAuthorizationCodesWorker executed");

        while (!stoppingToken.IsCancellationRequested)
        {
            await Iteration();

            await Task.Delay(5000, stoppingToken);
        }
    }

    protected async Task Iteration()
    {
        var Users = await context.Users
            .Where(user => user.FailedAuthAttempts >= 3 && user.TelegramAuthCode == null)
            .ToListAsync();

        foreach (var user in Users)
        {
            var randomString = RandomString(255);
            var message = "Your authorization code:\n" + randomString;

            telegramClient.SendMessage(user.TelegramId, message);

            user.TelegramAuthCode = BCrypt.Net.BCrypt.HashPassword(randomString);
            await context.SaveChangesAsync();
            context.Entry(user).State = EntityState.Detached;
        }
    }

    public static string RandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*(){}?><;[]";
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
}