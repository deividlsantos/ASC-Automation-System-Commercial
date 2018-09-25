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
    class ProdutoDAO
    {

        
        String Con;
        Produto cad = new Produto();

        public ProdutoDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public void produto(Produto produto)
        {
            
            
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO  produto (tipo, id_fornecedor_fk, fabricante, modelo, cor, preco, quantidade) values(?tipo,?id_fornecedor_fk,?fabricante,?modelo,?cor,?preco,?quantidade)";

            
            Com.Parameters.AddWithValue("?tipo", produto.Tipo);
            Com.Parameters.AddWithValue("?id_fornecedor_fk", produto.Id_fornecedor_fk);
            Com.Parameters.AddWithValue("?fabricante", produto.Fabricante);
            Com.Parameters.AddWithValue("?modelo", produto.Modelo);
            Com.Parameters.AddWithValue("?cor", produto.Cor);
            Com.Parameters.AddWithValue("?preco", produto.Preco);
            Com.Parameters.AddWithValue("?quantidade", produto.Quantidade);
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
