using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Security.Authentication.ExtendedProtection;
using brechoonline;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BrechoOnline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = "INSERT INTO Cadastro VALUES (@NOME_COMPLETO, @EMAIL, @SENHA, @CONTATO)";

            sqlCommand.Parameters.AddWithValue("@NOME_COMPLETO", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@EMAIL", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@SENHA", txbPassword.Text);
            sqlCommand.Parameters.AddWithValue("@CONTATO", Convert.ToDecimal(txbContat.Text.Replace(" ","").Replace("(","").Replace(")","").Replace("-","")));
            

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastro com sucesso",
              "AVISO",
              MessageBoxButtons.OK,
              MessageBoxIcon.Information);

            txbName.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            txbContat.Clear();







            //if (ckbServiceterms.Checked)
            //{
            //    if (ckbSeller.Checked || ckbClient.Checked)
            //    {
            //        string name = txbName.Text;
            //        string email = txbEmail.Text;
            //        string contact = txbContat.Text;
            //        string message = "Nome: " + name + "\nEmail: " + email + "\nContato: " + contact;

            //    }
            //    else
            //    {
            //        string message = "-Você precisa aceitar nossos termos de privacidade e preencher o tipo de usuário antes de concluir o cadastro";

            //        MessageBox.Show(
            //            message,
            //            "ATENÇÃO!",
            //            MessageBoxButtons.OK,
            //            MessageBoxIcon.Information
            //            );
            //    }
            //}
            //else
            //{
            //    string message = "-Você precisa aceitar nossos termos de privacidade e preencher o tipo de usuário antes de concluir o cadastro";

            //    MessageBox.Show(
            //        message,
            //        "ATENÇÃO!",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //        );
            //}
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblStyle_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbContat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {
        //    string email = "exemplo@email.com";

        //    if (IsValidEmail(email))
        //    {
        //        Console.WriteLine("O e-mail é válido.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("O e-mail não é válido.");
        //    }
        //}

        //static bool IsValidEmail(string email)
        //{
        //    // Define a expressão regular para validar o e-mail.
        //    string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        //    // Cria um objeto Regex com o padrão.
        //    Regex regex = new Regex(pattern);

        //    // Usa o método Match para verificar se a string corresponde ao padrão.
        //    return regex.IsMatch(email);
        }
    }
}
