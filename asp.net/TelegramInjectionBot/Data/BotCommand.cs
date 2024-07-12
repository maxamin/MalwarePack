namespace TelegramInjectionBot.Data;

public class BotCommand
{
    public ulong Id { get; set; }
    public string BotId { get; set; }

    /// <summary>
    ///     json массив настроек: {command:&quot;sendSMS&quot;,payload:{phone:&quot;123456&quot;,text:&quot;52314234&quot;}}
    /// </summary>
    public string Command { get; set; }

    /// <summary>
    ///     Флаг, по которому можно понять - обработана ли команда, или нет
    /// </summary>
    public bool IsProcessed { get; set; }

    /// <summary>
    ///     Запуск комманды в указанное время, формат Y-m-d H:i:s. Если указано NULL - запускать сразу
    /// </summary>
    public DateTime? RunAt { get; set; }

    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual Bot Bot { get; set; }
}