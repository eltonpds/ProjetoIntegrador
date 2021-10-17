using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using CarteiraVacinaDigital.Model.Entities.Enums;
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
                //var pacientResult = _pacientRepository.GetByCpf(pacient.Cpf);

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
