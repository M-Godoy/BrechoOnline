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

            // Inicialize o controle MonthCalendar
            monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            monthCalendar1.Location = new System.Drawing.Point(10, 10);

            // Adicione o controle ao formulário
            this.Controls.Add(monthCalendar1);

            
        }

        private System.Windows.Forms.MonthCalendar calendar;

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            // Inicialize o controle MonthCalendar
            calendar = new System.Windows.Forms.MonthCalendar();
            calendar.Location = new System.Drawing.Point(10, 10);

            // Adicione o controle ao formulário
            this.Controls.Add(calendar);

            // Associe o manipulador de eventos DateSelected
            calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
        }
        private void calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime dataSelecionada = e.Start;

            // Aqui você pode fazer o que quiser com a data selecionada
            // Pode ser salvar no banco de dados, exibir em algum lugar, etc.
            MessageBox.Show($"Data de entrega marcada para: {dataSelecionada.ToShortDateString()}");
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
