using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPatrimonioEmpresa.Models;
using APIPatrimonioEmpresa.Repositorio;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPatrimonioEmpresa.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class PatrimonioController : ControllerBase
    {
        private readonly PatrimonioRepositorio _patrimonioRepositorio = new PatrimonioRepositorio();
       
        // GET: api/Patrimonio
        [HttpGet]
        public ActionResult<IEnumerable<Patrimonio>> PatrimonioGet()
        {
            try
            {
                var patrimonios = _patrimonioRepositorio.ListarPatrimonios().ToList();
                return Ok(patrimonios);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // GET: api/Patrimonio/5
        [HttpGet("{id}", Name = "IdPatrimonioGet")]
        public ActionResult<IEnumerable<Patrimonio>> IdPatrimonioGet(int id)
        {
            try
            {
                var patrimonio = _patrimonioRepositorio.FiltrarPatrimonios(id).ToList();
                return Ok(patrimonio);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // POST: api/Patrimonio
        [HttpPost]
        public ActionResult Post([FromBody] Patrimonio patrimonio)
        {
            try
            {
                _patrimonioRepositorio.IncluirPatrimonio(patrimonio);
                return new CreatedAtRouteResult("IdPatrimonioGet", new { id = patrimonio.NumeroTombo }, patrimonio);
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // PUT: api/Patrimonio/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Patrimonio patrimonio)
        {
            try
            {
                _patrimonioRepositorio.AtualizarPatrimonio(id, patrimonio);
                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _patrimonioRepositorio.ExcluirPatrimonio(id);
                return Ok();
            }
            catch
            {
                return new StatusCodeResult(500);
            }
        }
    }
}
