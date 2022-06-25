using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.EmployeeData
{
    public class MockEmployeeData : IEmployeeData
    {
        private List<EmployeeModel> employees = new List<EmployeeModel>()
        {
            new EmployeeModel()
            {
                EmpID = Guid.NewGuid(),
                EmpFname = "Shubu",
                EmpLname = "Vishu",
                Department = "IT",
                Salary = "30000"
            },
            new EmployeeModel()
            {
                EmpID = Guid.NewGuid(),
                EmpFname = "Sumit",
                EmpLname = "singh",
                Department = "IT",
                Salary = "350000"
            }
        };
        public List<EmployeeModel> GetEmployee()
        {
            return employees;
        }

        EmployeeModel IEmployeeData.AddEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        void IEmployeeData.DeleteEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        EmployeeModel IEmployeeData.EditEmployee(EmployeeModel employee)
        {
            throw new NotImplementedException();
        }

        IEnumerable<EmployeeModel> IEmployeeData.GetEmployee()
        {
            throw new NotImplementedException();
        }

        EmployeeModel IEmployeeData.GetEmployee(Guid EmpID)
        {
            throw new NotImplementedException();
        }
  
    }
}
