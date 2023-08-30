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

            sqlCommand.Parameters.AddWithValue("@NOME", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@EMAIL", txbEmail.Text);
            sqlCommand.Parameters.AddWithValue("@SENHA", txbPassword.Text);
            sqlCommand.Parameters.AddWithValue("@CONTATO", txbContat.Text);

            sqlCommand.ExecuteNonQuery();

            //if (ckbServiceterms.Checked)
            //{
            //    if (ckbSeller.Checked || ckbClient.Checked)
            //    {
            //        string name = txbName.Text;
            //        string email = txbEmail.Text;
            //        string contact = txbContat.Text;
            //        string message = "Nome: " + name + "\nEmail: " + email + "\nContato: " + contact;

            //        MessageBox.Show(
            //            message,
            //            "ATENÇÃO!",
            //            MessageBoxButtons.OK,
            //        MessageBoxIcon.Information
            //            );
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
    }
}
