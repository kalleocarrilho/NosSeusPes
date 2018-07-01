using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoC.Model
{
    [Table("ModeloSapato")]
    class ModeloSapato
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Material { get; set; }
        public String cor { get; set; }
        public float Preco { get; set; }

        public bool Cadarco { get; set; }


    }
}
