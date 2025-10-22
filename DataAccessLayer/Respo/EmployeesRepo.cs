using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

        public IEnumerable<Employees> List()
        {
            return _db.Employees.ToList(); // returning all employees as a list
        }
        public Employees Details(int Eid)
        {
            Employees emp = _db.Employees.FirstOrDefault(x => x.Eid == Eid);
            if (emp != null)
            {
                return emp;
            }
            else
            {
                return new Employees();
            }
        }

        public int UpdateEmployees(Employees Emp)
        {
            _db.Employees.Update(Emp); // updating emp object in Employees table
            int res = _db.SaveChanges(); // saving changes to database
            return res;
        }
    }
}
