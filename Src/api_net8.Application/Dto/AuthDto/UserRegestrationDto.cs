using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace api_net9.Application.Dto.AuthDto
{
    public class UserRegestrationDto
    {
        [Required]
        [StringLength(50)]
        [MinLength(3)]
        public string UserName { get; set; }
        [EmailAddress]
        [Required]
        public string UserEmail { get; set; }
        [DataType(dataType: DataType.Password)]
        [MinLength(8,ErrorMessage ="Password must be at least 8 characters")]
        [MaxLength(12,ErrorMessage ="Password must be maximum 12 characters")]
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Password do not match")]
        public string ConfirmPassword { get; set; }
    }
}