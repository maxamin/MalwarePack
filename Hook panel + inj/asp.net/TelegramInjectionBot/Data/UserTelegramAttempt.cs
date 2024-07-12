namespace TelegramInjectionBot.Data;

public class UserTelegramAttempt
{
    public ulong Id { get; set; }
    public ulong UserId { get; set; }
    public string SecretWord { get; set; }
    public sbyte Attempts { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual User User { get; set; }
}