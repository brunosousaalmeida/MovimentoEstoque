using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentoEstoque.BLL
{
    public class Usuarios
    {
        public string NomeUsuario;
        public string Login;
        public string Senha;

        public Usuarios(string nomeUsuario, string login, string senha)
        {
            nomeUsuario = NomeUsuario;
            login = Login;
            senha = Senha;
        }
    }
}
