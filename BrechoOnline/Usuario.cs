
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
        private int _id;
        private string _nome_completo;
        private string _email;
        private string _senha;
        private string _contato;

        public Usuario(int id, string nome_completo, string email, string senha, string contato)
        {
            _id = id;
            _nome_completo = nome_completo;
            _email = email;
            _senha = senha;
            _contato = contato;
        }

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        
        }
        public string NOME_COMPLETO
        {
            set
            {
                if
            (string.IsNullOrEmpty(value))
                    throw new Exception("Campo nome está vazio");
                _nome_completo = value;
            }
            get { return _nome_completo; }
        }
        public string EMAIL
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo email está vazio");
                _email = value;
            }
            get { return _email; }
        }
        public string SENHA
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo senha está vazio");
                _senha = value;
            }
            get { return _senha; }
        }
        public string CONTATO
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Campo contato está vazio");
                _contato = value;
            }
            get { return _contato; }
        }


    }
}