namespace TelegramInjectionBot.Stores;

public class UserAuthorizationCodesStore
{
    public Dictionary<int, string> CodesList { get; } = new();
}