using APIPatrimonioEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Repositorio
{
    public class PatrimonioRepositorio : IPatrimonioRepositorio
    {
        public List<Patrimonio> ListarPatrimonios()
        {
            var patrimonios = new Conexao().Consulta("SELECT * FROM Patrimonio");

            List<Patrimonio> listPatrimonio = new List<Patrimonio>();
            for (int i = 0; i < patrimonios.Rows.Count; i++)
            {
                Patrimonio patrimonio = new Patrimonio
                {
                    NumeroTombo = Convert.ToInt32(patrimonios.Rows[i]["numero_tombo"]),
                    Nome = patrimonios.Rows[i]["nome"].ToString(),
                    Descricao = patrimonios.Rows[i]["descricao"].ToString(),
                    marcaId = Convert.ToInt32(patrimonios.Rows[i]["marcaID"])
                };                
                listPatrimonio.Add(patrimonio);
            }
            return listPatrimonio;
        }

        public List<Patrimonio> FiltrarPatrimonios(int id)
        {
            var patrimonios = new Conexao().Consulta("SELECT * FROM Patrimonio where numero_tombo ="+id);

            List<Patrimonio> listPatrimonio = new List<Patrimonio>();
            for (int i = 0; i < patrimonios.Rows.Count; i++)
            {
                Patrimonio patrimonio = new Patrimonio
                {
                    NumeroTombo = Convert.ToInt32(patrimonios.Rows[i]["numero_tombo"]),
                    Nome = patrimonios.Rows[i]["nome"].ToString(),
                    Descricao = patrimonios.Rows[i]["descricao"].ToString(),
                    marcaId = Convert.ToInt32(patrimonios.Rows[i]["marcaID"])
                };                
                listPatrimonio.Add(patrimonio);
            }
            return listPatrimonio;
        }

        public void IncluirPatrimonio(Patrimonio patrimonio)
        {
            var marcasID = new Conexao().Consulta("SELECT marcaID FROM Marca where marcaID ="+patrimonio.marcaId);
            if(!marcasID.Equals(patrimonio.marcaId))
            {
                new Conexao().Executar("INSERT INTO Patrimonio(nome,descricao,marcaID) values('" + patrimonio.Nome + "','" + patrimonio.Descricao + "'," + patrimonio.marcaId + ")");
            }
            
        }

        public void AtualizarPatrimonio(int id, Patrimonio patrimonio)
        {
            new Conexao().Executar("UPDATE Patrimonio SET nome = '"+ patrimonio.Nome +"', descricao = '"+ patrimonio.Descricao + "',marcaID = " + patrimonio.marcaId + " WHERE numero_tombo = " + id);
        }

        public void ExcluirPatrimonio(int id)
        {
            new Conexao().Executar("DELETE FROM Patrimonio WHERE numero_tombo = "+ id);
        }
        
    }
}
