using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class MovieController(HttpClient client) : Controller
    {
        // /Movie/Index
        public IActionResult Index([FromQuery]int page = 1)
        {

            MovieResult? model = client
                .GetFromJsonAsync<MovieResult>("https://api.themoviedb.org/3/discover/movie?page=" + page).Result;

            return View(model);
        }

        // /Movie/Details/42
        public IActionResult Details([FromRoute]int id)
        {

            MovieDetailsResult? model = client.GetFromJsonAsync<MovieDetailsResult>($"https://api.themoviedb.org/3/movie/{id}").Result;

            if(model == null)
            {
                return NotFound();
            }

            return View(model);
        }
    }
}
