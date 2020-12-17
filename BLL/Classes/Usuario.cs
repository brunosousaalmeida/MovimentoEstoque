using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentoEstoque.Classes
{
    //Por enquanto é possível realizar cadastro de usuários, mas o mesmo ainda não é consumido
    //Também falta a criação da tela de gerenciamento de usuários, que ficará disponível apenas para usuário administrador
    class Usuario
    {
        private string _nomeLogin;
        private string _login;
        private string _senha;

        public Usuario(string nomeLogin, string login, string senha)
        {

            nomeLogin = _nomeLogin;
            login = _login;
            senha = _senha;

        }

        public string Nome
        {
            get { return _nomeLogin; }
            set
            {
                if (value != null && value.Length >= 3 && value.Length <= 20)
                {
                    _nomeLogin = value;
                }
                
            }
        }

        public string Login
        {
            get { return _login; }
            set
            {
                if (value != null && value.Length >= 3 && value.Length <= 10)
                {
                    _login = value;
                }
            }
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (value != null && value.Length >= 8 && value.Length <= 12)
                {
                    _senha = value;
                }
            }
        }

    }

}
