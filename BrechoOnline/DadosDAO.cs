using brechoonline;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BrechoOnline.Dados;
using System.Windows.Forms;

namespace BrechoOnline
{
    internal class DadosDAO
    {
        public List<Dados.Dado> SelectEndereco()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Endereco";

            List<Dados.Dado> enderecos = new List<Dados.Dado>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Dados.Dado objeto = new Dados.Dado(
                    (int)dr["ID"],
                    (int)dr["CEP"],
                    (string)dr["PAIS"],
                    (string)dr["ESTADO"],
                    (string)dr["BAIRRO"],
                    (string)dr["CIDADE"] 
                    );

                    enderecos.Add(objeto);
                }
                dr.Close();
                return enderecos;//Retornar a lista.
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }
    }
}
