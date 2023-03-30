using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasComSqLite
{
    internal class Gasto
    {
        public int IdGasto { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public DateTime DataCompra { get; set; }
        public string Descricao { get; set; }
        public double ValorCompra { get; set; }
        public bool TemFrete { get; set; }
        public double ValorFrete { get; set; }
        public double ValorFinal { get; set; }


    }
}
