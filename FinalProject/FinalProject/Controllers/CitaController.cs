using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services;
using Services.Interfaces;

namespace FinalProject.Controllers
{
    [Route("Api/[controller]")]
    public class CitaController: ControllerBase
    {
        private readonly ICrudService<Cita> CitaServices;

        public CitaController(ICrudService<Cita> crudService)
        {
            CitaServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Cita model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            CitaServices.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = CitaServices.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Cita model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            CitaServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = CitaServices.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = CitaServices.GetAll();
            return Ok(result);
        }
    }
}


