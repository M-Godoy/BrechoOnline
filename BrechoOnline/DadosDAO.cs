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
                    (decimal)dr["CEP"],
                    (string)dr["PAIS"],
                    (string)dr["ESTADO"],
                    (string)dr["CIDADE"],
                    (string)dr["BAIRRO"]
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
        public void InsertEndereco(Dados.Dado endereco)
        {
            //esse Connection verde água é o nome da sua classe.
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Endereco VALUES (@CEP, @PAIS, @ESTADO, @CIDADE, @BAIRRO)";

            sqlCommand.Parameters.AddWithValue("@CEP", endereco.Cep);
            sqlCommand.Parameters.AddWithValue("@PAIS", endereco.Pais);
            sqlCommand.Parameters.AddWithValue("@ESTADO", endereco.Estado);
            sqlCommand.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            sqlCommand.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);

            sqlCommand.ExecuteNonQuery();
        }
        public void UpdateEndereco(Dados.Dado endereco)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Endereco SET
            CEP = @CEP,
            PAIS = @PAIS,
            ESTADO = @ESTADO,
            CIDADE = @CIDADE,
            BAIRRO = @BAIRRO
            WHERE ID = @ID";

            //idêntico ao do botão insert
            sqlCommand.Parameters.AddWithValue("@ID", endereco.Id);
            sqlCommand.Parameters.AddWithValue("@CEP", endereco.Cep);
            sqlCommand.Parameters.AddWithValue("@PAIS", endereco.Pais);
            sqlCommand.Parameters.AddWithValue("@ESTADO", endereco.Estado);
            sqlCommand.Parameters.AddWithValue("@CIDADE", endereco.Cidade);
            sqlCommand.Parameters.AddWithValue("@BAIRRO", endereco.Bairro);


            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteEndereco(int Id)
        {
            //Código para excluir 
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Endereco WHERE ID = @ID";
            sqlCommand.Parameters.AddWithValue("@ID", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + error.Message);
            }
            finally
            {
                connection.CloseConnection();
            }


        }
    }
}
