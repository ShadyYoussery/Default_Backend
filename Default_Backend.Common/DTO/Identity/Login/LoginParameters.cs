using System.ComponentModel.DataAnnotations;

namespace Default_Backend.Common.DTO.Identity.Login
{
    public class LoginParameters
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}