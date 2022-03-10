using CarPartsShoppingList.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarPartsShoppingList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        DbSet<Engine> Engines { get; set; }
        DbSet<ShoppingList> ShoppingLists { get; set; }
        DbSet<ShoppingListItem> ShoppingListItmes { get; set; }
        DbSet<Suspension> Suspensions { get; set; }
        DbSet<Transmission> Transmissions { get; set; }
    }
}