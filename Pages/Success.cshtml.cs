using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Valentines.Pages
{
    public class SuccessModel : PageModel
    {
        private readonly ILogger<SuccessModel> _logger;

        public SuccessModel(ILogger<SuccessModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
