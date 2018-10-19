using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Endereco
    {
        private string cep;
        private string logradouro;
        private string bairro;
        private string cidade;
        private string estado;

        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }

        public Endereco()
        {

        }

        public Endereco(string cep)
        {
            this.Cep = cep;
        }

        public Endereco(string cep, string logradouro, string bairro, string cidade, string estado)
        {
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }
    }
}
