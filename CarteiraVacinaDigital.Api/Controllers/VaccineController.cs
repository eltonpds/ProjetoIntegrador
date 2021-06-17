using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class VaccineController : Controller
    {
        private readonly IVaccineRepository _vaccinerepository;

        public VaccineController(IVaccineRepository vaccinerepository)
        {
            _vaccinerepository = vaccinerepository;
        }

        [HttpGet]
        public ActionResult GetAllVaccine()
        {
            try
            {
                return Json(_vaccinerepository.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("RegisterVaccine")]
        public ActionResult RegisterVaccine([FromBody] Vaccine vaccine)
        {
            try
            {
                _vaccinerepository.Insert(vaccine);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }


}
