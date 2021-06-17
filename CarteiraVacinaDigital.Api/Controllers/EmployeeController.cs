using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet("GetAllEmployee")]
        public ActionResult GetAllEmployee()
        {
            try
            {
                return Json(_employeeRepository.GetAll());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("RegisterEmployee")]
        public ActionResult RegisterEmployee([FromBody] Employee employee)
        {
            try
            {
                var employeeResult = _employeeRepository.GetByCpf(employee.Cpf);
                if (employeeResult.Cpf == employee.Cpf)
                    return BadRequest("CPF já cadastrado");

                _employeeRepository.Insert(employee);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
