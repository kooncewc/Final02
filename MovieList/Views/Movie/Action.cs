using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace MovieList.Views.Movie
{
    public class ActionModel : PageModel
    {
        private readonly ILogger<ActionModel> _logger;

        public ActionModel(ILogger<ActionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
