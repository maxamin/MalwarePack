namespace TelegramInjectionBot.Data;

public class UserTelegramInjection
{
    public ulong Id { get; set; }
    public ulong UserId { get; set; }
    public string Application { get; set; }
    public string BotId { get; set; }

    public virtual Bot Bot { get; set; }
    public virtual User User { get; set; }
}