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
using static BrechoOnline.Dados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrechoOnline
{
    public partial class Endereco : Form
    {
        private int Id;
        public Endereco()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            ListView1.Items.Clear();
            DadosDAO dado = new DadosDAO();
            List<Dados.Dado> enderecos = dado.SelectEndereco();

            try
            {
                if (enderecos != null && enderecos.Count > 0)
                {

                    foreach (Dados.Dado endereco in enderecos)
                    {

                        ListViewItem lv2 = new ListViewItem(endereco.Id.ToString());
                        lv2.SubItems.Add(endereco.Cep.ToString());
                        lv2.SubItems.Add(endereco.Pais);
                        lv2.SubItems.Add(endereco.Estado);
                        lv2.SubItems.Add(endereco.Cidade);
                        lv2.SubItems.Add(endereco.Bairro);
                        ListView1.Items.Add(lv2);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bntSalvarEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                //esse verde água é o nome da sua classe.
                Dados.Dado endereco = new Dados.Dado(
                    Convert.ToDecimal(txbCEP.Text),
                    txbPais.Text,
                    txbEstado.Text,
                    txbCidade.Text,
                    txbBairro.Text
                    );

                //Chamando método de inserir (inserção).
                DadosDAO dado = new DadosDAO();
                dado.InsertEndereco(endereco);

                MessageBox.Show("Cadastrado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbCEP.Clear();
            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbBairro.Clear();

            UpdateListView();
        }

        private void bntEditarEnderco_Click(object sender, EventArgs e)
        {
            try
            {
                //esse verde água é o nome da sua classe.
                Dados.Dado endereco = new Dados.Dado(
                    Id,
                    Convert.ToDecimal(txbCEP.Text),
                    txbPais.Text,
                    txbEstado.Text,
                    txbCidade.Text,
                    txbBairro.Text
                    );

                //Chamando método de inserir (inserção).
                //UsuarioDAO nomeDoObj = new UsuarioDAO();
                DadosDAO dado = new DadosDAO();
                dado.UpdateEndereco(endereco);

                MessageBox.Show("Atualizado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbCEP.Clear();
            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbBairro.Clear();
            UpdateListView();
        }

        private void bntExcluirEndereco_Click(object sender, EventArgs e)
        {
            //Chamando método de exclussão
            DadosDAO dado = new DadosDAO();
            dado.DeleteEndereco(Id);

            MessageBox.Show("Excluido com sucesso",
            "AVISO",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

            txbCEP.Clear();
            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbBairro.Clear();
            UpdateListView();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = ListView1.FocusedItem.Index;
            Id = int.Parse(ListView1.Items[index].SubItems[0].Text);
            txbCEP.Text = (ListView1.Items[index].SubItems[1].Text);
            txbPais.Text = ListView1.Items[index].SubItems[2].Text;
            txbEstado.Text = ListView1.Items[index].SubItems[3].Text;
            txbCidade.Text = ListView1.Items[index].SubItems[4].Text;
            txbBairro.Text = ListView1.Items[index].SubItems[5].Text;
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = ListView1.FocusedItem.Index;
            Id = int.Parse(ListView1.Items[index].SubItems[0].Text);
            txbCEP.Text = (ListView1.Items[index].SubItems[1].Text);
            txbPais.Text = ListView1.Items[index].SubItems[2].Text;
            txbEstado.Text = ListView1.Items[index].SubItems[3].Text;
            txbCidade.Text = ListView1.Items[index].SubItems[4].Text;
            txbBairro.Text = ListView1.Items[index].SubItems[5].Text;
        }

        private void Endereco_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.ShowDialog();
        }
    }
}

