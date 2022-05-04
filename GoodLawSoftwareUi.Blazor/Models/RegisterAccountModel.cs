using System.ComponentModel.DataAnnotations;

namespace GoodLawSoftwareUi.Blazor.Models
{
	public class RegisterAccountModel
	{

        [Required]
        [StringLength(8, ErrorMessage = "Name length can't be more than 8.")]
        public string Username { get; set; }   
        [Required]
        [StringLength(8, ErrorMessage = "FirstName length can't be more than 8.")]
        public string FisrtName { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "LastName length can't be more than 8.")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string Password2 { get; set; }
    }
}
