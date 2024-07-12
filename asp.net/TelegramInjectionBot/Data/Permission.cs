namespace TelegramInjectionBot.Data;

public class Permission
{
    public Permission()
    {
        ModelHasPermissions = new HashSet<ModelHasPermission>();
        Roles = new HashSet<Role>();
    }

    public ulong Id { get; set; }
    public string Name { get; set; }
    public string GuardName { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ModelHasPermission> ModelHasPermissions { get; set; }

    public virtual ICollection<Role> Roles { get; set; }
}