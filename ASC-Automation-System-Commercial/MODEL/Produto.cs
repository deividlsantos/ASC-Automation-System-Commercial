using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Produto
    {
        private int codigo_produto;

        private int id_fornecedor_fk;

        private String fabricante;

        private String tipo;

        private String modelo;

        private String cor;

        private double preco;

        private int quantidade;

        public int Codigo_produto { get => codigo_produto; set => codigo_produto = value; }
        public int Id_fornecedor_fk { get => id_fornecedor_fk; set => id_fornecedor_fk = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Produto()
        {

        }

        public Produto(int id_fornecedor_fk, string fabricante, string tipo, string modelo, string cor, double preco, int quantidade)
        {
            this.id_fornecedor_fk = id_fornecedor_fk;
            this.Fabricante = fabricante;
            this.Tipo = tipo;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        public Produto(int codigo_produto, int id_fornecedor_fk, string tipo, string fabricante, string modelo, string cor, double preco, int quantidade)
        {
            this.Codigo_produto = codigo_produto;
            this.id_fornecedor_fk = id_fornecedor_fk;
            this.Tipo = tipo;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
    }
}
