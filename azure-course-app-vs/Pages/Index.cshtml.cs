using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_course_app_vs.Pages
{
    public class IndexModel(IConfiguration configuration) : PageModel
    {
        public void OnGet()
        {
            ViewData["Greeting"] = configuration["Greeting"];
        }
    }
}
