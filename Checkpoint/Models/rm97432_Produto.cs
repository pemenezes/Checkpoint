using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Checkpoint.Models
{
    public class rm97432_Produto
    {

        [Key]
        public int idProduto { get; set; }
        public string? nmProduto { get; set; }
        public decimal preco { get; set; }



    }
}
