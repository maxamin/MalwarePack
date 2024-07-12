namespace TelegramInjectionBot.Data;

public class ModelHasPermission
{
    public ulong PermissionId { get; set; }
    public string ModelType { get; set; }
    public ulong ModelId { get; set; }

    public virtual Permission Permission { get; set; }
}