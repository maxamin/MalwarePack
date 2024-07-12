namespace TelegramInjectionBot.Data;

public class UserTelegramMessage
{
    public ulong Id { get; set; }
    public ulong UserId { get; set; }
    public string Message { get; set; }
    public bool IsSend { get; set; }

    public virtual User User { get; set; }
}