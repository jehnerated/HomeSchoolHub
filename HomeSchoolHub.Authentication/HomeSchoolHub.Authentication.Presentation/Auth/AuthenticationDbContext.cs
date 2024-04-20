using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HomeSchoolHub.Authentication.Presentation.Auth
{
    public class AuthenticationDbContext : IdentityDbContext<IdentityUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>()
                .ToTable("Users", "Authentication");

            builder.Entity<IdentityRole>()
                .ToTable("Roles", "Authentication");

            builder.Entity<IdentityUserRole<string>>()
                .ToTable("UserRoles", "Authentication");

            builder.Entity<IdentityUserClaim<string>>()
                .ToTable("UserClaims", "Authentication");

            builder.Entity<IdentityRoleClaim<string>>()
                .ToTable("RoleClaims", "Authentication");

            builder.Entity<IdentityUserLogin<string>>()
                .ToTable("UserLogins", "Authentication");

            builder.Entity<IdentityUserToken<string>>()
                .ToTable("UserTokens", "Authentication");
        }
    }
}