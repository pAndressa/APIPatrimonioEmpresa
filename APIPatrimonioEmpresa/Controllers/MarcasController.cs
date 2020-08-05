using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIPatrimonioEmpresa.Models;
using APIPatrimonioEmpresa.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIPatrimonioEmpresa.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class MarcasController : ControllerBase
    {
        private readonly MarcaRepositorio _marcaRepositorio = new MarcaRepositorio();

        [HttpGet]
        public IEnumerable<Marca> Get()
        {
            var marcas = _marcaRepositorio.ListarTodasMarcas().ToList();
            return marcas;
        }

        // GET: api/Marca/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Marca> Get(int id)
        {
             var marca = _marcaRepositorio.FiltrarMarcas(id).ToList();
            return marca;
        }

        // POST: api/Marca
        [HttpPost]
        public void Post([FromBody] Marca marca)
        {           
             _marcaRepositorio.IncluirMarca(marca);            
        }

        // PUT: api/Marca/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Marca marca)
        {
            _marcaRepositorio.AtualizarMarca(id, marca);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _marcaRepositorio.ExcluirMarca(id);
        }
    }
}
