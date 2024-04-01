using Microsoft.AspNetCore.Mvc;
namespace WebP1.Controllers
{
    public class MovieController:Controller
    {
        public void GetMovie(int id)
        {

        }
        public IActionResult Get()
        {
            return Content("Hello in Get Action");
        }

        public IActionResult Redirect() {
            return RedirectToAction(nameof(Get));
        }
    }
}
