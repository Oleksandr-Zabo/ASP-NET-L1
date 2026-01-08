using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_L1.Pages
{
    public class Task4Model : PageModel
    {
        public string Version { get; set; }

        private readonly IConfiguration _configuration;
        public Task4Model(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void OnGet()
        {
            Version = _configuration["ApplicationInfo:Version"];
        }
        
    }
}
