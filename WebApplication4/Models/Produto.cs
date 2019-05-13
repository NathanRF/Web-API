using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Produto
    {
        [Key]
        public string Nome { get; set; }

        public Decimal Preco { get; set; }
    }
}
