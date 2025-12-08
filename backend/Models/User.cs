namespace backend.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Navigation property
        public Cart Cart { get; set; } = null!;

        // Navigation property
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
