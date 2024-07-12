namespace TelegramInjectionBot.Data;

public class InjectionFile
{
    public ulong InjectionId { get; set; }
    public byte[] HtmlBlob { get; set; }
    public byte[] ImageBlob { get; set; }

    public virtual Injection Injection { get; set; }
}