using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Funcionario
    {
        private int id_funcionario;
        private string id_endereco_fk;
        private int id_cargo_fk;
        private string nome;
        private string sexo;
        private string data_nascimento;
        private string estado_civil;
        private string cpf;
        private string rg;
        private string telefone;
        private string celular;
        private double salario;
        private string situacao;
        private string data_admissao;
        private string data_demissao;
        private int numero_residencia;
        private string pais;
        private string email;

        public int Id_funcionario { get => id_funcionario; set => id_funcionario = value; }
        public string Id_endereco_fk { get => id_endereco_fk; set => id_endereco_fk = value; }
        public int Id_cargo_fk { get => id_cargo_fk; set => id_cargo_fk = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Data_nascimento { get => data_nascimento; set => data_nascimento = value; }
        public string Estado_civil { get => estado_civil; set => estado_civil = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Celular { get => celular; set => celular = value; }
        public double Salario { get => salario; set => salario = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public string Data_admissao { get => data_admissao; set => data_admissao = value; }
        public string Data_demissao { get => data_demissao; set => data_demissao = value; }
        public int Numero_residencia { get => numero_residencia; set => numero_residencia = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Email { get => email; set => email = value; }

        public Funcionario()
        {

        }

        public Funcionario(string id_endereco_fk, int id_cargo_fk, string nome,
        string sexo, string data_nascimento, string estado_civil, string cpf, string rg, string telefone,
        string celular, double salario, string situacao, string data_admissao, string data_demissao,
        int numero_residencia, string pais)
        {
            this.Id_endereco_fk = id_endereco_fk;
            this.Id_cargo_fk = id_cargo_fk;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Data_nascimento = data_nascimento;
            this.Estado_civil = estado_civil;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Salario = salario;
            this.Situacao = situacao;
            this.Data_admissao = data_admissao;
            this.Data_demissao = data_demissao;
            this.Numero_residencia = numero_residencia;
            this.Pais = pais;
        }

        public Funcionario(int id_funcionario, string id_endereco_fk, int id_cargo_fk, string nome,
        string sexo, string data_nascimento, string estado_civil, string cpf, string rg, string telefone,
        string celular, double salario, string situacao, string data_admissao, string data_demissao,
        int numero_residencia, string pais)
        {
            this.Id_funcionario = id_funcionario;
            this.Id_endereco_fk = id_endereco_fk;
            this.Id_cargo_fk = id_cargo_fk;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Data_nascimento = data_nascimento;
            this.Estado_civil = estado_civil;
            this.Cpf = cpf;
            this.Rg = rg;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Salario = salario;
            this.Situacao = situacao;
            this.Data_admissao = data_admissao;
            this.Data_demissao = data_demissao;
            this.Numero_residencia = numero_residencia;
            this.Pais = pais;
        }
    }
}
