using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPatrimonioEmpresa.Models;
using APIPatrimonioEmpresa.Repositorio;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPatrimonioEmpresa.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PatrimonioController : ControllerBase
    {
        private readonly PatrimonioRepositorio _patrimonioRepositorio = new PatrimonioRepositorio();
       
       
        // GET: api/Patrimonio
        [HttpGet("patrimonios")]
        public IEnumerable<Patrimonio> Get()
        {
            var patrimonios = _patrimonioRepositorio.ListarPatrimonios().ToList();
            return patrimonios;
        }

        // GET: api/Patrimonio/5
        [HttpGet("{id}", Name = "patrimonios")]
        public IEnumerable<Patrimonio> Get(int id)
        {
            var patrimonio = _patrimonioRepositorio.FiltrarPatrimonios(id).ToList();
            return patrimonio;
        }

        // POST: api/Patrimonio
        [HttpPost]
        public void Post([FromBody] Patrimonio patrimonio)
        {
            _patrimonioRepositorio.IncluirPatrimonio(patrimonio);            
        }

        // PUT: api/Patrimonio/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patrimonio patrimonio)
        {
            _patrimonioRepositorio.AtualizarPatrimonio(id, patrimonio);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _patrimonioRepositorio.ExcluirPatrimonio(id);
        }
    }
}
