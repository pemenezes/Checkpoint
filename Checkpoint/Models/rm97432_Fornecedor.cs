using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Checkpoint.Models
{
    public class rm97432_Fornecedor
    {

        [Key]
        public int idFornecedor { get; set; }
        public string? nrCEP { get; set; }
        public string? dsEndereco { get; set; }
        public string? Estado { get; set; }
        public string? Cidade { get; set; }


    }
}
