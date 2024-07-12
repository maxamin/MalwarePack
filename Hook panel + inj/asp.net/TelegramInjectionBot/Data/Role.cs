namespace TelegramInjectionBot.Data;

public class Role
{
    public Role()
    {
        ModelHasRoles = new HashSet<ModelHasRole>();
        Permissions = new HashSet<Permission>();
    }

    public ulong Id { get; set; }
    public string Name { get; set; }
    public string GuardName { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<ModelHasRole> ModelHasRoles { get; set; }

    public virtual ICollection<Permission> Permissions { get; set; }
}