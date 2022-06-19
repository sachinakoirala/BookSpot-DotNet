using Microsoft.AspNetCore.Mvc;

namespace BookSpot.Controllers
{
    public class CategoryController : Controller
    {
        public ViewResult Academic()
        {
            return View();
        }

        public ViewResult No_academic()
        {
            return View();
        }
    }
}
