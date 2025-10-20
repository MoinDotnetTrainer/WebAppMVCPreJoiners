using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCPreJoiners.Controllers
{

    // Back ENd Logic
    public class BooksController : Controller
    {
        public IActionResult AddBooks()
        {
            return View();
        }
        public IActionResult DisplayBooks()
        {
            return View();
        }
        public IActionResult EditBooks()
        {
            return View();
        }
        public IActionResult DeleteBooks()
        {
            return View();
        }
    }
}
