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
                var pacients = _pacientRepository.GetAll();
                var vaccines = _vaccineRepository.GetAll();
                var data = new { pacientVaccines, pacients, vaccines };

                return Json(data);
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
                _pacientVaccineRepository.Insert(pacientVaccine);
                return Ok();
            }
            catch (Exception ex)
                {
                return BadRequest(ex.ToString());
            }
        }
    }
}
