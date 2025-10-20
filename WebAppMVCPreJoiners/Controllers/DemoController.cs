using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using WebAppMVCPreJoiners.Models;

namespace WebAppMVCPreJoiners.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult DisplayDate()
        {
            TempData["Date"] =  System.DateTime.Now.ToString("F");
            return View();  // taking me to te View
        }

        public IActionResult Add() {
            int x = 5, y = 45;
            TempData["res"] = x + y;
            return View();
        }
        public IActionResult Mul()
        {
            int x = 5, y = 45;
            TempData["res"] = x * y;
            return View();
        }
        public IActionResult Sub()
        {
            int x = 5, y = 45;
            TempData["res"] = x - y;
            return View();
        }

        [HttpGet]
        public IActionResult Div()
        {
            TempData["res"] = "No result";
            return View();
        }


        [HttpPost]
        public IActionResult Div(Values obj)
        {
            //dynamically typed variable
            TempData["res"] = obj.x / obj.y;
            return View();
        }
    }
}
