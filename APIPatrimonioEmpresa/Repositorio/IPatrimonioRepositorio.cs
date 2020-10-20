using APIPatrimonioEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Repositorio
{
    public interface IPatrimonioRepositorio
    {
        List<Patrimonio> ListarPatrimonios();
        List<Patrimonio> FiltrarPatrimonios(int id);
        void IncluirPatrimonio(Patrimonio patrimonio);
        void AtualizarPatrimonio(int id, Patrimonio patrimonio);
        void ExcluirPatrimonio(int id);
    }
}
