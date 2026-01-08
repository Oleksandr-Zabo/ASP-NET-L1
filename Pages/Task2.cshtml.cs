using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_L1.Pages
{
    public class Task2Model : PageModel
    {
        public string HelloWorld { get; set; }
        public Task2Model()
        {
            HelloWorld = "Hello World";
        }
        public void OnGet()
        {
            
        }
    }
}
