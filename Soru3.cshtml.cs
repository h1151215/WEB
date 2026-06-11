using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_sýnav.Pages
{
    public class Soru3Model : PageModel
    {
        [BindProperty]
        public int Sayi { get; set; }

        public string? Sonuc { get; set; }

        public void OnPost()
        {
            // Sayýnýn 2'ye bölümünden kalan 0 ise çifttir, deðilse tektir.
            if (Sayi % 2 == 0)
            {
                Sonuc = $"Girdiðiniz {Sayi} sayýsý ÇÝFTTÝR.";
            }
            else
            {
                Sonuc = $"Girdiðiniz {Sayi} sayýsý TEKTÝR.";
            }
        }
    }
}