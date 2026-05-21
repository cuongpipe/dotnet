using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
namespace pageModel.Pages{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string username { get; set; }
        [BindProperty]
        public string password { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            Message = "Please enter your username and password.";
            Console.WriteLine("OnGet method called!");
        }
        public void OnPost()
        {
            Console.WriteLine("OnPost method called with username: " + username + " and password: " + password);
            if (username == "admin" && password == "1")
            {
                Console.WriteLine("Login successful!" + username + password);
                Message = "Login successful!";
            }
            else
            {
                Message = "Invalid username or password.";
            }
        }
    }



}