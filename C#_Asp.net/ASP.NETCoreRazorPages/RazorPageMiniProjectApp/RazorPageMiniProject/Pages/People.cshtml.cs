using DemoLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageMiniProject.Pages
{
    public class PeopleModel : PageModel
    {
        public PersonModel Person { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost() 
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("./Index");
        }
    }
}
