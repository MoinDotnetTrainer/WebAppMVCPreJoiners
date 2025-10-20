using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Employees
    {
        [Key]
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
