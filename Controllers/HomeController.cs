using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Repositories.Abstract;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieService;
        public HomeController(IMovieRepository movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index(string term = "", int currentPage = 1)
        {
            var movies = _movieService.List(term, true, currentPage);
            return View(movies);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult MovieDetail(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            return View(movie);
        }


    }
}
