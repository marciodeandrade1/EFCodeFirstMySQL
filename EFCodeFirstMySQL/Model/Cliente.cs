using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstMySQL.Model
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

    }
}
