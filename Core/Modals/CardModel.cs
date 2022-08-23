using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Modals
{
    public class CardModel
    {
        [Required]
        [StringLength(16, ErrorMessage = "The {0} must be {1} characters long.", MinimumLength = 16)]
        [RegularExpression("^([0-9]{4})([0-9]{4})?([0-9]{4})?([0-9]{4})?$", ErrorMessage = "Please enter valid Number")]
        public string Number { get; set; }
        public DateTime DateAdded { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CardTerm { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [RegularExpression("^([0-9]{3})?$", ErrorMessage = "Please enter valid Number")]
        public string CVC2 { get; set; }
        public string Logo { get; set; }
        public string UserId { get; set; }
    }
}
