using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.DAO
{
    class FornecedorDAO
    {
        String Con;

        public FornecedorDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        //Selecionar fonecerdor

        public DataTable getFornecedor()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT cnpj, razao_social, nome_fantasia FROM fornecedor";

            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);

                DataTable dtFornecedor = new DataTable();
                da.Fill(dtFornecedor);
                return dtFornecedor;
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
