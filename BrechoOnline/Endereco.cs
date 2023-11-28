﻿using System;
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
                foreach (Dados.Dado endereco in enderecos)
                {

                    ListViewItem lv2 = new ListViewItem(endereco.Id.ToString());
                    lv2.SubItems.Add(endereco.Cep.ToString());
                    lv2.SubItems.Add(endereco.Pais);
                    lv2.SubItems.Add(endereco.Estado);
                    lv2.SubItems.Add(endereco.Bairro);
                    lv2.SubItems.Add(endereco.Cidade);
                    ListView1.Items.Add(lv2);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bntSalvar(object sender, EventArgs e)
        {
            try
            {
                //esse verde água é o nome da sua classe.
                Dados.Dado endereco = new Dados.Dado(
                    Convert.ToInt16(txbCEP.Text),
                    txbPais.Text,
                    txbEstado.Text,
                    txbBairro.Text,
                    txbCidade.Text
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
            txbBairro.Clear();
            txbCidade.Clear();

            UpdateListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                //esse verde água é o nome da sua classe.
                Dados.Dado endereco = new Dados.Dado(
                    Id,
                    Convert.ToInt16(txbCEP.Text),
                    txbPais.Text,
                    txbEstado.Text,
                    txbBairro.Text,
                    txbCidade.Text
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
            txbBairro.Clear();
            txbCidade.Clear();
            UpdateListView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
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
            txbBairro.Clear();
            txbCidade.Clear();
            UpdateListView();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = ListView1.FocusedItem.Index;
            Id = int.Parse(ListView1.Items[index].SubItems[0].Text);
            txbCEP.Text = (ListView1.Items[index].SubItems[5].Text);
            txbPais.Text = ListView1.Items[index].SubItems[1].Text;
            txbEstado.Text = ListView1.Items[index].SubItems[2].Text;
            txbBairro.Text = ListView1.Items[index].SubItems[4].Text;
            txbCidade.Text = ListView1.Items[index].SubItems[3].Text;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = ListView1.FocusedItem.Index;
            Id = int.Parse(ListView1.Items[index].SubItems[0].Text);
            txbCEP.Text = (ListView1.Items[index].SubItems[5].Text);
            txbPais.Text = ListView1.Items[index].SubItems[1].Text;
            txbEstado.Text = ListView1.Items[index].SubItems[2].Text;
            txbBairro.Text = ListView1.Items[index].SubItems[4].Text;
            txbCidade.Text = ListView1.Items[index].SubItems[3].Text;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}

