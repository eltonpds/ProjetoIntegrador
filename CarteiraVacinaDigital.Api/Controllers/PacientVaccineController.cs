using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class PacientVaccineController : Controller
    {
        private readonly IPacientVaccineRepository _pacientVaccineRepository;
        private readonly IPacientRepository _pacientRepository;
        private readonly IVaccineRepository _vaccineRepository;

        public PacientVaccineController(IPacientVaccineRepository pacientVaccineRepository, IPacientRepository pacientRepository, IVaccineRepository vaccineRepository)
        {
            _pacientVaccineRepository = pacientVaccineRepository;
            _pacientRepository = pacientRepository;
            _vaccineRepository = vaccineRepository;
        }

        [HttpGet]
        public ActionResult PacientVaccine()
        {
            try
            {
                var pacientVaccines = _pacientVaccineRepository.GetAll();

                return Json(pacientVaccines);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("RegisterPacientVaccine")]
        public ActionResult RegisterPacientVaccine([FromBody] PacientVaccine pacientVaccine)
        {
            try
            {
                var pacientVaccines = _pacientVaccineRepository.GetByPacientAndVaccine(pacientVaccine.PacientID, pacientVaccine.VaccineID, pacientVaccine.Dose, pacientVaccine.UniqueDose);

                if (pacientVaccines != null)
                {
                    return BadRequest("Paciente já vacinado");
                }

                _pacientVaccineRepository.Insert(pacientVaccine);
                return Ok();
            }
            catch
            {
                return BadRequest("Houve um erro de conexão. Favor tente mais tarde!");
            }
        }
    }
}
