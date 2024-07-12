namespace TelegramInjectionBot.Data;

public class User
{
    public User()
    {
        InverseCreatedUser = new HashSet<User>();
        UserBotTimestamps = new HashSet<UserBotTimestamp>();
        UserTags = new HashSet<UserTag>();
        UserTelegramAttempts = new HashSet<UserTelegramAttempt>();
        UserTelegramInjections = new HashSet<UserTelegramInjection>();
        UserTelegramMessages = new HashSet<UserTelegramMessage>();
        UserTelegramBots = new HashSet<UserTelegramBot>();
    }

    public ulong Id { get; set; }

    /// <summary>
    ///     Имя пользователя
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Закриптованный токен пользователя
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    ///     Незакриптованный токен пользователя
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    ///     Адрес электронной почты. Nullable
    /// </summary>
    public string Email { get; set; }

    /// <summary>
    ///     Приостановлен ли пользователь.
    /// </summary>
    public bool IsPaused { get; set; }

    /// <summary>
    ///     Дата истечения токена.
    /// </summary>
    public DateTime? ExpiredAt { get; set; }

    public ulong? CreatedUserId { get; set; }
    public string TelegramId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int FailedAuthAttempts { get; set; }
    public string TelegramAuthCode { get; set; }

    public virtual User CreatedUser { get; set; }
    public virtual UserTimestamp UserTimestamp { get; set; }
    public virtual ICollection<User> InverseCreatedUser { get; set; }
    public virtual ICollection<UserBotTimestamp> UserBotTimestamps { get; set; }
    public virtual ICollection<UserTag> UserTags { get; set; }
    public virtual ICollection<UserTelegramAttempt> UserTelegramAttempts { get; set; }
    public virtual ICollection<UserTelegramInjection> UserTelegramInjections { get; set; }
    public virtual ICollection<UserTelegramBot> UserTelegramBots { get; set; }
    public virtual ICollection<UserTelegramMessage> UserTelegramMessages { get; set; }
}