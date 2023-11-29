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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnNome = new System.Windows.Forms.Button();
            this.btnSenha = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.LinkLabel();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNome.Location = new System.Drawing.Point(193, 179);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(75, 23);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "Nome";
            this.btnNome.UseVisualStyleBackColor = true;
            // 
            // btnSenha
            // 
            this.btnSenha.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSenha.Location = new System.Drawing.Point(193, 221);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(75, 23);
            this.btnSenha.TabIndex = 1;
            this.btnSenha.Text = "Senha";
            this.btnSenha.UseVisualStyleBackColor = true;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(300, 182);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(239, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(300, 221);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(239, 20);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // Cadastrar
            // 
            this.Cadastrar.AutoSize = true;
            this.Cadastrar.BackColor = System.Drawing.Color.Brown;
            this.Cadastrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cadastrar.LinkColor = System.Drawing.Color.White;
            this.Cadastrar.Location = new System.Drawing.Point(190, 270);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(63, 16);
            this.Cadastrar.TabIndex = 4;
            this.Cadastrar.TabStop = true;
            this.Cadastrar.Text = "Cadastro";
            this.Cadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Cadastrar_LinkClicked);
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(385, 247);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 39);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLimpar.Location = new System.Drawing.Point(385, 292);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(84, 37);
            this.bntLimpar.TabIndex = 6;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(380, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.btnNome);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}