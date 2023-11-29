namespace BrechoOnline
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.lblTelaPrincipal = new System.Windows.Forms.Label();
            this.Enderecar = new System.Windows.Forms.LinkLabel();
            this.Sair = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTelaPrincipal
            // 
            this.lblTelaPrincipal.AutoSize = true;
            this.lblTelaPrincipal.BackColor = System.Drawing.Color.MistyRose;
            this.lblTelaPrincipal.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaPrincipal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTelaPrincipal.Location = new System.Drawing.Point(280, 24);
            this.lblTelaPrincipal.Name = "lblTelaPrincipal";
            this.lblTelaPrincipal.Size = new System.Drawing.Size(224, 40);
            this.lblTelaPrincipal.TabIndex = 0;
            this.lblTelaPrincipal.Text = "Tela Principal";
            this.lblTelaPrincipal.Click += new System.EventHandler(this.lblTelaPrincipal_Click);
            // 
            // Enderecar
            // 
            this.Enderecar.AutoSize = true;
            this.Enderecar.BackColor = System.Drawing.Color.MistyRose;
            this.Enderecar.Font = new System.Drawing.Font("Noto Sans Cond", 18F);
            this.Enderecar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Enderecar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Enderecar.Location = new System.Drawing.Point(12, 627);
            this.Enderecar.Name = "Enderecar";
            this.Enderecar.Size = new System.Drawing.Size(101, 33);
            this.Enderecar.TabIndex = 1;
            this.Enderecar.TabStop = true;
            this.Enderecar.Text = "Endereço";
            this.Enderecar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Enderecar_LinkClicked);
            // 
            // Sair
            // 
            this.Sair.AutoSize = true;
            this.Sair.BackColor = System.Drawing.Color.IndianRed;
            this.Sair.Font = new System.Drawing.Font("Noto Sans Cond", 18F);
            this.Sair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sair.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sair.Location = new System.Drawing.Point(738, 627);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(50, 33);
            this.Sair.TabIndex = 2;
            this.Sair.TabStop = true;
            this.Sair.Text = "Sair";
            this.Sair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Sair_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 392);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(287, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 232);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(623, 392);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 232);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 686);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Enderecar);
            this.Controls.Add(this.lblTelaPrincipal);
            this.Name = "TelaPrincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelaPrincipal;
        private System.Windows.Forms.LinkLabel Enderecar;
        private System.Windows.Forms.LinkLabel Sair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}