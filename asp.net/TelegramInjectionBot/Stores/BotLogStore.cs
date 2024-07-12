using System.Collections.Concurrent;
using TelegramInjectionBot.Data;

namespace TelegramInjectionBot.Stores;

public class UserBotLog
{
    public string TelegramId { get; set; }
    public BotLog Log { get; set; }
}

public class BotLogStore
{
    public ConcurrentQueue<UserBotLog> BotLogs { get; } = new();
}