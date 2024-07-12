namespace TelegramInjectionBot.Data;

public class BotVnc
{
    public ulong Id { get; set; }
    public string BotId { get; set; }
    public string Tree { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public byte[] ImageBlob { get; set; }

    public virtual Bot Bot { get; set; }
}