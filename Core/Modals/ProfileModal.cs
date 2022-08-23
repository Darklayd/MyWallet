using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Modals
{
    public class ProfileModal
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth Day")]
        public DateTime BirthDay { get; set; }
        public bool EmailConfirmed { get; set; }
        public string AvatarImage { get; set; }
    }
}
