using System.ComponentModel.DataAnnotations;

namespace HoppyWiseBlog.Models
{
    public class LoginViewModel
    {

        [Required]
        [EmailAddress]
        [Display(Name = "Eposta")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "{0} alanı en az {2} en fazla {1} karakter uzunluğunda olmalı.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string? Password { get; set; }
    }
}