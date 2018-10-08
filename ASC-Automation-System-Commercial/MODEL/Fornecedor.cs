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

        private int id_endereco_fk;

        private int cnpj;

        private String razao_social;

        private String nome_fantasia;

        private int telefone;

        private int celular;

        public int Id_fornecedor { get => id_fornecedor; set => id_fornecedor = value; }
        public int Id_endereco_fk { get => id_endereco_fk; set => id_endereco_fk = value; }
        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string Razao_social { get => razao_social; set => razao_social = value; }
        public string Nome_fantasia { get => nome_fantasia; set => nome_fantasia = value; }
        public int Telefone { get => telefone; set => telefone = value; }
        public int Celular { get => celular; set => celular = value; }
    }
}
