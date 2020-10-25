using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Users
{
    public class RegisterModel
    {
        [Required]
        public string LoginName { get; set; }

        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Password { get; set; }
        public bool IsActive {get; set;}
        public string Country {get; set;}
        public int Salary {get; set;}
        public string DateOfBirth {get; set;}
        public string File {get; set;}
    }
}