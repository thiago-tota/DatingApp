using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegister
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 15 characters")]
        public string Password { get; set; }
    }
}