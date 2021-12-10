
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using PrimeiraApiWorkshop.DataBase;
using PrimeiraApiWorkshop.Models;
using PrimeiraApiWorkshop.Response;
using PrimeiraApiWorkshop.Services;

namespace PrimeiraApiWorkshop.Controllers {

    [ApiController] //Declarar que nossa classe é uma controller
    [Route("api/[controller]")] //Caminho de url padrão para acessar esta controller
    [Produces("application/json")]
    public class VehicleController : ControllerBase {

        protected VehicleService _service;
        protected NpgContext _context;
        
        public VehicleController(NpgContext context) {
            this._context = context;
            this._service = new VehicleService(context);
        }

        [HttpGet] //GET -> READ -> Serve para PEGAR INFORMAÇÕES, NÃO ENVIAR
        public virtual IActionResult Get() {
            ResponseEntity<IEnumerable<Vehicle>> response;
            try {
                response = new ResponseEntity<IEnumerable<Vehicle>>(_service.Get());
            } catch (Exception ex) {
                response = new ResponseEntity<IEnumerable<Vehicle>>(new List<Vehicle>(), ex);
                return StatusCode(500, response); // 500 -> ERRO INTERNO DE SERVIDOR
            }

            return Ok(response); //ok -> RETORNA O STATUS 200
        }

        [HttpGet("{id}")]
        public virtual IActionResult GetById([FromRoute] long id) {
            ResponseEntity<Vehicle> response;
            try {
                Vehicle entity = _service.Get(id);
                response = new ResponseEntity<Vehicle>(entity);
                return Ok(response);
            } catch (Exception ex) {
                response = new ResponseEntity<Vehicle>(new Vehicle(), ex);
                return StatusCode(500, response); // 500 -> ERRO INTERNO DE SERVIDOR
            }

            
        }

        [HttpPost] //POST -> Realizar requisições que afetem o sistema. Ele serve justamente para enviar algo. "body" é este "algo".
        public virtual IActionResult Save([FromBody] Vehicle entity) {
            ResponseEntity<Vehicle> response;

            try {
                _service.Save(entity);
            } catch (Exception ex) {
                response = new ResponseEntity<Vehicle>(entity, ex);
                return StatusCode(500, response); // 500 -> ERRO INTERNO DE SERVIDOR
            }

            response = new ResponseEntity<Vehicle>(entity);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public virtual IActionResult DeleteById([FromRoute]long id) {
            ResponseEntity<Vehicle> response;

            Vehicle entity = new Vehicle();
            entity.Id = id;
            try {
                _service.Delete(id);
            } catch (Exception ex) {
                response = new ResponseEntity<Vehicle>(entity, ex); // TODO: PQ NÃO ESTÁ EXCLUINDO SÓ COM O ID?
                return StatusCode(500, response); // 500 -> ERRO INTERNO DE SERVIDOR
            }
            return this.Get();
        }

        [HttpPut]
        public virtual IActionResult Put([FromBody] Vehicle entity) {
            ResponseEntity<Vehicle> response;

            if(entity.Id.Equals(null)) {
                response = new ResponseEntity<Vehicle>(entity, "Id não pode ser nula");
                BadRequest(response);
            }

            try {
                _service.Update(entity);
            } catch (Exception ex) {
                response = new ResponseEntity<Vehicle>(entity, ex); 
                return StatusCode(500, response); // 500 -> ERRO INTERNO DE SERVIDOR
            }

            response = new ResponseEntity<Vehicle>(entity);
            return Ok(response);
        }

        

    }

}