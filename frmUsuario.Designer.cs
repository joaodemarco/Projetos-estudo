namespace CadastroCliente
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelec = new System.Windows.Forms.Button();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIncluirUser = new FontAwesome.Sharp.IconButton();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.chkInserirCliente = new System.Windows.Forms.CheckBox();
            this.chkAlterarCliente = new System.Windows.Forms.CheckBox();
            this.chkPesquisaCliente = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkProduto = new System.Windows.Forms.CheckBox();
            this.chkInserirProd = new System.Windows.Forms.CheckBox();
            this.chkAlterarProd = new System.Windows.Forms.CheckBox();
            this.chkPesquisarProd = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chkUsuario = new System.Windows.Forms.CheckBox();
            this.chkInserirUser = new System.Windows.Forms.CheckBox();
            this.chkAlterarUser = new System.Windows.Forms.CheckBox();
            this.chkVisualizar = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pbClientes = new FontAwesome.Sharp.IconPictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnSelec);
            this.panel1.Controls.Add(this.cbUsuarios);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnIncluirUser);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnSelec
            // 
            this.btnSelec.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSelec.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelec.Location = new System.Drawing.Point(253, 26);
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(75, 23);
            this.btnSelec.TabIndex = 4;
            this.btnSelec.Text = "Selecionar";
            this.btnSelec.UseVisualStyleBackColor = false;
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(109, 27);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cbUsuarios.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(76, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 76);
            this.panel2.TabIndex = 2;
            // 
            // btnIncluirUser
            // 
            this.btnIncluirUser.BackColor = System.Drawing.Color.Transparent;
            this.btnIncluirUser.FlatAppearance.BorderSize = 0;
            this.btnIncluirUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnIncluirUser.IconColor = System.Drawing.Color.Black;
            this.btnIncluirUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncluirUser.Location = new System.Drawing.Point(13, 0);
            this.btnIncluirUser.Name = "btnIncluirUser";
            this.btnIncluirUser.Size = new System.Drawing.Size(55, 70);
            this.btnIncluirUser.TabIndex = 1;
            this.btnIncluirUser.Text = "Novo";
            this.btnIncluirUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluirUser.UseVisualStyleBackColor = false;
            this.btnIncluirUser.Click += new System.EventHandler(this.btnIncluirUser_Click);
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Enabled = false;
            this.chkCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCliente.Location = new System.Drawing.Point(12, 97);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(137, 19);
            this.chkCliente.TabIndex = 1;
            this.chkCliente.Text = "Cadastro de clientes";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkCliente_MouseClick);
            // 
            // chkInserirCliente
            // 
            this.chkInserirCliente.AutoSize = true;
            this.chkInserirCliente.Enabled = false;
            this.chkInserirCliente.Location = new System.Drawing.Point(31, 122);
            this.chkInserirCliente.Name = "chkInserirCliente";
            this.chkInserirCliente.Size = new System.Drawing.Size(54, 17);
            this.chkInserirCliente.TabIndex = 2;
            this.chkInserirCliente.Text = "Inserir";
            this.chkInserirCliente.UseVisualStyleBackColor = true;
            // 
            // chkAlterarCliente
            // 
            this.chkAlterarCliente.AutoSize = true;
            this.chkAlterarCliente.Enabled = false;
            this.chkAlterarCliente.Location = new System.Drawing.Point(31, 168);
            this.chkAlterarCliente.Name = "chkAlterarCliente";
            this.chkAlterarCliente.Size = new System.Drawing.Size(56, 17);
            this.chkAlterarCliente.TabIndex = 2;
            this.chkAlterarCliente.Text = "Alterar";
            this.chkAlterarCliente.UseVisualStyleBackColor = true;
            // 
            // chkPesquisaCliente
            // 
            this.chkPesquisaCliente.AutoSize = true;
            this.chkPesquisaCliente.Enabled = false;
            this.chkPesquisaCliente.Location = new System.Drawing.Point(31, 145);
            this.chkPesquisaCliente.Name = "chkPesquisaCliente";
            this.chkPesquisaCliente.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisaCliente.TabIndex = 2;
            this.chkPesquisaCliente.Text = "Pesquisar";
            this.chkPesquisaCliente.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(-3, 198);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 5);
            this.panel3.TabIndex = 3;
            // 
            // chkProduto
            // 
            this.chkProduto.AutoSize = true;
            this.chkProduto.Enabled = false;
            this.chkProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkProduto.Location = new System.Drawing.Point(12, 222);
            this.chkProduto.Name = "chkProduto";
            this.chkProduto.Size = new System.Drawing.Size(143, 19);
            this.chkProduto.TabIndex = 1;
            this.chkProduto.Text = "Cadastro de produtos";
            this.chkProduto.UseVisualStyleBackColor = true;
            this.chkProduto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkProduto_MouseClick);
            // 
            // chkInserirProd
            // 
            this.chkInserirProd.AutoSize = true;
            this.chkInserirProd.Enabled = false;
            this.chkInserirProd.Location = new System.Drawing.Point(31, 249);
            this.chkInserirProd.Name = "chkInserirProd";
            this.chkInserirProd.Size = new System.Drawing.Size(54, 17);
            this.chkInserirProd.TabIndex = 2;
            this.chkInserirProd.Text = "Inserir";
            this.chkInserirProd.UseVisualStyleBackColor = true;
            // 
            // chkAlterarProd
            // 
            this.chkAlterarProd.AutoSize = true;
            this.chkAlterarProd.Enabled = false;
            this.chkAlterarProd.Location = new System.Drawing.Point(31, 295);
            this.chkAlterarProd.Name = "chkAlterarProd";
            this.chkAlterarProd.Size = new System.Drawing.Size(56, 17);
            this.chkAlterarProd.TabIndex = 2;
            this.chkAlterarProd.Text = "Alterar";
            this.chkAlterarProd.UseVisualStyleBackColor = true;
            // 
            // chkPesquisarProd
            // 
            this.chkPesquisarProd.AutoSize = true;
            this.chkPesquisarProd.Enabled = false;
            this.chkPesquisarProd.Location = new System.Drawing.Point(31, 272);
            this.chkPesquisarProd.Name = "chkPesquisarProd";
            this.chkPesquisarProd.Size = new System.Drawing.Size(72, 17);
            this.chkPesquisarProd.TabIndex = 2;
            this.chkPesquisarProd.Text = "Pesquisar";
            this.chkPesquisarProd.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(-3, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(345, 5);
            this.panel4.TabIndex = 4;
            // 
            // chkUsuario
            // 
            this.chkUsuario.AutoSize = true;
            this.chkUsuario.Enabled = false;
            this.chkUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUsuario.Location = new System.Drawing.Point(12, 349);
            this.chkUsuario.Name = "chkUsuario";
            this.chkUsuario.Size = new System.Drawing.Size(142, 19);
            this.chkUsuario.TabIndex = 1;
            this.chkUsuario.Text = "Cadastro de usuários";
            this.chkUsuario.UseVisualStyleBackColor = true;
            this.chkUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkUsuario_MouseClick);
            // 
            // chkInserirUser
            // 
            this.chkInserirUser.AutoSize = true;
            this.chkInserirUser.Enabled = false;
            this.chkInserirUser.Location = new System.Drawing.Point(31, 376);
            this.chkInserirUser.Name = "chkInserirUser";
            this.chkInserirUser.Size = new System.Drawing.Size(54, 17);
            this.chkInserirUser.TabIndex = 2;
            this.chkInserirUser.Text = "Inserir";
            this.chkInserirUser.UseVisualStyleBackColor = true;
            // 
            // chkAlterarUser
            // 
            this.chkAlterarUser.AutoSize = true;
            this.chkAlterarUser.Enabled = false;
            this.chkAlterarUser.Location = new System.Drawing.Point(31, 422);
            this.chkAlterarUser.Name = "chkAlterarUser";
            this.chkAlterarUser.Size = new System.Drawing.Size(56, 17);
            this.chkAlterarUser.TabIndex = 2;
            this.chkAlterarUser.Text = "Alterar";
            this.chkAlterarUser.UseVisualStyleBackColor = true;
            // 
            // chkVisualizar
            // 
            this.chkVisualizar.AutoSize = true;
            this.chkVisualizar.Enabled = false;
            this.chkVisualizar.Location = new System.Drawing.Point(31, 399);
            this.chkVisualizar.Name = "chkVisualizar";
            this.chkVisualizar.Size = new System.Drawing.Size(70, 17);
            this.chkVisualizar.TabIndex = 2;
            this.chkVisualizar.Text = "Visualizar";
            this.chkVisualizar.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(167, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 380);
            this.panel5.TabIndex = 5;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 86;
            this.iconPictureBox2.Location = new System.Drawing.Point(218, 353);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(86, 86);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 86;
            this.iconPictureBox1.Location = new System.Drawing.Point(218, 224);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(86, 86);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // pbClientes
            // 
            this.pbClientes.BackColor = System.Drawing.SystemColors.Control;
            this.pbClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbClientes.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.pbClientes.IconColor = System.Drawing.SystemColors.ControlText;
            this.pbClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pbClientes.IconSize = 86;
            this.pbClientes.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbClientes.InitialImage")));
            this.pbClientes.Location = new System.Drawing.Point(218, 102);
            this.pbClientes.Name = "pbClientes";
            this.pbClientes.Size = new System.Drawing.Size(86, 86);
            this.pbClientes.TabIndex = 6;
            this.pbClientes.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(-1, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(345, 5);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Location = new System.Drawing.Point(-3, 74);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(347, 5);
            this.panel7.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(132, 480);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 515);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.pbClientes);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chkVisualizar);
            this.Controls.Add(this.chkPesquisarProd);
            this.Controls.Add(this.chkAlterarUser);
            this.Controls.Add(this.chkAlterarProd);
            this.Controls.Add(this.chkPesquisaCliente);
            this.Controls.Add(this.chkInserirUser);
            this.Controls.Add(this.chkInserirProd);
            this.Controls.Add(this.chkAlterarCliente);
            this.Controls.Add(this.chkInserirCliente);
            this.Controls.Add(this.chkUsuario);
            this.Controls.Add(this.chkProduto);
            this.Controls.Add(this.chkCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnIncluirUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSelec;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.CheckBox chkInserirCliente;
        private System.Windows.Forms.CheckBox chkAlterarCliente;
        private System.Windows.Forms.CheckBox chkPesquisaCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkProduto;
        private System.Windows.Forms.CheckBox chkInserirProd;
        private System.Windows.Forms.CheckBox chkAlterarProd;
        private System.Windows.Forms.CheckBox chkPesquisarProd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkUsuario;
        private System.Windows.Forms.CheckBox chkInserirUser;
        private System.Windows.Forms.CheckBox chkAlterarUser;
        private System.Windows.Forms.CheckBox chkVisualizar;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconPictureBox pbClientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSalvar;
    }
}