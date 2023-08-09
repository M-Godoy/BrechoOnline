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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string style = txbStyle.Text;

            string message = "Nome: " + name + "\nEstilo: " + style;

            MessageBox.Show(
                message,
                "ATENÇÃO!", 
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }
    }
}
