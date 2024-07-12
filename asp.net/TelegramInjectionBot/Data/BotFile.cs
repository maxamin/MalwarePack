namespace TelegramInjectionBot.Data;

public class BotFile
{
    public ulong Id { get; set; }
    public string BotId { get; set; }
    public string Path { get; set; }
    public string Content { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string StoredFilePath { get; set; }

    public virtual Bot Bot { get; set; }
}