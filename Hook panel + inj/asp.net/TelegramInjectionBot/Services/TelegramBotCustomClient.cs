using Telegram.Bot;

namespace TelegramInjectionBot.Services;

public class TelegramBotCustomClient
{
    private readonly ITelegramBotClient client;

    public TelegramBotCustomClient(IConfiguration configuration)
    {
        var token = Environment.GetEnvironmentVariable("TELEGRAM_TOKEN") ?? configuration["TelegramBot:Token"];
        client = new TelegramBotClient(token);
    }

    public ITelegramBotClient GetClient()
    {
        return client;
    }

    public void SendMessage(string chatId, string message)
    {
        using CancellationTokenSource cts = new();

        client.SendTextMessageAsync(
            chatId,
            message,
            cancellationToken: cts.Token
        );
    }

    public void SendSticker(string chatId, string sticker)
    {
        using CancellationTokenSource cts = new();

        client.SendStickerAsync(
            chatId,
            sticker,
            cancellationToken: cts.Token
        );
    }
}