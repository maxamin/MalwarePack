namespace TelegramInjectionBot.Data;

public class ModelHasRole
{
    public ulong RoleId { get; set; }
    public string ModelType { get; set; }
    public ulong ModelId { get; set; }

    public virtual Role Role { get; set; }
}