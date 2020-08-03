using APIPatrimonioEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Repositorio
{
    public class PatrimonioRepositorio
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
                    Descricao = patrimonios.Rows[i]["descricao"].ToString()
                };
                patrimonio.Marcas.MarcaID = Convert.ToInt32(patrimonios.Rows[i]["marcaID"]);
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
                    Descricao = patrimonios.Rows[i]["descricao"].ToString()
                };
                patrimonio.Marcas.MarcaID = Convert.ToInt32(patrimonios.Rows[i]["marcaID"]);
                listPatrimonio.Add(patrimonio);
            }
            return listPatrimonio;
        }

        public void IncluirPatrimonio(Patrimonio patrimonio)
        {
            new Conexao().Executar("INSERT INTO Patrimonio(nome,descricao,marcaID) values('"+ patrimonio.Nome +"','"+ patrimonio.Descricao+"',"+patrimonio.Marcas.MarcaID+")");
        }

        public void AtualizarPatrimonio(int id, Patrimonio patrimonio)
        {
            new Conexao().Executar("UPDATE Patrimonio SET nome = '"+ patrimonio.Nome +"', descricao = '"+ patrimonio.Descricao + "',marcaID = " + patrimonio.MarcaId + " WHERE numero_tombo = " + id);
        }

        public void ExcluirPatrimonio(int id)
        {
            new Conexao().Executar("DELETE FROM Patrimonio WHERE numero_tombo = "+ id);
        }
    }
}
