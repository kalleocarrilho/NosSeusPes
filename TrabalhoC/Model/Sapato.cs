using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoC.Model
{
    [Table("Sapato")]
    class Sapato
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public ModeloSapato Modelo { get; set; }
        public int Tamanho { get; set; }
        public int Estoque { get; set; }
    }
}
