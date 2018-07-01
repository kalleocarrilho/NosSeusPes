using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoC.Model
{

    [Table("Pedido")]
    class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<ItemPedido> Itens {get; set;}
        public ClienteFisico ClienteFisico { get; set; }
        public ClienteJuridico CLienteJuridico { get; set; }
    }
}
