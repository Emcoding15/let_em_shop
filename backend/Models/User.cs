using Microsoft.AspNetCore.Identity;

namespace backend.Models
{
    public class User : IdentityUser
    {
        // Add custom properties here
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        // Refresh token properties
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }

        // Navigation property
        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Navigation property
        public Cart Cart { get; set; } = null!;

        // Navigation property
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
