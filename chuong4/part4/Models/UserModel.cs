using System.ComponentModel.DataAnnotations;

namespace part4.Models
{
    public class UserModel
    {
        [Required(ErrorMessage = "Username is requiredd.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email is requiredd.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is requiredd.")]
        public string Password { get; set; }

        
    }
}