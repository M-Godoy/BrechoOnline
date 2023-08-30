using System;
using System.Data;
using System.Data.SqlClient;

namespace brechoonline
{ 
 
    internal class Connection
    {
        //Propriedades ou atributos
        private readonly SqlConnection con;
        private readonly string DataBase = "Brechó_Online";

        //Construtor
        public Connection()                            //LAPTOP-9TN8R1CF\SQLEXPRESS
        {
            //Data Source=LAPTOP-9TN8R1CF\SQLEXPRESS;Initial Catalog=InvestimentosMais;Integrated Security=True
            string stringConnection = @"Data Source="
                    + Environment.MachineName +
                    @"\SQLEXPRESS;Initial Catalog=" +
                    DataBase + ";Integrated Security=true";

            con = new SqlConnection(stringConnection);
            con.Open();   //Abrir a conexão com o banco de dados
        }
        //Tenta fechar a conexão com o banco
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //Retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }

    }

}


