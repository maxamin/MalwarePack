using Microsoft.EntityFrameworkCore;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TelegramInjectionBot.Data;
using TelegramInjectionBot.Services;
using UserModel = TelegramInjectionBot.Data.User;

namespace TelegramInjectionBot.Workers;

public class HandleTelegramMessagesWorker : BackgroundService
{
    private readonly ILogger<InjectionToTelegramWorker> logger;
    private readonly TelegramBotCustomClient telegramClient;

    private readonly EFContext context;
    private readonly Dictionary<long, string> UsersState = new();

    public HandleTelegramMessagesWorker(ILogger<InjectionToTelegramWorker> logger, IServiceProvider provider,
        TelegramBotCustomClient botClient)
    {
        this.logger = logger;
        context = provider.CreateScope().ServiceProvider.GetRequiredService<EFContext>();
        telegramClient = botClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("TelegramBotWorker executed");

        using CancellationTokenSource cts = new();

        telegramClient.GetClient().StartReceiving(
            HandleUpdateAsync,
            pollingErrorHandler: HandlePollingErrorAsync,
            receiverOptions: new ReceiverOptions
            {
                AllowedUpdates = Array.Empty<UpdateType>()
            },
            cancellationToken: cts.Token
        );

        var me = await telegramClient.GetClient().GetMeAsync();

        Console.ReadLine();

        cts.Cancel();
    }

    private async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update,
        CancellationToken cancellationToken)
    {
        if (update.Message is not { } message)
            return;

        var messageText = message.Text;

        var chatId = message.Chat.Id;

        var users = context.Users
            .Where(user => user.TelegramId != null)
            .ToList();

        foreach (var telegramUser in users) UsersState[Convert.ToInt64(telegramUser.TelegramId)] = "signup";

        if (!UsersState.ContainsKey(chatId)) UsersState[chatId] = "/start";

        var user = context.Users
            .Where(user => user.TelegramId == chatId.ToString())
            .FirstOrDefault();

        if (user == null && messageText != "/start")
        {
            if (UsersState[chatId] == "signup")
            {
                var userWithCode = context.UserTelegramAttempts
                    .Include(t => t.User)
                    .Where(attempt => attempt.SecretWord == messageText)
                    .FirstOrDefault();

                if (userWithCode == null)
                {
                    await botClient.SendTextMessageAsync(
                        chatId,
                        "Token not found. Contact the administrator",
                        cancellationToken: cancellationToken
                    );
                }
                else
                {
                    context.UserTelegramAttempts.Remove(userWithCode);
                    userWithCode.User.TelegramId = chatId.ToString();
                    context.SaveChanges();

                    await botClient.SendTextMessageAsync(
                        chatId,
                        $"Hi {userWithCode.User.Name}! Telegram account successfully linked.",
                        cancellationToken: cancellationToken
                    );
                }

                return;
            }

            await botClient.SendTextMessageAsync(
                chatId,
                "Hello noname. Enter /start to start use bot.",
                cancellationToken: cancellationToken
            );
            return;
        }

        if (user == null && messageText == "/start")
        {
            await botClient.SendTextMessageAsync(
                chatId,
                "Enter your authorization code here",
                cancellationToken: cancellationToken
            );
            UsersState[chatId] = "signup";
            return;
        }


        Console.WriteLine($"Received a '{messageText}' message in chat {chatId}.");

        if (message.Sticker != null)
        {
            Console.WriteLine($"{message.Sticker.FileId}");

            Console.WriteLine(message.Sticker.FileId);

            await botClient.SendStickerAsync(
                chatId,
                message.Sticker.FileId,
                cancellationToken: cancellationToken
            );
            return;
        }

        await botClient.SendTextMessageAsync(
            chatId,
            "You said:\n" + messageText,
            cancellationToken: cancellationToken
        );
    }

    private Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception,
        CancellationToken cancellationToken)
    {
        var ErrorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(ErrorMessage);
        return Task.CompletedTask;
    }
}