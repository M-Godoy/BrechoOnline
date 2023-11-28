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
            this.lblTelaPrincipal = new System.Windows.Forms.Label();
            this.Enderecar = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTelaPrincipal
            // 
            this.lblTelaPrincipal.AutoSize = true;
            this.lblTelaPrincipal.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelaPrincipal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTelaPrincipal.Location = new System.Drawing.Point(282, 35);
            this.lblTelaPrincipal.Name = "lblTelaPrincipal";
            this.lblTelaPrincipal.Size = new System.Drawing.Size(178, 30);
            this.lblTelaPrincipal.TabIndex = 0;
            this.lblTelaPrincipal.Text = "Tela Principal";
            // 
            // Enderecar
            // 
            this.Enderecar.AutoSize = true;
            this.Enderecar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Enderecar.Location = new System.Drawing.Point(22, 428);
            this.Enderecar.Name = "Enderecar";
            this.Enderecar.Size = new System.Drawing.Size(53, 13);
            this.Enderecar.TabIndex = 1;
            this.Enderecar.TabStop = true;
            this.Enderecar.Text = "Endereço";
            this.Enderecar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Enderecar_LinkClicked);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enderecar);
            this.Controls.Add(this.lblTelaPrincipal);
            this.Name = "TelaPrincipal";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTelaPrincipal;
        private System.Windows.Forms.LinkLabel Enderecar;
    }
}