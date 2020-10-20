using APIPatrimonioEmpresa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioRepositorio()
        {

        }
        public void IncluirUsuario(Usuario usuario)
        {
            var user = new Conexao().Consulta("SELECT email FROM usuario where email ='" + usuario.Email + "'");
            if (user == null )
            {
                new Conexao().Executar("INSERT INTO usuario(nome,email,senha) values('" + usuario.Nome + "','" + usuario.Email + "','" + usuario.Senha + "')");
            }          
        }

        public List<Usuario> LoginUsuario(Usuario usuario)
        {
            var user = new Conexao().Consulta("SELECT email,senha FROM usuario where email ='" + usuario.Email + "' and senha = '" + usuario.Senha +"'");

            List<Usuario> listUsuario = new List<Usuario>();
            for (int i = 0; i < user.Rows.Count; i++)
            {
                Usuario usuarios = new Usuario
                {
                    Email = user.Rows[i]["email"].ToString(),
                    Senha = user.Rows[i]["senha"].ToString(),
                };
                listUsuario.Add(usuarios);
            }
            return listUsuario;
        }
    }
}
