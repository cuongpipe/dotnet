using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace pageModel.Pages;

public class IndexModel : PageModel //PageModel là một lớp cơ sở cho các trang Razor Pages trong ASP.NET Core. 
// Nó cung cấp các phương thức và thuộc tính để xử lý các yêu cầu HTTP và tương tác với dữ liệu. Khi bạn tạo một trang Razor Page, 
// bạn thường kế thừa từ PageModel để có thể sử dụng các tính năng của nó.
{
    public string Messager { get; set; }
    public void OnGet()
    {
        Messager = "Welcome to razor page !";
    }
}
