namespace TelegramInjectionBot.Data;

public class UserTimestamp
{
    public ulong UserId { get; set; }
    public DateTime? Bots { get; set; }
    public DateTime? Banks { get; set; }
    public DateTime? Stealers { get; set; }
    public DateTime? Crypt { get; set; }
    public DateTime? Shops { get; set; }
    public DateTime? Emails { get; set; }
    public DateTime? Wallets { get; set; }
    public DateTime? CreditCards { get; set; }
    public DateTime? PermissionlessBots { get; set; }
    public DateTime? Events { get; set; }
    public DateTime? SmartInjections { get; set; }

    public virtual User User { get; set; }
}