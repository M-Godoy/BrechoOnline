namespace BrechoOnline
{
    partial class Login
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
            this.btnNome = new System.Windows.Forms.Button();
            this.btnSenha = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(193, 167);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(75, 23);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "Nome";
            this.btnNome.UseVisualStyleBackColor = true;
            // 
            // btnSenha
            // 
            this.btnSenha.Location = new System.Drawing.Point(193, 196);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(75, 23);
            this.btnSenha.TabIndex = 1;
            this.btnSenha.Text = "Senha";
            this.btnSenha.UseVisualStyleBackColor = true;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(300, 170);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(300, 208);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 3;
            // 
            // Cadastrar
            // 
            this.Cadastrar.AutoSize = true;
            this.Cadastrar.Location = new System.Drawing.Point(190, 245);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(49, 13);
            this.Cadastrar.TabIndex = 4;
            this.Cadastrar.TabStop = true;
            this.Cadastrar.Text = "Cadastro";
            this.Cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cadastrar_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(300, 240);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(300, 269);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 6;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.btnNome);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.LinkLabel Cadastrar;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button bntLimpar;
    }
}