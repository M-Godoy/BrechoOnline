using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BrechoOnline
{
    internal class Dados
    {
        internal class Dado
        {
            private int _id;
            private decimal _cep;
            private string _pais;
            private string _estado;
            private string _bairro;
            private string _cidade;
            

            public Dado(decimal cep, string pais, string estado, string bairro, string cidade)
            {
                _cep = cep;
                _pais = pais;
                _estado = estado;
                _bairro = bairro;
                _cidade = cidade;
           
               
            }

            public Dado (int id, decimal cep, string pais, string estado, string bairro, string cidade)
            {
                _id = id;
                _cep = cep;
                _pais = pais;
                _estado = estado;
                _bairro = bairro;
                _cidade = cidade;

            }

            public int Id
            {
                set { _id = value; }
                get { return _id; }
            }

            public decimal Cep
            {
                set { _cep = value; }
                get { return _cep; }
            }

            public string Pais
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Campo nome está vazio");
                    _pais = value;
                }
                get { return _pais; }
            }

            public string Estado
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Campo nome está vazio");
                    _estado = value;
                }
                get { return _estado; }
            }

            public string Bairro
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Campo nome está vazio");
                    _bairro = value;
                }
                get { return _bairro; }
            }

            public string Cidade
            {
                set
                {
                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Campo nome está vazio");
                    _cidade = value;
                }
                get { return _cidade; }
            }
        }
    }
}
