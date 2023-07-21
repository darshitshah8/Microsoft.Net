using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace HomeworkRazorPage.Pages
{
    public class GreetingsModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; } = "";
        [BindProperty]
        public string LastName { get; set; } = "";
  
       
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {            
            return Page();
        }

    }
}
