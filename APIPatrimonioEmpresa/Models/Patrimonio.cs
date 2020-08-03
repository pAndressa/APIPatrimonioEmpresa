using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIPatrimonioEmpresa.Models
{
    public class Patrimonio
    {
        public int NumeroTombo { get; set; }

        [Required(ErrorMessage ="É obrigatório o preenchimento do nome")]
        public string Nome { get; set; }
        
        public string Descricao { get; set; }

        [Required(ErrorMessage = "É obrigatório o preenchimento da Marca")]
        public Marca Marcas { get; set; }
        public int MarcaId { get; set; }

        public Patrimonio()
        {
            Marca marca = new Marca();
        }
    }
}
