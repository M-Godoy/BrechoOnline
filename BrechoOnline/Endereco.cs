﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BrechoOnline
{
    public partial class Endereco : Form
    {
        public Endereco()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            ListView1.Items.Clear();
            DadosDAO dadosDAO = new DadosDAO();
            List<DadosDAO> dados = DadosDAO.SelectEndereco();

            try
            {
                foreach (Dados Dado in dados)
                {

                    ListViewItem lv = new ListViewItem(dado.ID.ToString());
                    lv.SubItems.Add(dados.CEP.ToString());
                    lv.SubItems.Add();
                    lv.SubItems.Add();
                    lv.SubItems.Add();
                    ListView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Criar objeto da classe Usuario.
                //esse verde água é o nome da sua classe.
                Endereco user = new Endereco(
                    txbPais.Text,
                    txbEstado.Text,
                    txbCidade.Text,
                    txbRua.Text
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

            txbPais.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbRua.Clear();
            txbNum.Clear();

            UpdateListView();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
}