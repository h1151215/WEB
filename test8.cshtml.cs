using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Pages.Models;

namespace WebApplication1.Pages
{
    public class test8Model : PageModel
    {
        public sutudent Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new sutudent
            {
                Ad = "Halil Ýbrahim",
                Soyad = "Katýrcý",
                Yas = 17,
                Ortalama = 85.5
            };
        }
    }
}