using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index([FromQuery]int page = 1)
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI1ZGQ1MDYyNjQ5YTc2MTg1YjVhY2YzMjkxMTUyN2E4OCIsIm5iZiI6MTc1NTU4OTM3Ni4yNTksInN1YiI6IjY4YTQyYjAwYjVhYjFmNzRjNjU2N2UzZCIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.pTcfUtfJkDiMmNfOu4g7LT24Sof0kyXMpGajJR6CvF4");

            MovieResult? model = client
                .GetFromJsonAsync<MovieResult>("https://api.themoviedb.org/3/discover/movie?page=" + page).Result;

            return View(model);
        }
    }
}
