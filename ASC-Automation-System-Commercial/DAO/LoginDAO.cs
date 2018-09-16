using ASC_Automation_System_Commercial.MODEL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ASC_Automation_System_Commercial.DAO
{
    class LoginDAO
    {
        int i;
        String Con;
        Login log = new Login();

        public LoginDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=automationcommercial;uid=root;pwd=root";
        }

        public Boolean logar(String login, String senha)
        {
            i = 0;
            Boolean resp = false;
            MySqlConnection con = new MySqlConnection(Con);
            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT login,senha FROM logins WHERE login='" + login + "'" + " AND " + " senha='" + senha + "'";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = dt.Rows.Count;
                if (i == 0)
                {
                    resp = false;
                }
                else
                {
                    resp = true;
                }
            }
            catch(MySqlException ex)
            {
                resp = false;
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                con.Close();
            }

            return resp;
        }
    }
}
