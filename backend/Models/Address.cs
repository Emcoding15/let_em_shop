using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }






            [Required]
            public string? Street { get; set; }

            [Required]
            public string? City { get; set; }

            [Required]
            public string? State { get; set; }

            [Required]
            public string? PostalCode { get; set; }

            [Required]
            public string? Country { get; set; }

            // Foreign key to User
            [Required]
            public string? UserId { get; set; }
            [ForeignKey("UserId")]
            public User? User { get; set; }
    }
}
