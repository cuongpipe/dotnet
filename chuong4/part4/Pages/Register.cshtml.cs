using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using part4.Models;

namespace part4.Pages
{

    public class RegisterModel : PageModel
    {
        [BindProperty]
        public UserModel User { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Xử lý đăng ký người dùng ở đây (ví dụ: lưu vào cơ sở dữ liệu)
            // Sau khi xử lý xong, bạn có thể chuyển hướng đến trang khác hoặc hiển thị thông báo thành công
            return RedirectToPage("Success");
        }
    }
}