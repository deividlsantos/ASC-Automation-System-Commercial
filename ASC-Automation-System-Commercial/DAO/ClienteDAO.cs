﻿using ASC_Automation_System_Commercial.MODEL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.DAO
{
    class ClienteDAO
    {
        String Con;
        Cliente cli = new Cliente();


        public ClienteDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public void CadastrarCliente(Cliente cliente)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO cliente(id_endereco_fk,nome,rg,data_nascimento,cpf,email,telefone,celular,sexo,foto,numero_casa,pais) VALUES(?id_endereco_fk,?nome,?rg,?data_nascimento,?cpf,?email,?telefone,?celular,?sexo,?foto,?numero_casa,?pais)";
            
            Com.Parameters.AddWithValue("?id_endereco_fk", cliente.Id_endereco_fk);
            Com.Parameters.AddWithValue("?nome", cliente.Nome);
            Com.Parameters.AddWithValue("?rg", cliente.Rg);
            Com.Parameters.AddWithValue("?data_nascimento", cliente.Data_nascimento);
            Com.Parameters.AddWithValue("?cpf", cliente.Cpf);
            Com.Parameters.AddWithValue("?email", cliente.Email);
            Com.Parameters.AddWithValue("?telefone", cliente.Telefone);
            Com.Parameters.AddWithValue("?celular", cliente.Celular);
            Com.Parameters.AddWithValue("?sexo", cliente.Sexo);
            Com.Parameters.AddWithValue("?foto", cliente.Foto);
            Com.Parameters.AddWithValue("?numero_casa", cliente.Numero_casa);
            Com.Parameters.AddWithValue("?pais", cliente.Pais);

            try
            {
                CN.Open();
                int registroAfetados = Com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Clone();
            }
        }

        public DataTable getCliente(string pesquisa, string cpf)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "SELECT id_cliente, nome, rg, cpf, data_nascimento, email, telefone, celular, sexo, foto" 
                + ", logradouro, numero_casa, bairro, cidade, estado, pais FROM cliente inner join " 
                + "endereco on cliente.id_endereco_fk = endereco.id_endereco where " + pesquisa + " like '%" + cpf + "%'";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);

                DataTable dtLista = new DataTable();
                da.Fill(dtLista);
                return dtLista;
            }
            catch(MySqlException ex)
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
