using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCPreJoiners.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult CreateUsers()
        {
            return View();
        }


        public IActionResult DisplayUsers()
        {
            return View();
        }
    }
}
