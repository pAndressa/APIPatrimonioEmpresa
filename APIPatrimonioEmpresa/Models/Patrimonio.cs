using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Models
{
    public class Patrimonio
    {
        private int _NumeroTombo;
        private string _Nome;
        private string _Descricao;
        private int _marcaId;

        public int NumeroTombo
        {
            get { return _NumeroTombo; }
            set { _NumeroTombo = value; }
        }

        [Required(ErrorMessage = "É obrigatório o preenchimento do nome")]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }        

        public string Descricao
        {
            get { return _Descricao; }
            set { _Descricao = value; }
        }        

        [Required(ErrorMessage = "É obrigatório o preenchimento da Marca")]
        //public ICollection<Marca> Marcas { get; set; }
        public int marcaId
        {
            get { return _marcaId; }
            set { _marcaId = value; }
        }

        public Patrimonio()
        {
           
        } 
       
    }
}
