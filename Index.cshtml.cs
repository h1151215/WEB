using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ödev_R6.Models; 

namespace ödev_R6.Pages
{
    public class IndexModel : PageModel
    {
        
        [BindProperty]
        public UyeKayitViewModel KayitFormu { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                
                return Page();
            }

            
            return RedirectToPage("Privacy");
        }
    }
}