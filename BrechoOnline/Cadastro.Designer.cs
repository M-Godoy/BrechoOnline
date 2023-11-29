namespace BrechoOnline
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblContat = new System.Windows.Forms.Label();
            this.txbContat = new System.Windows.Forms.MaskedTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEMAIL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCONTATO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntEditar = new System.Windows.Forms.Button();
            this.bntExcluir = new System.Windows.Forms.Button();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.ckbServiceterms = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.LightCoral;
            this.btnLogin.Location = new System.Drawing.Point(863, 420);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Cadastro";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(15, 112);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(373, 20);
            this.txbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblName.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 85);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(172, 24);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome completo";
            this.lblName.Click += new System.EventHandler(this.Nome_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblStyle_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(16, 167);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(372, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 199);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 24);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Senha";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(15, 226);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(373, 20);
            this.txbPassword.TabIndex = 9;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // lblContat
            // 
            this.lblContat.AutoSize = true;
            this.lblContat.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblContat.Font = new System.Drawing.Font("Lucida Bright", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContat.Location = new System.Drawing.Point(12, 258);
            this.lblContat.Name = "lblContat";
            this.lblContat.Size = new System.Drawing.Size(91, 24);
            this.lblContat.TabIndex = 10;
            this.lblContat.Text = "Contato";
            // 
            // txbContat
            // 
            this.txbContat.Location = new System.Drawing.Point(12, 285);
            this.txbContat.Mask = "(00) 00000-0000";
            this.txbContat.Name = "txbContat";
            this.txbContat.Size = new System.Drawing.Size(376, 20);
            this.txbContat.TabIndex = 12;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnName,
            this.columnEMAIL,
            this.columnCONTATO});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(526, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(464, 353);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            // 
            // columnName
            // 
            this.columnName.Text = "NOME COMPLETO";
            // 
            // columnEMAIL
            // 
            this.columnEMAIL.Text = "EMAIL";
            // 
            // columnCONTATO
            // 
            this.columnCONTATO.Text = "CONTATO";
            // 
            // bntEditar
            // 
            this.bntEditar.BackColor = System.Drawing.Color.Salmon;
            this.bntEditar.Font = new System.Drawing.Font("Miriam CLM", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bntEditar.Location = new System.Drawing.Point(700, 420);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(114, 49);
            this.bntEditar.TabIndex = 14;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = false;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.BackColor = System.Drawing.Color.Salmon;
            this.bntExcluir.Font = new System.Drawing.Font("Miriam CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bntExcluir.Location = new System.Drawing.Point(565, 420);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(114, 49);
            this.bntExcluir.TabIndex = 15;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = false;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblCadastro.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCadastro.Location = new System.Drawing.Point(10, 12);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(117, 30);
            this.lblCadastro.TabIndex = 16;
            this.lblCadastro.Text = "Cadastro";
            // 
            // ckbServiceterms
            // 
            this.ckbServiceterms.AutoSize = true;
            this.ckbServiceterms.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ckbServiceterms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbServiceterms.Location = new System.Drawing.Point(15, 463);
            this.ckbServiceterms.Name = "ckbServiceterms";
            this.ckbServiceterms.Size = new System.Drawing.Size(288, 20);
            this.ckbServiceterms.TabIndex = 18;
            this.ckbServiceterms.Text = "Eu li e concordo com os termos de serviço...";
            this.ckbServiceterms.UseVisualStyleBackColor = false;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 481);
            this.Controls.Add(this.ckbServiceterms);
            this.Controls.Add(this.lblCadastro);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbContat);
            this.Controls.Add(this.lblContat);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnLogin);
            this.Name = "Cadastro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblContat;
        private System.Windows.Forms.MaskedTextBox txbContat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnEMAIL;
        private System.Windows.Forms.ColumnHeader columnCONTATO;
        private System.Windows.Forms.Button bntEditar;
        private System.Windows.Forms.Button bntExcluir;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.CheckBox ckbServiceterms;
    }
}

