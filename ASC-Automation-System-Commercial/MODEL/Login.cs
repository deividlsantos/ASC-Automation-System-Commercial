using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Automation_System_Commercial.MODEL
{
    class Login
    {
        private String login;
        private String senha;

        public string Login1 { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }

        public Login()
        {

        }

        public Login(String login, String senha)
        {
            this.login = login;
            this.senha = senha;
        }


    }
}
