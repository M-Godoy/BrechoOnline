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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrechoOnline
{
    public partial class Login : Form
    {
        private int id;

        public Login() //Método construtor
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            listView1.Items.Clear();
            UsuarioDAO dadosUser = new UsuarioDAO();
            List<Usuario> users = dadosUser.SelectUser();

            try
            {
                foreach (Usuario user in users)
                {

                    ListViewItem lv = new ListViewItem(user.ID.ToString());
                    lv.SubItems.Add(user.NOME_COMPLETO);
                    lv.SubItems.Add(user.EMAIL);
                    lv.SubItems.Add(user.SENHA.ToString());
                    lv.SubItems.Add(user.CONTATO.ToString());
                    listView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar objeto da classe Usuario. 
                //esse verde água é o nome da sua classe. 
                Usuario user = new Usuario(
                
                    txbName.Text,
                    txbEmail.Text,
                    txbPassword.Text,
                    Convert.ToDecimal(txbContat.Text)
                    );

                //Chamando método de inserir (inserção). 
                //UsuarioDAO nomeDoObj = new UsuarioDAO(); 
                UsuarioDAO dadosUser = new UsuarioDAO();
                dadosUser.InsertUser(user);

                MessageBox.Show("Cadastrado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbName.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            txbContat.Clear();

            UpdateListView();




            ////Condição própria, mas não importante para o trabalho
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

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar objeto da classe Usuario. 
                //esse verde água é o nome da sua classe. 
                Usuario user = new Usuario(
                    id,
                    txbName.Text,
                    txbEmail.Text,
                    txbPassword.Text,
                    Convert.ToDecimal(txbContat.Text)

                    );

                //Chamando método de inserir (inserção). 
                //UsuarioDAO nomeDoObj = new UsuarioDAO(); 
                UsuarioDAO dadosUser = new UsuarioDAO();
                dadosUser.UpdateUser(user);

                MessageBox.Show("Atualizado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbName.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            txbContat.Clear();

            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            txbName.Text = listView1.Items[index].SubItems[1].Text;
            txbEmail.Text = listView1.Items[index].SubItems[2].Text;
            txbContat.Text = listView1.Items[index].SubItems[3].Text;
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            //chamando método de exclusão
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeleteUser(id                                       );

            //limpar campos
            txbName.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            txbContat.Clear();

            //atualizar listView
            UpdateListView();

            //mensagem de exclusão
            MessageBox.Show("Excluído com sucesso",
         "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }
    }
}
