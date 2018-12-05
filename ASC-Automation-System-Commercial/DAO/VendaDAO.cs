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
    class VendaDAO
    {
        String Con;

        public VendaDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public void itemVenda(Venda venda)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO venda (codigo_produto_fk, id_funcionario_fk, id_cliente_fk, quantidade, valor_unitario, total_produto) " + "VALUES (" + venda.Codigo_produto_fk + "," + venda.Id_funcionario_fk + "," + venda.Id_cliente_fk + "," + venda.Quantidade + "," + venda.Valor_unitario + "," + venda.Total_produto + ")";

            try
            {
                CN.Open();
                int registroAfetados = Com.ExecuteNonQuery();
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
