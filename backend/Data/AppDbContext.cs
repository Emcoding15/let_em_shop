using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Review> Reviews { get; set; }

        // You can override OnModelCreating for further configuration if needed
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Add custom configuration here if needed
        }

        // Seed initial categories
        public static void SeedCategories(AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Name = "Electronics", Description = "Devices and gadgets" },
                    new Category { Name = "Clothing", Description = "Apparel and accessories" },
                    new Category { Name = "Home & Kitchen", Description = "Household items" },
                    new Category { Name = "Books", Description = "Books and magazines" },
                    new Category { Name = "Sports", Description = "Sporting goods" }
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
        }

        // Seed initial products
            public static void SeedProducts(AppDbContext context)
            {
                if (!context.Products.Any() && context.Categories.Any())
                {
                    var electronics = context.Categories.FirstOrDefault(c => c.Name == "Electronics");
                    var clothing = context.Categories.FirstOrDefault(c => c.Name == "Clothing");
                    var home = context.Categories.FirstOrDefault(c => c.Name == "Home & Kitchen");
                    var books = context.Categories.FirstOrDefault(c => c.Name == "Books");
                    var sports = context.Categories.FirstOrDefault(c => c.Name == "Sports");

                    var products = new List<Product>
                    {
                        new Product { Name = "Smartphone", Description = "Latest model smartphone", Price = 699.99M, CategoryId = electronics?.Id ?? 0, ImageUrl = "", Stock = 50 },
                        new Product { Name = "T-Shirt", Description = "100% cotton t-shirt", Price = 19.99M, CategoryId = clothing?.Id ?? 0, ImageUrl = "", Stock = 200 },
                        new Product { Name = "Blender", Description = "High-speed kitchen blender", Price = 89.99M, CategoryId = home?.Id ?? 0, ImageUrl = "", Stock = 30 },
                        new Product { Name = "Novel Book", Description = "Bestselling novel", Price = 14.99M, CategoryId = books?.Id ?? 0, ImageUrl = "", Stock = 100 },
                        new Product { Name = "Football", Description = "Official size football", Price = 29.99M, CategoryId = sports?.Id ?? 0, ImageUrl = "", Stock = 75 }
                    };
                    context.Products.AddRange(products);
                    context.SaveChanges();
                }
            }

            // Seed admin user
            public static void SeedAdminUser(AppDbContext context)
            {
                if (!context.Users.Any(u => u.Role == "Admin"))
                {
                    var admin = new User
                    {
                        Email = "admin@letemshop.com",
                        PasswordHash = "admin123", // Replace with a real hash in production
                        Name = "Admin User",
                        Role = "Admin"
                    };
                    context.Users.Add(admin);
                    context.SaveChanges();
                }
            }
    }
}
