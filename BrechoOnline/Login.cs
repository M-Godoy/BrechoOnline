using BrechoOnline;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BrechoOnline
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string hashPassL = Senha.Sha256(txbSenha.Text);

            Usuario user = new Usuario(
                txbNome.Text, hashPassL
                ) ;

            //inserir dado
            UsuarioDAO dadosUser = new UsuarioDAO();
            if (dadosUser.Login(user))
            {
                // instânciando um objeto da classe form1 (esses são os comando para abrir outra tela)
                TelaPrincipal tela = new TelaPrincipal();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
        }

        private void Cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro tela = new Cadastro();
            tela.ShowDialog();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Clear();
            txbSenha.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            txbSenha.Text = new string('*', txbSenha.Text.Length);
        }
    }
}
    