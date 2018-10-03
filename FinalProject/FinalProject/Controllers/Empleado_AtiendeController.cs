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
    public class Empleado_AtiendeController: ControllerBase
    {
        private readonly ICrudService<Empleado_Atiende> Empleado_AtiendeServices;

        public Empleado_AtiendeController(ICrudService<Empleado_Atiende> crudService)
        {
            Empleado_AtiendeServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Empleado_Atiende model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Empleado_AtiendeServices.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = Empleado_AtiendeServices.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Empleado_Atiende model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            Empleado_AtiendeServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = Empleado_AtiendeServices.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = Empleado_AtiendeServices.GetAll();
            return Ok(result);
        }
    }
}

