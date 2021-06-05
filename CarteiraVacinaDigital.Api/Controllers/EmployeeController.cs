using CarteiraVacinaDigital.Model_.Contracts;
using CarteiraVacinaDigital.Model_.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
