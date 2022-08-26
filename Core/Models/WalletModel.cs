using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class WalletModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string Name { get; set; }
        public string UserId { get; set; }
    }
}
