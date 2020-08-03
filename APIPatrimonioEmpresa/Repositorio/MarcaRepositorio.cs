using APIPatrimonioEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Repositorio
{
    public class MarcaRepositorio
    {
        public List<Marca> ListarTodasMarcas()
        {
            var marcas = new Conexao().Consulta("SELECT * FROM Marca");

            List<Marca> listMarcas = new List<Marca>();
            for (int i = 0; i < marcas.Rows.Count; i++)
            {
                Marca marca = new Marca
                {
                    MarcaID = Convert.ToInt32(marcas.Rows[i]["marcaID"]),
                    Nome = marcas.Rows[i]["nome"].ToString()
                };
                listMarcas.Add(marca);
            }
            return listMarcas;
        }

        public List<Marca> FiltrarMarcas(int id)
        {
            var marcas = new Conexao().Consulta("SELECT * FROM Marca where marcaID ="+ id);

            List<Marca> listMarcas = new List<Marca>();
            for (int i = 0; i < marcas.Rows.Count; i++)
            {
                Marca marca = new Marca
                {
                    MarcaID = Convert.ToInt32(marcas.Rows[i]["marcaID"]),
                    Nome = marcas.Rows[i]["nome"].ToString()
                };
                listMarcas.Add(marca);
            }
            return listMarcas;
        }

        public void IncluirMarca(Marca marca)
        {
            new Conexao().Executar("INSERT INTO Marca (nome) VALUES('"+ marca.Nome +"')");
        }

        public void AtualizarMarca(int id, Marca marca)
        {
            new Conexao().Executar("UPDATE Marca SET nome = '" + marca.Nome + "' WHERE marcaID = " + id);
        }

        public void ExcluirMarca(int id)
        {
            new Conexao().Executar("DELETE FROM Marca where marcaID = "+ id);
        }
    }
}