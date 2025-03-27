using System.ComponentModel.DataAnnotations;

namespace AgriculturePresentation.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adını girin")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Lütfen maili girin")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi girin")]
        public string password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
        [Compare("password",ErrorMessage = "şifreler uyumlu değil, tekrar girin")]
        public string passwordConfirm { get; set; }
    }
}
