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
            Com.CommandText = "SELECT id_fornecedor, id_endereco_fk, razao_social, nome_fantasia, cnpj, telefone, celular, email, numero_estabelecimento, pais, logradouro, bairro, cidade, estado FROM fornecedor inner join endereco on fornecedor.id_endereco_fk = endereco.cep";

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

        //cadastrar

        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO  fornecedor (id_endereco_fk,cnpj,razao_social,nome_fantasia,telefone,celular,email,numero_estabelecimento,pais) values(?id_endereco_fk,?cnpj,?razao_social,?nome_fantasia,?telefone,?celular,?email,?numero_estabelecimento,?pais)";

            Com.Parameters.AddWithValue("?id_endereco_fk", fornecedor.Id_endereco_fk);
            Com.Parameters.AddWithValue("?cnpj", fornecedor.Cnpj);
            Com.Parameters.AddWithValue("?razao_social", fornecedor.Razao_social);
            Com.Parameters.AddWithValue("?nome_fantasia", fornecedor.Nome_fantasia);
            Com.Parameters.AddWithValue("?telefone", fornecedor.Telefone);
            Com.Parameters.AddWithValue("?celular", fornecedor.Celular);
            Com.Parameters.AddWithValue("?email", fornecedor.Email);
            Com.Parameters.AddWithValue("?numero_estabelecimento", fornecedor.Numero_estabelecimento);
            Com.Parameters.AddWithValue("?pais", fornecedor.Pais);
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

        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "UPDATE fornecedor SET id_endereco_fk='" + fornecedor.Id_endereco_fk + "'" + "," + "razao_social='" + fornecedor.Razao_social + "'" + "," + " nome_fantasia='" + fornecedor.Nome_fantasia + "'" + "," + "cnpj='" + fornecedor.Cnpj + "'" + "," + "telefone='" + fornecedor.Telefone + "'" + "," + "celular='" + fornecedor.Celular + "'" + "," + "email='" + fornecedor.Email + "'" + "," + "numero_estabelecimento='" + fornecedor.Numero_estabelecimento + "'" + "," + "pais='" + fornecedor.Pais + "'" + " WHERE " + "id_fornecedor=" + fornecedor.Id_fornecedor;
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

        public void DeletarFornecedor(Fornecedor fornecedor)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "DELETE FROM fornecedor WHERE id_fornecedor=" + fornecedor.Id_fornecedor;

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
