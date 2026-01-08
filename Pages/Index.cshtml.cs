using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication_L1.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public string CurrentTime { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            CurrentTime = DateTime.Now.ToShortDateString();
        }

        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToString("F");
        }
    }
}
