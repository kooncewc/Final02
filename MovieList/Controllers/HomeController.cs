using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies
                .Include(m => m.Genre)
                .OrderBy(m => m.Name)
                .ToList();
            return View(movies);
        }
        public IActionResult Action()
        {

            return View("/Views/Movie/Action.cshtml");
        }
        public IActionResult Comedy()
        {

            return View("/Views/Movie/Comedy.cshtml");
        }
        public IActionResult SuperHero()
        {

            return View("/Views/Movie/Superhero.cshtml");
        }
        public IActionResult About()
        {

            return View("/Views/Movie/About.cshtml");
        }
        public IActionResult Animation()
        {

            return View("/Views/Movie/Animation.cshtml");
        }


    }
}