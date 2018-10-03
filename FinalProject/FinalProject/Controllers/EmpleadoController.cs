using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services;
using Services.Interfaces;
using Models;

namespace FinalProject.Controllers
{
    [Route("Api/[controller]")]
    public class EmpleadoController : ControllerBase
    {
        private readonly ICrudService<Empleado> _empleadoServices;

        public EmpleadoController(ICrudService<Empleado> crudService)
        {
            _empleadoServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Empleado model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _empleadoServices.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _empleadoServices.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Empleado model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            _empleadoServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route ("{id}")]
        public IActionResult GetById (int id)
        {
            var result = _empleadoServices.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _empleadoServices.GetAll();
            return Ok(result);      
        }
    }
}
