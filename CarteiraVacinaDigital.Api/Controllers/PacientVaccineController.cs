using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class PacientVaccineController : Controller
    {
        private readonly IPacientVaccineRepository _pacientVaccineRepository;

        public PacientVaccineController(IPacientVaccineRepository pacientVaccineRepository)
        {
            _pacientVaccineRepository = pacientVaccineRepository;
        }

        [HttpPost("RegisterPacientVaccine")]
        public ActionResult RegisterPacientVaccine([FromBody] PacientVaccine employee)
        {
            try
            {
                _pacientVaccineRepository.Insert(employee);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
