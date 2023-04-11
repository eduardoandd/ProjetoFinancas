using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasEF5.Models
{
    public class Gasto
    {
        [Key]
        public int IdGasto { get; set; }

        [Required, MaxLength(150)]
        public string Nome { get; set; }

        public DateTime DataCompra { get; set; }
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public bool TemFrete { get; set; }
        public double ValorFrete { get; set; }
        public double ValorFinal { get; set; }

        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
    }
}
