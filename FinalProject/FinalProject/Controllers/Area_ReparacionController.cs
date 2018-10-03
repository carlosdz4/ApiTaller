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
    public class Area_ReparacionController : ControllerBase
    {
        private readonly ICrudService<Area_Reparacion> _Area_ReparacionServices;

        public Area_ReparacionController(ICrudService<Area_Reparacion> crudService)
        {
            _Area_ReparacionServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Area_Reparacion model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _Area_ReparacionServices.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _Area_ReparacionServices.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Area_Reparacion model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            _Area_ReparacionServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _Area_ReparacionServices.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _Area_ReparacionServices.GetAll();
            return Ok(result);
        }
    }

}

