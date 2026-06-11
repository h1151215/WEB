using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_sýnav.Pages
{
    public class Soru2Model : PageModel
    {
        [BindProperty]
        public double Kenar { get; set; }

        public double? Alan { get; set; }
        public double? Cevre { get; set; }

        public void OnPost()
        {
         
            Alan = Kenar * Kenar;

            
            Cevre = 4 * Kenar;
        }
    }
}