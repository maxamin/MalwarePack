namespace TelegramInjectionBot.Data;

public class InjectionSession
{
    public ulong Id { get; set; }
    public string BotId { get; set; }
    public string Application { get; set; }
    public string Data { get; set; }
    public string SessionId { get; set; }
    public string Action { get; set; }
    public bool IsClosed { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}