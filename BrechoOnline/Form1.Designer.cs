namespace BrechoOnline
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ckbClient = new System.Windows.Forms.CheckBox();
            this.ckbSeller = new System.Windows.Forms.CheckBox();
            this.ckbServiceterms = new System.Windows.Forms.CheckBox();
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
            this.txbName.Location = new System.Drawing.Point(12, 28);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(229, 20);
            this.txbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblName.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nome completo";
            this.lblName.Click += new System.EventHandler(this.Nome_Click);
            // 
            // ckbClient
            // 
            this.ckbClient.AutoSize = true;
            this.ckbClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbClient.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbClient.Location = new System.Drawing.Point(12, 321);
            this.ckbClient.Name = "ckbClient";
            this.ckbClient.Size = new System.Drawing.Size(70, 19);
            this.ckbClient.TabIndex = 5;
            this.ckbClient.Text = "Cliente";
            this.ckbClient.UseVisualStyleBackColor = false;
            // 
            // ckbSeller
            // 
            this.ckbSeller.AutoSize = true;
            this.ckbSeller.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbSeller.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSeller.Location = new System.Drawing.Point(12, 346);
            this.ckbSeller.Name = "ckbSeller";
            this.ckbSeller.Size = new System.Drawing.Size(87, 19);
            this.ckbSeller.TabIndex = 6;
            this.ckbSeller.Text = "Vendedor";
            this.ckbSeller.UseVisualStyleBackColor = false;
            // 
            // ckbServiceterms
            // 
            this.ckbServiceterms.AutoSize = true;
            this.ckbServiceterms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ckbServiceterms.Location = new System.Drawing.Point(12, 452);
            this.ckbServiceterms.Name = "ckbServiceterms";
            this.ckbServiceterms.Size = new System.Drawing.Size(235, 17);
            this.ckbServiceterms.TabIndex = 7;
            this.ckbServiceterms.Text = "Eu li e concordo com os termos de serviço...";
            this.ckbServiceterms.UseVisualStyleBackColor = false;
            this.ckbServiceterms.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblStyle_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(12, 88);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(229, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPassword.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(12, 131);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Senha";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(12, 149);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(229, 20);
            this.txbPassword.TabIndex = 9;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // lblContat
            // 
            this.lblContat.AutoSize = true;
            this.lblContat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblContat.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContat.Location = new System.Drawing.Point(12, 191);
            this.lblContat.Name = "lblContat";
            this.lblContat.Size = new System.Drawing.Size(57, 15);
            this.lblContat.TabIndex = 10;
            this.lblContat.Text = "Contato";
            // 
            // txbContat
            // 
            this.txbContat.Location = new System.Drawing.Point(12, 209);
            this.txbContat.Mask = "(00) 00000-0000";
            this.txbContat.Name = "txbContat";
            this.txbContat.Size = new System.Drawing.Size(100, 20);
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
            this.bntEditar.Location = new System.Drawing.Point(700, 420);
            this.bntEditar.Name = "bntEditar";
            this.bntEditar.Size = new System.Drawing.Size(114, 49);
            this.bntEditar.TabIndex = 14;
            this.bntEditar.Text = "Editar";
            this.bntEditar.UseVisualStyleBackColor = true;
            this.bntEditar.Click += new System.EventHandler(this.bntEditar_Click);
            // 
            // bntExcluir
            // 
            this.bntExcluir.Location = new System.Drawing.Point(565, 420);
            this.bntExcluir.Name = "bntExcluir";
            this.bntExcluir.Size = new System.Drawing.Size(114, 49);
            this.bntExcluir.TabIndex = 15;
            this.bntExcluir.Text = "Excluir";
            this.bntExcluir.UseVisualStyleBackColor = true;
            this.bntExcluir.Click += new System.EventHandler(this.bntExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1002, 481);
            this.Controls.Add(this.bntExcluir);
            this.Controls.Add(this.bntEditar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbContat);
            this.Controls.Add(this.lblContat);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.ckbServiceterms);
            this.Controls.Add(this.ckbSeller);
            this.Controls.Add(this.ckbClient);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox ckbClient;
        private System.Windows.Forms.CheckBox ckbSeller;
        private System.Windows.Forms.CheckBox ckbServiceterms;
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
    }
}

