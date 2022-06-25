using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EmployeeModel
    {
        public Guid EmpID { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }

    }
}





