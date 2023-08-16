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
            if (ckbServiceterms.Checked)
            {
                if (ckbSeller.Checked || ckbClient.Checked)
                {
                    string name = txbName.Text;
                    string email = txbEmail.Text;
                    string contact = txbContat.Text;


                    string message = "Nome: " + name + "\nEmail: " + email + "\nContato: " + contact;

                    MessageBox.Show(
                        message,
                        "ATENÇÃO!",
                        MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                        );
                }
            }
            else
            {
                string message = "-Você precisa aceitar nossos termos de privacidade e preencher o tipo de usuário antes de concluir o cadastro";

                MessageBox.Show(
                    message, 
                    "ATENÇÃO!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
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
