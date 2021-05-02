using ProjetoLogin.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLogin.Modelo
{
    public class controle
    {
        public bool tem;
        public String mensagem = ""; 
        public bool acessar(String login, String senha)
        {
            LoginDalComandos logindal = new LoginDalComandos();
            logindal.verificarLogin(login, senha);
            if (!logindal.mensagem.Equals(""))
            {
                this.mensagem = logindal.mensagem;
            }
            return tem;
        }
        public String cadastrar( String nome, String email, String senha, String cofSenha)
        {
            return mensagem;
        }
    }
}
