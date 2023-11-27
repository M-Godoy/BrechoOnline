using System;

namespace BrechoOnline
{
    partial class Endereco
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntCEP = new System.Windows.Forms.Button();
            this.bntPais = new System.Windows.Forms.Button();
            this.bntEstado = new System.Windows.Forms.Button();
            this.bntBairro = new System.Windows.Forms.Button();
            this.bntCidade = new System.Windows.Forms.Button();
            this.txbCEP = new System.Windows.Forms.TextBox();
            this.txbPais = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.bntExcluirEndereco = new System.Windows.Forms.Button();
            this.bntEditarEnderco = new System.Windows.Forms.Button();
            this.bntSalvarEndereco = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // bntCEP
            // 
            this.bntCEP.Location = new System.Drawing.Point(12, 12);
            this.bntCEP.Name = "bntCEP";
            this.bntCEP.Size = new System.Drawing.Size(75, 23);
            this.bntCEP.TabIndex = 0;
            this.bntCEP.Text = "CEP";
            this.bntCEP.UseVisualStyleBackColor = true;
            // 
            // bntPais
            // 
            this.bntPais.Location = new System.Drawing.Point(12, 67);
            this.bntPais.Name = "bntPais";
            this.bntPais.Size = new System.Drawing.Size(75, 23);
            this.bntPais.TabIndex = 1;
            this.bntPais.Text = "País";
            this.bntPais.UseVisualStyleBackColor = true;
            // 
            // bntEstado
            // 
            this.bntEstado.Location = new System.Drawing.Point(12, 122);
            this.bntEstado.Name = "bntEstado";
            this.bntEstado.Size = new System.Drawing.Size(75, 23);
            this.bntEstado.TabIndex = 2;
            this.bntEstado.Text = "Estado";
            this.bntEstado.UseVisualStyleBackColor = true;
            // 
            // bntBairro
            // 
            this.bntBairro.Location = new System.Drawing.Point(12, 181);
            this.bntBairro.Name = "bntBairro";
            this.bntBairro.Size = new System.Drawing.Size(75, 23);
            this.bntBairro.TabIndex = 3;
            this.bntBairro.Text = "Bairro";
            this.bntBairro.UseVisualStyleBackColor = true;
            // 
            // bntCidade
            // 
            this.bntCidade.Location = new System.Drawing.Point(12, 236);
            this.bntCidade.Name = "bntCidade";
            this.bntCidade.Size = new System.Drawing.Size(75, 23);
            this.bntCidade.TabIndex = 4;
            this.bntCidade.Text = "Cidade";
            this.bntCidade.UseVisualStyleBackColor = true;
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(12, 41);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(175, 20);
            this.txbCEP.TabIndex = 5;
            // 
            // txbPais
            // 
            this.txbPais.Location = new System.Drawing.Point(12, 96);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(175, 20);
            this.txbPais.TabIndex = 6;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(12, 151);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(175, 20);
            this.txbEstado.TabIndex = 7;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(12, 210);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(175, 20);
            this.txbBairro.TabIndex = 8;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(12, 265);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(175, 20);
            this.txbCidade.TabIndex = 9;
            // 
            // bntExcluirEndereco
            // 
            this.bntExcluirEndereco.Location = new System.Drawing.Point(186, 360);
            this.bntExcluirEndereco.Name = "bntExcluirEndereco";
            this.bntExcluirEndereco.Size = new System.Drawing.Size(75, 23);
            this.bntExcluirEndereco.TabIndex = 10;
            this.bntExcluirEndereco.Text = "Excluir";
            this.bntExcluirEndereco.UseVisualStyleBackColor = true;
            // 
            // bntEditarEnderco
            // 
            this.bntEditarEnderco.Location = new System.Drawing.Point(294, 360);
            this.bntEditarEnderco.Name = "bntEditarEnderco";
            this.bntEditarEnderco.Size = new System.Drawing.Size(75, 23);
            this.bntEditarEnderco.TabIndex = 11;
            this.bntEditarEnderco.Text = "Editar";
            this.bntEditarEnderco.UseVisualStyleBackColor = true;
            // 
            // bntSalvarEndereco
            // 
            this.bntSalvarEndereco.Location = new System.Drawing.Point(410, 360);
            this.bntSalvarEndereco.Name = "bntSalvarEndereco";
            this.bntSalvarEndereco.Size = new System.Drawing.Size(75, 23);
            this.bntSalvarEndereco.TabIndex = 12;
            this.bntSalvarEndereco.Text = "Salvar";
            this.bntSalvarEndereco.UseVisualStyleBackColor = true;
            // 
            // ListView1
            // 
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(342, 12);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(446, 289);
            this.ListView1.TabIndex = 13;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            // 
            // Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.bntSalvarEndereco);
            this.Controls.Add(this.bntEditarEnderco);
            this.Controls.Add(this.bntExcluirEndereco);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbPais);
            this.Controls.Add(this.txbCEP);
            this.Controls.Add(this.bntCidade);
            this.Controls.Add(this.bntBairro);
            this.Controls.Add(this.bntEstado);
            this.Controls.Add(this.bntPais);
            this.Controls.Add(this.bntCEP);
            this.Name = "Endereco";
            this.Text = "Endereço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCEP;
        private System.Windows.Forms.Button bntPais;
        private System.Windows.Forms.Button bntEstado;
        private System.Windows.Forms.Button bntBairro;
        private System.Windows.Forms.Button bntCidade;
        private System.Windows.Forms.TextBox txbCEP;
        private System.Windows.Forms.TextBox txbPais;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Button bntExcluirEndereco;
        private System.Windows.Forms.Button bntEditarEnderco;
        private System.Windows.Forms.Button bntSalvarEndereco;
        private System.Windows.Forms.ListView ListView1;

        public EventHandler Endereco_Load { get; private set; }
    }
}