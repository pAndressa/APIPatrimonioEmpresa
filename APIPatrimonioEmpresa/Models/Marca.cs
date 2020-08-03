using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Models
{
    public class Marca
    {
        public int MarcaID { get; set; }

        [Required (ErrorMessage ="O preenchimento do nome é obrigatório")]
        public string Nome { get; set; }

        public Marca()
        {

        }
    }
}
