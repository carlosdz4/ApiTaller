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
    public class VehiculoController: ControllerBase
    {
        private readonly ICrudService<Vehiculo> _empleadoServices;

        public VehiculoController (ICrudService<Vehiculo> crudService)
        {
            _empleadoServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Vehiculo model)
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
        public IActionResult Update([FromBody] Vehiculo model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            _empleadoServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
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