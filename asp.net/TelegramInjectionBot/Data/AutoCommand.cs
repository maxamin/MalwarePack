namespace TelegramInjectionBot.Data;

public class AutoCommand
{
    public ulong Id { get; set; }
    public string Data { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}