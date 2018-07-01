using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoC.Model
{
    [Table("ClienteJuridico")]
    class ClienteJuridico
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Razao { get; set; }
        public String Cnpj { get; set; }
        public String Endereco { get; set; }
    }
}
