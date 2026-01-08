using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_L1.Pages
{
    public class Task3Model : PageModel
    {
        public string CurrentTime { get; set; }
        public Task3Model()
        {
            CurrentTime = DateTime.Now.ToShortDateString();
        }
        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString("F");
        }
    }
}
