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

        public ProdutoDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public void CadastrarProduto(Produto produto)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO  produto (id_fornecedor_fk,fabricante,tipo,modelo,cor,preco,quantidade) values(?id_fornecedor_fk,?fabricante,?tipo,?modelo,?cor,?preco,?quantidade)";
            
            Com.Parameters.AddWithValue("?id_fornecedor_fk", produto.Id_fornecedor_fk);
            Com.Parameters.AddWithValue("?fabricante", produto.Fabricante);
            Com.Parameters.AddWithValue("?tipo", produto.Tipo);
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

        public void AlterarProduto(Produto produto)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "UPDATE produto SET id_fornecedor_fk='" + produto.Id_fornecedor_fk + "'" + "," + "fabricante='" + produto.Fabricante + "'" + "," + "tipo='" + produto.Tipo + "'" + "," + " modelo='" + produto.Modelo + "'" + "," + "cor='" + produto.Cor + "'" + "," + "preco='" + produto.Preco + "'" + "," + "quantidade='" + produto.Quantidade + "'" + " WHERE " + "codigo_produto=" + produto.Codigo_produto;
            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable sCodigo(int codigo_produto)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT * FROM produto WHERE codigo_produto = " + codigo_produto;
            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);
                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);
                return dtProduto;
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

        public DataTable sFabricante(String pesquisa, string fabricante)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT * FROM produto WHERE " + pesquisa + " LIKE '%" + fabricante + "%'";
            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);
                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);
                return dtProduto;
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

        public DataTable sTipo(string tipo)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT * FROM produto WHERE tipo = '" + tipo + "'";
            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);

                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);
                return dtProduto;
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

        public DataTable sModelo(String pesquisa, string modelo)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT * FROM produto WHERE " + pesquisa + " LIKE '%" + modelo + "%'";
            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);
                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);
                return dtProduto;
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

        public DataTable getProduto()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT * FROM produto";
            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);

                DataTable dtProduto = new DataTable();
                da.Fill(dtProduto);
                return dtProduto;
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

        //public DataTable getVProduto(int codigo)
        //{
        //    MySqlConnection CN = new MySqlConnection(Con);
        //    MySqlCommand Com = CN.CreateCommand();
        //    MySqlDataAdapter da;
        //    Com.CommandText = "SELECT * FROM produto WHERE codigo_produto = " + codigo;
        //    try
        //    {
        //        CN.Open();
        //        Com = new MySqlCommand(Com.CommandText, CN);
        //        da = new MySqlDataAdapter(Com);
        //        DataTable dtProduto = new DataTable();
        //        da.Fill(dtProduto);
        //        return dtProduto;
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw new ApplicationException(ex.ToString());
        //    }
        //    finally
        //    {
        //        CN.Close();
        //    }
        //}

        public void DeletarProduto(Produto produto)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "DELETE FROM produto WHERE codigo_produto=" + produto.Codigo_produto;
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
