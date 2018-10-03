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
    public class FacturaController: ControllerBase
    {
        private readonly ICrudService<Factura> FacturaService;

        public FacturaController (ICrudService<Factura> crudService)
        {
            FacturaService = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Factura model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            FacturaService.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = FacturaService.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Factura model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            FacturaService.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = FacturaService.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = FacturaService.GetAll();
            return Ok(result);
        }
    }
}
