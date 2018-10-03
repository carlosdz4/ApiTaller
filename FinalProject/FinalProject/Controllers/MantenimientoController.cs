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
    public class MantenimientoController : ControllerBase
    {
        private readonly ICrudService<Mantenimiento> MantenimientoService;

        public MantenimientoController (ICrudService<Mantenimiento> crudService)
        {
            MantenimientoService = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Mantenimiento model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            MantenimientoService.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = MantenimientoService.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Mantenimiento model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            MantenimientoService.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = MantenimientoService.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = MantenimientoService.GetAll();
            return Ok(result);
        }
    }
}


