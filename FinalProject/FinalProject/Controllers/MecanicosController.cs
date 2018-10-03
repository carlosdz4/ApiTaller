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
    public class MecanicosController: ControllerBase
    {
        private readonly ICrudService<Mecanicos> MecanicosService;

        public MecanicosController (ICrudService<Mecanicos> crudService)
        {
            MecanicosService = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Mecanicos model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            MecanicosService.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = MecanicosService.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Mecanicos model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            MecanicosService.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = MecanicosService.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = MecanicosService.GetAll();
            return Ok(result);
        }
    }
}
