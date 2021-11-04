using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Security;
using CarteiraVacinaDigital.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using CarteiraVacinaDigital.Model.Entities.Enums;
using System.ComponentModel;

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

                Security.Encrypter.DecryptManyEmployees(employees);
                Business.Normalize.NormalizeManyCpfEmployee(employees);

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
                var employeeResult = _employeeRepository.GetByCpf(employee.Cpf);

                if (employeeResult != null)
                {
                    if (employeeResult.Cpf == employee.Cpf)
                        return BadRequest("CPF já cadastrado");
                }

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

        [HttpPost("Login")]
        public ActionResult Login([FromBody] Employee employee)
        {
            try
            {
                employee.Password = Encrypter.EncryptString(employee.Password);

                var employeeResult = _employeeRepository.Login(employee.Email, employee.Password);
                
                if (employeeResult == null)
                        return BadRequest("E-mail ou senha inválido");

                return Ok(employeeResult);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
