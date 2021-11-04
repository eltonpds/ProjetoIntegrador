using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Security;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class PacientController : Controller
    {
        private readonly IPacientRepository _pacientRepository;

        public PacientController(IPacientRepository pacientRepository)
        {
            _pacientRepository = pacientRepository;
        }

        [HttpGet]
        public ActionResult Pacient()
        {
            try
            {
                var pacients = _pacientRepository.GetAll();

                Security.Encrypter.DecryptManyEmployees(pacients);
                Business.Normalize.NormalizeManyCpfPacient(pacients);

                return Json(pacients);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("RegisterPacient")]
        public ActionResult RegisterPacient([FromBody] Pacient pacient)
        {
            try
            {
                pacient.Password = Encrypter.EncryptString(pacient.Password);
                pacient.Cpf = Encrypter.EncryptString(pacient.Cpf);

                _pacientRepository.Insert(pacient);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
