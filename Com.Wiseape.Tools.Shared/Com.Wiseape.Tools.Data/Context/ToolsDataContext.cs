namespace Com.Wiseape.Tools.Data.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Com.Wiseape.Tools.Data.Model;

    public partial class ToolsDataContext : DbContext
    {
        public ToolsDataContext()
            : base("name=ToolsDataContext")
        {
        }

        public virtual DbSet<AccessToken> AccessTokens { get; set; }
        public virtual DbSet<AuthenticationCode> AuthenticationCodes { get; set; }
        public virtual DbSet<AuthenticationSession> AuthenticationSessions { get; set; }
        public virtual DbSet<AuthenticationSource> AuthenticationSources { get; set; }
        public virtual DbSet<OAuthAdministrator> OAuthAdministrators { get; set; }
        public virtual DbSet<OAuthSetting> OAuthSettings { get; set; }
        public virtual DbSet<OAuthUser> OAuthUsers { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<RegisteredApplication> RegisteredApplications { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessToken>()
                .Property(e => e.AccessTokenString)
                .IsUnicode(false);

            modelBuilder.Entity<AccessToken>()
                .Property(e => e.RefreshToken)
                .IsUnicode(false);

            modelBuilder.Entity<AccessToken>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessToken>()
                .Property(e => e.ClientSecret)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationCode>()
                .Property(e => e.AuthenticationCodeString)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationCode>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationCode>()
                .Property(e => e.AuthorizationSessionID)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationSession>()
                .Property(e => e.AuthenticationSessionString)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationSession>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationSource>()
                .Property(e => e.AuthenticationSourceName)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationSource>()
                .Property(e => e.AuthenticationLibrary)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationSource>()
                .Property(e => e.AuthenticationClassname)
                .IsUnicode(false);

            modelBuilder.Entity<AuthenticationSource>()
                .HasMany(e => e.RegisteredApplications)
                .WithOptional(e => e.AuthenticationSource)
                .HasForeignKey(e => e.AuthenticationSourceId);

            modelBuilder.Entity<OAuthAdministrator>()
                .Property(e => e.AdminUsername)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthAdministrator>()
                .Property(e => e.AdminPassword)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthSetting>()
                .Property(e => e.SettingKey)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthSetting>()
                .Property(e => e.SettingValue)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthUser>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthUser>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthUser>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<OAuthUser>()
                .Property(e => e.UserEmail)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.ClientSecret)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.AuthenticationCode)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.RefreshTokenString)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.ApplicationName)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.ApplicationDesc)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.ClientID)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.ClientSecret)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.AccessTokenRedirectURI)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.AuthorizationTokenRedirectURI)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.AuthenticationSourceConnectionString)
                .IsUnicode(false);

            modelBuilder.Entity<RegisteredApplication>()
                .Property(e => e.AuthenticationUrl)
                .IsUnicode(false);
        }
    }
}
