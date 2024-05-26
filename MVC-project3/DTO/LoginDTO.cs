using System.ComponentModel.DataAnnotations;

namespace MVC_project3.DTO
{
    public class LoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]

        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
