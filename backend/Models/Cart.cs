namespace backend.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // Navigation property
        public User User { get; set; } = null!;

        // Navigation property
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
