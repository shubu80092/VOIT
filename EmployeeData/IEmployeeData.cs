using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.EmployeeData
{
    public interface IEmployeeData
    {
        IEnumerable<EmployeeModel> GetEmployee();

        EmployeeModel GetEmployee(Guid EmpID);

        EmployeeModel AddEmployee(EmployeeModel employee);

        void DeleteEmployee(EmployeeModel employee);

        EmployeeModel EditEmployee(EmployeeModel employee);
    }
}
