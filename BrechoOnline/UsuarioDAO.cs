using brechoonline;
using BrechoOnline;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrechoOnline
{
    //DAO = Data Access Objct. 
    //Essa é a classe que vai [ligar] com o BD. 
    internal class UsuarioDAO
    {
        //(1) 
        //void é quando não tem que retornar nada. 

        //select
        public List<Usuario> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Cadastro";

            List<Usuario> users = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute. 
                while (dr.Read())
                {
                    Usuario objeto = new Usuario( 
                        (int)dr["ID"],
                        (string)dr["NOME_COMPLETO"],
                        (string)dr["EMAIL"],
                        (string)dr["SENHA"],
                        (decimal)dr["CONTATO"]
                        );

                    users.Add(objeto);
                }
                dr.Close();
               


            }
            catch (Exception error)
            {
                throw new Exception("Erro na Leitura de Dados \n" + error.Message);

            }
            finally
            {
                conn.CloseConnection();
            }
            return users;//Retornar a lista.
        }
        //insert
        public void InsertUser(Usuario user)
        {
            //esse Connection verde água é o nome da sua classe. 
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Cadastro VALUES (@nome_completo, @email, @senha, @contato)";

           
            sqlCommand.Parameters.AddWithValue("@nome_completo", user.NOME_COMPLETO);
            sqlCommand.Parameters.AddWithValue("@email", user.EMAIL);
            sqlCommand.Parameters.AddWithValue("@senha", user.SENHA); 
            sqlCommand.Parameters.AddWithValue("@contato", user.CONTATO);

            sqlCommand.ExecuteNonQuery();
        }
        //update
        public void UpdateUser(Usuario user)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Cadastro SET  
             NOME_COMPLETO      = @nome_completo,  
             EMAIL        = @email,  
             SENHA   = @senha
             CONTATO = @contato
             WHERE ID   = @id";

            //idêntico ao do botão insert 

            sqlCommand.Parameters.AddWithValue("@id", user.ID);
            sqlCommand.Parameters.AddWithValue("@nome_completo", user.NOME_COMPLETO);
            sqlCommand.Parameters.AddWithValue("@email", user.EMAIL);
            sqlCommand.Parameters.AddWithValue("@senha", user.SENHA);
            sqlCommand.Parameters.AddWithValue("@contato", user.CONTATO);


            sqlCommand.ExecuteNonQuery();
        }
        //delete 
        public void DeleteUser(int id)
        {
            //Código para excluir 
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Cadastro WHERE ID = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
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
