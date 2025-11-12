using Microsoft.AspNetCore.Mvc;
using Milestone1.Filters;

namespace Milestone1.Controllers
{
    public class MinesweeperController : Controller
    {
        // user must be logged in to access; will be redirected to login page otherwise
        [SessionCheckFilter]
        public IActionResult Index()
        {
            return View();
        }

        [SessionCheckFilter]
        public IActionResult StartGame()
        {
            return View("Index");
        }
    }
}
