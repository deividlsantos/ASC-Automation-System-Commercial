using ASC_Automation_System_Commercial.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.DAO
{
    class EnderecoDAO
    {
        String Con;
        //ProcurarEndereco end = new ProcurarEndereco();
        Endereco endereco = new Endereco();

        public EnderecoDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public DataTable getEndereco(string pesquisa, string cep)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            //cmd.CommandText = "SELECT id, nome, endereco, idade FROM Alunos WHERE " + filtro + " LIKE '%" + nome + "%' order by nome"
            cmd.CommandText = "select cep, logradouro, bairro, cidade, estado from endereco where " + pesquisa + " like '%" + cep + "%'";
            


            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);

                DataTable dtVistar = new DataTable();
                da.Fill(dtVistar);
                return dtVistar;
                //CN.Open();
                //cmd = new MySqlCommand(cmd.CommandText, CN);
                //da = new MySqlDataAdapter(cmd);

                //DataTable dtAlunos = new DataTable();
                //da.Fill(dtAlunos);
                //return dtAlunos;
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}
