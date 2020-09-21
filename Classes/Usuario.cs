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
