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
    public class DepartamentosController : ControllerBase
    {
        private readonly ICrudService<Departamentos> DepartamentosServices;

        public DepartamentosController (ICrudService<Departamentos> crudService)
        {
            DepartamentosServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Departamentos model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            DepartamentosServices.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = DepartamentosServices.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Departamentos model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            DepartamentosServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = DepartamentosServices.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = DepartamentosServices.GetAll();
            return Ok(result);
        }
    }
}

    

