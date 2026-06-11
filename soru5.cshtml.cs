using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_sýnav.Pages
{
    public class Soru5Model : PageModel
    {
        [BindProperty]
        public int s1 { get; set; }

        [BindProperty]
        public int s2 { get; set; }

        [BindProperty]
        public int s3 { get; set; }

        public int büyük { get; set; }
        public bool b { get; set; } = false;

        public void OnPost()
        {
            b = true;
            if (s1 > s2 && s1 > s3)
            {
                büyük = s1;
            }
            else if (s2 > s1 && s2 > s3)
            {
                büyük = s2;
            }
            else
            {
                büyük = s3;
            }
        }
    }
}