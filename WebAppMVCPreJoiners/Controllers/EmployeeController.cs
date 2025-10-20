using DataAccessLayer.Models;
using DataAccessLayer.Respo;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCPreJoiners.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmployees _employeesRepo;
        public EmployeeController(IEmployees employeesRepo)
        {
            _employeesRepo = employeesRepo;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Employees employees)
        {
            if (employees != null)
            {
                int result = _employeesRepo.AddEmployee(employees);
                if (result > 0)
                {
                    return View();
                }
                else
                {
                    return View();
                }
            }
            return View();
        }
    }
}
