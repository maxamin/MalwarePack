namespace TelegramInjectionBot.Data;

public class UserTag
{
    public ulong Id { get; set; }
    public ulong UserId { get; set; }
    public string Tag { get; set; }

    public virtual User User { get; set; }
}