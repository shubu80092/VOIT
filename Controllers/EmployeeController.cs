using Employee.EmployeeData;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData _employeeData;
        public EmployeeController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }
        [HttpGet]
        //[Route("api/[controller]")]
        public JsonResult GetEmployee()
        {
            var list = _employeeData.GetEmployee.ToList();
                
            return json(new { list });
        }
    }
}
