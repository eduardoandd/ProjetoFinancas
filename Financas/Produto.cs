﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financas
{
    public enum EnumCategoria
    {
        Eletrônico, Comida, Delivery, Marina, Suplemento
    }

    public class Produto
    {
       

        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public EnumCategoria Categoria { get; set; }
        public DateTime DataCompra { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public double Frete { get; set; }
        public double ValorTotal { get; set; }



        public Produto( string nome, 
            DateTime dataCompra, string descricao, double valor, double valorTotal)
        {
            this.ProdutoId = 0;
            this.Nome = nome;
            this.DataCompra = dataCompra;
            this.Descricao = descricao;
            this.Valor = valor;
            this.ValorTotal = valorTotal;
        }

        //public static List<Produto> ListaProdutos { get; set; }

        //static Produto()
        //{
        //    Produto.ListaProdutos = new List<Produto>();
        //    Produto.ListaProdutos.Add(new Produto("Pipoca", new DateTime(2023,03,23),"Comprei porquê tava com fome e porque também estava com a bruna", 10.00, 0));
        //    Produto.ListaProdutos.Add(new Produto("Whey Protein 2x", new DateTime(2023, 02, 23), "Whey mensal que eu compro", 140.00,0));
        //}

    }
}
