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
    public class ClienteController : ControllerBase
    {
        private readonly ICrudService<Cliente> ClienteServices;

        public ClienteController(ICrudService<Cliente> crudService)
        {
            ClienteServices = crudService;
        }
        [HttpPost]
        public IActionResult Create([FromBody] Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ClienteServices.Add(model);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var result = ClienteServices.Delete(id);
            if (result) return NoContent();

            return BadRequest("no existe el empleado");
        }
        [HttpPut]
        public IActionResult Update([FromBody] Cliente model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("no se actualizo");
            }
            ClienteServices.Add(model);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var result = ClienteServices.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = ClienteServices.GetAll();
            return Ok(result);
        }
    }
}

 