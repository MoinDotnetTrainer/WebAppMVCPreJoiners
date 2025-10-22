using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Respo
{
    public interface IEmployees
    {


        // absatrct methods

        int AddEmployee(Employees emp);  // without implemnattion for add employyes

        // display
        //update
        //delete

        IEnumerable<Employees> List();  // which all employees

        // Details getting employes based on ID

        Employees Details(int Eid);  // only employee details based on ID

        int UpdateEmployees(Employees Emp);
    }

}
