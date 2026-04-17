using System.ComponentModel.DataAnnotations;

namespace ödev_R6.Models
{
    public class UyeKayitViewModel
    {
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        [Display(Name = "Adınız")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "E-posta adresi şart.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta formatı.")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Sifre { get; set; }
    }
}