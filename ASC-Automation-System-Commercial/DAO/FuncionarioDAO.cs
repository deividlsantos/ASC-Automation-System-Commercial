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
    class FuncionarioDAO
    {
        String Con;
        Funcionario func = new Funcionario();

        public FuncionarioDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public void CadastrarFuncionarios(Funcionario funcionario)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO funcionario(id_endereco_fk,id_cargo_fk,nome,sexo," +
                "data_nascimento,estado_civil,cpf,rg,telefone,celular,email,salario,situacao,data_admissao," +
                " data_demissao,numero_residencia,pais) VALUES(?id_endereco_fk,?id_cargo_fk,?nome,?sexo," +
                "?data_nascimento,?estado_civil,?cpf,?rg,?telefone,?celular,?email,?salario,?situacao," +
                "?data_admissao,?data_demissao,?numero_residencia,?pais)";

            Com.Parameters.AddWithValue("?id_endereco_fk", funcionario.Id_endereco_fk);
            Com.Parameters.AddWithValue("?id_cargo_fk", funcionario.Id_cargo_fk);
            Com.Parameters.AddWithValue("?nome", funcionario.Nome);
            Com.Parameters.AddWithValue("?sexo", funcionario.Sexo);
            Com.Parameters.AddWithValue("?data_nascimento", funcionario.Data_nascimento);
            Com.Parameters.AddWithValue("?estado_civil", funcionario.Estado_civil);
            Com.Parameters.AddWithValue("?cpf", funcionario.Cpf);
            Com.Parameters.AddWithValue("?rg", funcionario.Rg);
            Com.Parameters.AddWithValue("?telefone", funcionario.Telefone);
            Com.Parameters.AddWithValue("?celular", funcionario.Celular);
            Com.Parameters.AddWithValue("?email", funcionario.Email);
            Com.Parameters.AddWithValue("?salario", funcionario.Salario);
            Com.Parameters.AddWithValue("?situacao", funcionario.Situacao);
            Com.Parameters.AddWithValue("?data_admissao", funcionario.Data_admissao);
            Com.Parameters.AddWithValue("?data_demissao", funcionario.Data_demissao);
            Com.Parameters.AddWithValue("?numero_residencia", funcionario.Numero_residencia);
            Com.Parameters.AddWithValue("?pais", funcionario.Pais);

            try
            {
                CN.Open();
                int registroAfetados = Com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getFunc(string pesquisa, string Cpf)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "SELECT id_Funcionario, id_endereco_fk, id_cargo_fk, nome, descricao, " +
                "salario, rg, cpf, data_nascimento,estado_civil, email,telefone, celular, sexo, situacao, " +
                "data_admissao, data_demissao, logradouro, numero_residencia, bairro, cidade, estado, " +
                "pais FROM funcionario inner join endereco on funcionario.id_endereco_fk = endereco.Cep " +
                "inner join cargo on funcionario.id_cargo_fk = cargo.id_cargo Where " + pesquisa + " like '%" + Cpf + "%'";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);

                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;
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

        public DataTable sCodigo(int id_funcionario)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();
            MySqlDataAdapter da;
            Com.CommandText = "SELECT id_funcionario, id_cargo_fk, nome, sexo FROM funcionario WHERE id_funcionario = " + id_funcionario;
            try
            {
                CN.Open();
                Com = new MySqlCommand(Com.CommandText, CN);
                da = new MySqlDataAdapter(Com);
                DataTable dtFuncionario = new DataTable();
                da.Fill(dtFuncionario);
                return dtFuncionario;
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

        public void Alterar(Funcionario funcionario)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "UPDATE funcionario SET id_funcionario=" + funcionario.Id_funcionario + ", id_endereco_fk='" + funcionario.Id_endereco_fk + "', " +
                "id_cargo_fk=" + funcionario.Id_cargo_fk + ", nome='" + funcionario.Nome + "', sexo='" + funcionario.Sexo + "', " +
                "data_nascimento='" + funcionario.Data_nascimento + "', estado_civil='" + funcionario.Estado_civil + "', cpf='" + funcionario.Cpf + "', " +
                "rg='" + funcionario.Rg + "', telefone='" + funcionario.Telefone + "', celular='" + funcionario.Celular + "'," +
                "email='" + funcionario.Email + "', salario=" + funcionario.Salario + ", situacao='" + funcionario.Situacao + "', data_admissao='" + funcionario.Data_admissao + "'" +
                ", data_demissao='" + funcionario.Data_demissao + "', numero_residencia=" + funcionario.Numero_residencia + ", pais='" + funcionario.Pais + "' where id_funcionario=" + funcionario.Id_funcionario;

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

        public void Excluir(Funcionario funcionario)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "DELETE FROM funcionario WHERE id_funcionario=" + funcionario.Id_funcionario;

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch (Exception ex)
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
