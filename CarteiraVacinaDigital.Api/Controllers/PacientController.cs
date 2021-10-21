using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Model.Entities.Enums;
using CarteiraVacinaDigital.Security;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Cryptography;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class PacientController : Controller
    {
        private readonly IPacientRepository _pacientRepository;
        private Encrypter _encrypter = new Encrypter(SHA512.Create());

        public PacientController(IPacientRepository pacientRepository)
        {
            _pacientRepository = pacientRepository;
        }

        [HttpGet]
        public ActionResult Pacient()
        {
            try
            {
                return Json(_pacientRepository.GetAll());
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
                pacient.Password = _encrypter.EncryptString(pacient.Password);
                pacient.Cpf = _encrypter.EncryptString(pacient.Cpf);

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
