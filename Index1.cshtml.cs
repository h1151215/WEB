using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_sınav.Pages
{
    public class Index1Model : PageModel
    {
        [BindProperty]
        public double Sayi1 { get; set; }

        [BindProperty]
        public double Sayi2 { get; set; }

        public double? Toplam { get; set; }
        public double? Carpim { get; set; }

        public void OnPost()
        {
            Toplam = Sayi1 + Sayi2;
            Carpim = Sayi1 * Sayi2;
        }
    }
}