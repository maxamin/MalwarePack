namespace TelegramInjectionBot.Data;

public class UserBotTimestamp
{
    public ulong Id { get; set; }
    public ulong UserId { get; set; }
    public string BotId { get; set; }
    public string Application { get; set; }
    public DateTime? VisitedAt { get; set; }

    public virtual Bot Bot { get; set; }
    public virtual User User { get; set; }
}