using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace formValidation.Pages
{
    public class contactModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage ="The first name is required")]
        public string FirstName { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "The last name is required")]
        public string LastName { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "The email is required")]

        public string Email { get; set; } = "";
        [BindProperty]

        public string? PhoneNumber { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "The subject is required")]
        public string Subject { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "The message is required")]
        public string Message { get; set; } = "";

        public string successMessage = "";
        public String errorMessage = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            if(!ModelState.IsValid)
            {
                errorMessage = "data validation failed";
                return;
            }

            successMessage = "Your message has been recieved correctly";
            FirstName = "";
            LastName = "";
            Email = "";
            PhoneNumber = "";
            Subject = "";
            Message = "";
            ModelState.Clear();
        }

    }
}
