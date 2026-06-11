using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_sýnav.Pages
{
    public class Soru4Model : PageModel
    {
        [BindProperty]
        public int yas { get; set; }

        public string yazi { get; set; }

        public void OnPost()
        {
            if (yas < 18)
            {
                yazi = "Reþit Deðilsiniz";
            }
            else
            {
                yazi = "Reþitsiniz";
            }
        }
    }
}