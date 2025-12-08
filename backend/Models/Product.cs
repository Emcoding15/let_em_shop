namespace backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }

        public string ImageUrl { get; set; } = string.Empty;

        public int Stock { get; set; }

        // Navigation property
        public Category Category { get; set; } = null!;

        // Navigation property
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        // Navigation property
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

        // Navigation property
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
