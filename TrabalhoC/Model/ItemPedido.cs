using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoC.Model
{
    [Table("ItemPedido")]
    class ItemPedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Sapato Sapato { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

    }
}
