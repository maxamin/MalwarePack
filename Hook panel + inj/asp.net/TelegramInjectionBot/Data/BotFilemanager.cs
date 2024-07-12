namespace TelegramInjectionBot.Data;

public class BotFilemanager
{
    public ulong Id { get; set; }
    public string BotId { get; set; }
    public string Info { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual Bot Bot { get; set; }
}