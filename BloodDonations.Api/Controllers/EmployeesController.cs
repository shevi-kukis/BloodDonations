using blood_donations.Entities;
using blood_donations.Servies;
using blood_donations.Subjects;
using BloodDanations.Core.IcoinService;
using BloodDanations.Core.InterfaceRepository;
using BloodDanations.Service.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace blood_donations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        readonly IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService Service)
        {
            _employeeService = Service;
        }
        // GET: api/<EmployeesController>
        [HttpGet]

        public ActionResult<List<Employee>> Get()
        {
            return Ok(_employeeService.GetServies());
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public ActionResult< Employee> Get(int id)
        {
            Employee result = _employeeService.GetByIdService(id);
            if (result == null)
            { return NotFound(); }
            return Ok(result);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Employee value)
        {
            return _employeeService.PostServies(value);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] Employee value)
        {
            return _employeeService.PutServies(id,value);
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _employeeService.DeleteServies(id);
        }
    }
}
