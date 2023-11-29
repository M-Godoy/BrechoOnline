using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrechoOnline
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void Enderecar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Endereco tela = new Endereco();
            tela.ShowDialog();
        }

        private void lblTelaPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void Sair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login tela = new Login();
            tela.ShowDialog();
        }
    }
}
