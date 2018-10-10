using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Cliente
    {
        private int id_cliente;
        private string id_endereco_fk;
        private string nome;
        private string rg;
        private string data_nascimento;
        private string cpf;
        private string email;
        private string telefone;
        private string celular;
        private string sexo;
        private int numero_casa;
        private string pais;

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Id_endereco_fk { get => id_endereco_fk; set => id_endereco_fk = value; }
        public int Numero_casa { get => numero_casa; set => numero_casa = value; }
        public string Pais { get => pais; set => pais = value; }

        public Cliente()
        {

        }

        public Cliente(string id_endereco_fk, string nome, string rg, string data_nascimento, string cpf, string email, string telofone, string celular, string sexo)
        {
            this.Id_endereco_fk = id_endereco_fk;
            this.Nome = nome;
            this.Rg = rg;
            this.Data_nascimento = data_nascimento;
            this.Cpf = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Sexo = sexo;
        }

        public Cliente(int id_cliente, string nome, string rg, string cpf, string email, string telofone, string celular, string sexo)
        {
            this.Id_cliente = id_cliente;
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Email = email;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Sexo = sexo;
        }
    }
}
