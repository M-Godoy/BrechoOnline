using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BrechoOnline
{
    public class Usuario
    {
        private string _id;
        private string _nome_completo;
        private string _email;
        private string _senha;
        private string _contato;

        public Usuario(string nome_completo, string email, string senha, string contato)
        {
            _nome_completo = nome_completo;
            _email = email;  
            _senha = senha;
            _contato = contato;
        }
        public string NOME_COMPLETO 
        {
            set { _nome_completo = value; }
            get { return _nome_completo; }
        } 
        public string EMAIL 
        {
            set { _email = value; }
            get { return _email; }
        } 
        public string SENHA 
        {
            set { _senha = value; }
            get { return _senha; }
        } 
        public string CONTATO
        {
            set { _contato = value; }
            get { return _contato; }
        }
        public string ID
        {
            set { _id = value; }
            get { return _id; }
        }

    }
}
