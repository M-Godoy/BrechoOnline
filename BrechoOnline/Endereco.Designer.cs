using System;
using System.Drawing.Printing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Endereco));
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCEP
            // 
            this.bntCEP.Location = new System.Drawing.Point(12, 73);
            this.bntCEP.Name = "bntCEP";
            this.bntCEP.Size = new System.Drawing.Size(75, 23);
            this.bntCEP.TabIndex = 0;
            this.bntCEP.Text = "CEP";
            this.bntCEP.UseVisualStyleBackColor = true;
            // 
            // bntPais
            // 
            this.bntPais.Location = new System.Drawing.Point(12, 128);
            this.bntPais.Name = "bntPais";
            this.bntPais.Size = new System.Drawing.Size(75, 23);
            this.bntPais.TabIndex = 1;
            this.bntPais.Text = "País";
            this.bntPais.UseVisualStyleBackColor = true;
            // 
            // bntEstado
            // 
            this.bntEstado.Location = new System.Drawing.Point(12, 183);
            this.bntEstado.Name = "bntEstado";
            this.bntEstado.Size = new System.Drawing.Size(75, 23);
            this.bntEstado.TabIndex = 2;
            this.bntEstado.Text = "Estado";
            this.bntEstado.UseVisualStyleBackColor = true;
            // 
            // bntBairro
            // 
            this.bntBairro.Location = new System.Drawing.Point(12, 293);
            this.bntBairro.Name = "bntBairro";
            this.bntBairro.Size = new System.Drawing.Size(75, 23);
            this.bntBairro.TabIndex = 3;
            this.bntBairro.Text = "Bairro";
            this.bntBairro.UseVisualStyleBackColor = true;
            // 
            // bntCidade
            // 
            this.bntCidade.Location = new System.Drawing.Point(12, 238);
            this.bntCidade.Name = "bntCidade";
            this.bntCidade.Size = new System.Drawing.Size(75, 23);
            this.bntCidade.TabIndex = 4;
            this.bntCidade.Text = "Cidade";
            this.bntCidade.UseVisualStyleBackColor = true;
            // 
            // txbCEP
            // 
            this.txbCEP.Location = new System.Drawing.Point(12, 102);
            this.txbCEP.Name = "txbCEP";
            this.txbCEP.Size = new System.Drawing.Size(175, 20);
            this.txbCEP.TabIndex = 5;
            // 
            // txbPais
            // 
            this.txbPais.Location = new System.Drawing.Point(12, 157);
            this.txbPais.Name = "txbPais";
            this.txbPais.Size = new System.Drawing.Size(175, 20);
            this.txbPais.TabIndex = 6;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(12, 212);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(175, 20);
            this.txbEstado.TabIndex = 7;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(12, 322);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(175, 20);
            this.txbBairro.TabIndex = 8;
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(12, 267);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(175, 20);
            this.txbCidade.TabIndex = 9;
            // 
            // bntExcluirEndereco
            // 
            this.bntExcluirEndereco.Location = new System.Drawing.Point(551, 415);
            this.bntExcluirEndereco.Name = "bntExcluirEndereco";
            this.bntExcluirEndereco.Size = new System.Drawing.Size(75, 23);
            this.bntExcluirEndereco.TabIndex = 10;
            this.bntExcluirEndereco.Text = "Excluir";
            this.bntExcluirEndereco.UseVisualStyleBackColor = true;
            // 
            // bntEditarEnderco
            // 
            this.bntEditarEnderco.Location = new System.Drawing.Point(632, 415);
            this.bntEditarEnderco.Name = "bntEditarEnderco";
            this.bntEditarEnderco.Size = new System.Drawing.Size(75, 23);
            this.bntEditarEnderco.TabIndex = 11;
            this.bntEditarEnderco.Text = "Editar";
            this.bntEditarEnderco.UseVisualStyleBackColor = true;
            // 
            // bntSalvarEndereco
            // 
            this.bntSalvarEndereco.Location = new System.Drawing.Point(713, 415);
            this.bntSalvarEndereco.Name = "bntSalvarEndereco";
            this.bntSalvarEndereco.Size = new System.Drawing.Size(75, 23);
            this.bntSalvarEndereco.TabIndex = 12;
            this.bntSalvarEndereco.Text = "Salvar";
            this.bntSalvarEndereco.UseVisualStyleBackColor = true;
            this.bntSalvarEndereco.Click += new System.EventHandler(this.bntSalvarEndereco_Click);
            // 
            // ListView1
            // 
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.ListView1.HideSelection = false;
            this.ListView1.Location = new System.Drawing.Point(342, 73);
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(446, 289);
            this.ListView1.TabIndex = 13;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            this.ListView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            this.ListView1.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CEP";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "País";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cidade";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bairro";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblEndereco.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(306, 23);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(125, 30);
            this.lblEndereco.TabIndex = 14;
            this.lblEndereco.Text = "Endereço";
            this.lblEndereco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Endereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEndereco);
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
            this.Load += new System.EventHandler(this.Endereco_Load);
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;

    
    }
}