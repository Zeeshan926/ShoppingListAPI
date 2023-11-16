using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ShoppingList1.Models
{
    public class ShoppingListContext : DbContext
    {
        public  ShoppingListContext(
            DbContextOptions<ShoppingListContext> options) :base(options)
            {
              }
        public DbSet<Grocery> Grocery { get; set; }
    }
}
