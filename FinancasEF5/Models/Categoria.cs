using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasEF5.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        public ObservableCollectionListSource<Gasto> Gastos { get; } = new();
    }
}
