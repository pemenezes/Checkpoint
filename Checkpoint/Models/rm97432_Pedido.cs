using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Checkpoint.Models
{
    public class rm97432_Pedido
    {

        [Key]
        public int idPedido { get; set; }
        public DateTime dataPedido { get; set; }
        public decimal valorTotal { get; set; }


    }
}
