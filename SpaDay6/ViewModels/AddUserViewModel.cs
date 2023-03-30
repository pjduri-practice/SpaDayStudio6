using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay6.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Please provide username.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 chars long.")]
        public string? Username { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please provide password.")]
        [StringLength(20, MinimumLength = 6)]
        [Compare("Verify", ErrorMessage = "Passwords do not match")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm password.")]
        public string? Verify { get; set; }

    }

}
