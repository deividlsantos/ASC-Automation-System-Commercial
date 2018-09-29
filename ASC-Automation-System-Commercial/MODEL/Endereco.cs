using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Endereco
    {
        private int id_endereco;
        private string cep;
        private string logradouro;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;
        private string pais;

        public int Id_endereco { get => id_endereco; set => id_endereco = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Pais { get => pais; set => pais = value; }

        public Endereco(int id_endereco)
        {
            this.Id_endereco = id_endereco;
        }

        public Endereco(string cep, string logradouro, int numero, string bairro, string cidade, string estado, string pais)
        {
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
        }

        public Endereco(int id_endereco, string cep, string logradouro, int numero, string bairro, string cidade, string estado, string pais)
        {
            this.Id_endereco = id_endereco;
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
        }

        public Endereco()
        {
        }
    }
}
