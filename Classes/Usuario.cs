using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentoEstoque.Classes
{
    class Usuario
    {
        public string NomeLogin;
        public string Login;
        public string Senha;

        public Usuario(string nomeLogin, string login, string senha)
        {

            nomeLogin = NomeLogin;
            login = Login;
            senha = Senha;

        }
    }

}
