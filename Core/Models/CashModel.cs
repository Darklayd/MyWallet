using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class CashModel
    {
        public int WalletId { get; set; }
        [Required]
        public int TypeMoneyId { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Accommodation invalid (Count must more 0).")]
        public double Count { get; set; }
        [Required]
        [StringLength(16, ErrorMessage = "The {0} must be {1} characters long.", MinimumLength = 16)]
        [RegularExpression("^([0-9]{4})([0-9]{4})?([0-9]{4})?([0-9]{4})?$", ErrorMessage = "Please enter valid Number")]
        public string CardNumber { get; set; }
    }
}
