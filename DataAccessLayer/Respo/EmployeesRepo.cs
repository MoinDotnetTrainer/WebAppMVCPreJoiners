using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Respo
{

    public class EmployeesRepo : IEmployees
    {
        public readonly AppDatabase _db;
        public EmployeesRepo(AppDatabase db)
        {
            _db = db;
        }

        public int AddEmployee(Employees emp)
        {
            _db.Employees.Add(emp); // adding emp object to Employees table
            int res = _db.SaveChanges(); // saving changes to database
            return res;
        }
    }
}
