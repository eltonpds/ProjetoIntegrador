using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Security;
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
                var employees = _employeeRepository.GetAll();

                //Security.Encrypter.DecryptManyEmployees(employees);

                return Json(employees);
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
                //var employeeResult = _employeeRepository.GetByCpf(employee.Cpf);

                //if (employeeResult != null)
                //{
                //    if (employeeResult.Cpf == employee.Cpf) 
                //        return BadRequest("CPF já cadastrado");
                //}

                employee.Password = Encrypter.EncryptString(employee.Password);
                employee.Cpf = Encrypter.EncryptString(employee.Cpf);

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
