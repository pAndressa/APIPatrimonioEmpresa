using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Models
{
    public class Marca
    {
        private int _MarcaID;
        private string _Nome;

        public int MarcaID
        {
            get { return _MarcaID; }
            set { _MarcaID = value; }
        }       

        [Required(ErrorMessage = "O preenchimento do nome é obrigatório")]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        public Marca()
        {

        }
    }
}
