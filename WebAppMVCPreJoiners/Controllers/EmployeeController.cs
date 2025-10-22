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
                    return RedirectToAction("List");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(_employeesRepo.List());
        }


        [HttpGet]
        public IActionResult Details(int Eid)
        {
            return View(_employeesRepo.Details(Eid));
        }


        [HttpGet]
        public IActionResult Edit(int Eid)  
        {
            return View(_employeesRepo.Details(Eid)); // getting data on load
        }

        // Data is binding from Database to Model to View 


        [HttpPost]
        public IActionResult Edit(Employees emp)
        {
            if (emp != null)
            {
                _employeesRepo.UpdateEmployees(emp); // updating data on post
                return RedirectToAction("List");
            }
            return View();
        }

    }
}
