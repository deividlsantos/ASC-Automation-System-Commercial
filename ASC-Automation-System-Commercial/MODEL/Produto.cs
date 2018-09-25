using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Produto
    {

        private int codigo_barra;

        private String tipo;

        private int id_fornecedor_fk;

        private String fabricante;

        private String modelo;

        private String cor;

        private double preco;

        private int quantidade;


        public int Codigo_barra { get => codigo_barra; set => codigo_barra = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_fornecedor_fk { get => Id_fornecedor_fk; set => Id_fornecedor_fk = value; }
        public string Fabricante { get => fabricante; set => fabricante = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public double Preco { get => preco; set => preco = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        public Produto()
        {

        }


        public Produto(int codigo_barra, string tipo, int id_fornecedor_fk, string fabricante, string modelo, string cor, double preco, int quantidade)
        {
            this.Codigo_barra = codigo_barra;
            this.Tipo = tipo;
            this.id_fornecedor_fk = id_fornecedor_fk;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public Produto(string tipo, int id_fornecedor_fk,  string fabricante, string modelo, string cor, double preco, int quantidade)
        {
           
            this.Tipo = tipo;
            this.id_fornecedor_fk = id_fornecedor_fk;
            this.Fabricante = fabricante;
            this.Modelo = modelo;
            this.Cor = cor;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
    }
}
