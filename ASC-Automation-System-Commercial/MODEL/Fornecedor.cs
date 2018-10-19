using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Fornecedor
    {
        private int id_fornecedor;

        private String id_endereco_fk;

        private int cnpj;

        private String razao_social;

        private String nome_fantasia;

        private int telefone;

        private int celular;

        private String email;

        private int numero_estabelecimento;

        private String pais;

        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public string Id_endereco_fk { get => id_endereco_fk; set => id_endereco_fk = value; }
        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string Razao_social { get => razao_social; set => razao_social = value; }
        public string Nome_fantasia { get => nome_fantasia; set => nome_fantasia = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Celular { get => celular; set => celular = value; }
        public string Email { get => email; set => email = value; }
        public int Numero_estabelecimento { get => numero_estabelecimento; set => numero_estabelecimento = value; }
        public string Pais { get => pais; set => pais = value; }

        public Fornecedor()
        {

        }

        public Fornecedor(string id_endereco_fk, int cnpj, string razao_social, string nome_fantasia, int telefone, int celular, string email, int numero_estabelecimento, string pais)
        {
            this.Id_endereco_fk = id_endereco_fk;
            this.Cnpj = cnpj;
            this.Razao_social = razao_social;
            this.Nome_fantasia = nome_fantasia;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Numero_estabelecimento = numero_estabelecimento;
            this.Pais = pais;
        }

        public Fornecedor(int id_fornecedor, string id_endereco_fk, int cnpj, string razao_social, string nome_fantasia, int telefone, int celular, string email, int numero_estabelecimento, string pais)
        {
            this.Id_fornecedor = id_fornecedor;
            this.Id_endereco_fk = id_endereco_fk;
            this.Cnpj = cnpj;
            this.Razao_social = razao_social;
            this.Nome_fantasia = nome_fantasia;
            this.Telefone = telefone;
            this.Celular = celular;
            this.Email = email;
            this.Numero_estabelecimento = numero_estabelecimento;
            this.Pais = pais;
        }
    }
}
