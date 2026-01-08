using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_L1.Pages
{
    public class TestModel : PageModel
    {
        public string Text  { get; set; }
        public string WelcomeText { get; set; }

        private readonly IConfiguration _configuration;
        public TestModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            Text = "HelloWorld";
            WelcomeText = _configuration["ApplicationInfo:WelcomeText"];
        }
    }
}
