namespace TelegramInjectionBot.Data;

public class Injection
{
    public ulong Id { get; set; }

    /// <summary>
    ///     Приложение
    /// </summary>
    public string Application { get; set; }

    /// <summary>
    ///     Название инжекта для панели
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Относительный путь к html
    /// </summary>
    public string Html { get; set; }

    /// <summary>
    ///     Относительный путь к иконке
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    ///     Доступные варианты: &apos;banks&apos;, &apos;crypt&apos;, &apos;wallets&apos;, &apos;shops&apos;, &apos;
    ///     credit_cards&apos;, &apos;emails&apos;
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    ///     Флаг определяющий автоинжект.
    /// </summary>
    public bool Auto { get; set; }

    public virtual InjectionFile InjectionFile { get; set; }
}