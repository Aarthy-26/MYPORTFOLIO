using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyPortfolio.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public ContactInfo ContactInfo { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                // Handle form submission, e.g., send email
                return RedirectToPage("ThankYou");
            }
            return Page();
        }
    }

    public class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
