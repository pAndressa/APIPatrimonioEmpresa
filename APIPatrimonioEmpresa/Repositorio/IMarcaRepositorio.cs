using APIPatrimonioEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Repositorio
{
    public interface IMarcaRepositorio
    {
        List<Marca> ListarTodasMarcas();
        List<Marca> FiltrarMarcas(int id);
        void IncluirMarca(Marca marca);
        void AtualizarMarca(int id, Marca marca);
        void ExcluirMarca(int id);
        string VerificarNome(string nome);
    }
}
