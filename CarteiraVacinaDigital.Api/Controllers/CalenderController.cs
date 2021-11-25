using CarteiraVacinaDigital.Model.Contracts;
using CarteiraVacinaDigital.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarteiraVacinaDigital.Api.Controllers
{
    [Route("api/[controller]")]
    public class CalenderController : Controller
    {
        private readonly ICalenderRepository _calenderRepository;

        public CalenderController(ICalenderRepository calenderRepository)
        {
            _calenderRepository = calenderRepository;
        }

        [HttpGet]
        public ActionResult Calender()
        {
            try
            {
                var calendarios = _calenderRepository.GetAll();
                return Json(calendarios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("RegisterCalender")]
        public ActionResult RegisterCalender([FromBody] Calender calender)
        {
            try
            {
                _calenderRepository.Insert(calender);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
