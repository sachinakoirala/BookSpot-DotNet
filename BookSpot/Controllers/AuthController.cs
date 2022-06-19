using Microsoft.AspNetCore.Mvc;

namespace BookSpot.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult signup()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
    }
}
