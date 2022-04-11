using CarPartsShoppingList.Infrastructure.Data.Identity;
using CarPartsShoppingList.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarPartsShoppingList.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ShoppingList>()
                .Property(x => x.Code)
                .IsRequired(false);

            builder.Entity<ShoppingList>()
                .Property(x => x.IsChecked)
                .HasDefaultValue(true);

            builder.Entity<ShoppingListItem>()
                .Property(x => x.Code)
                .IsRequired(false);

            builder.Entity<ShoppingListItem>()
                .Property(x => x.IsChecked)
                .HasDefaultValue(true);

            builder.Entity<ShoppingListItem>()
                .Property(x => x.Name)
                .IsRequired(false);
        }

        DbSet<Engine> Engines { get; set; }
        DbSet<ShoppingList> ShoppingLists { get; set; }
        DbSet<ShoppingListItem> ShoppingListItmes { get; set; }
        DbSet<Suspension> Suspensions { get; set; }
        DbSet<Transmision> Transmissions { get; set; }
    }
}