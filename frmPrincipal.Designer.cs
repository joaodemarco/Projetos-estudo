namespace CadastroCliente
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new FontAwesome.Sharp.IconButton();
            this.btnVendas = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadUsuario = new FontAwesome.Sharp.IconButton();
            this.btnCadProduto = new FontAwesome.Sharp.IconButton();
            this.btnCadCliente = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnVendas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCadUsuario);
            this.panel1.Controls.Add(this.btnCadProduto);
            this.panel1.Controls.Add(this.btnCadCliente);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 111);
            this.panel1.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Silver;
            this.panel10.Location = new System.Drawing.Point(542, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 111);
            this.panel10.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Silver;
            this.panel9.Location = new System.Drawing.Point(435, 1);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 111);
            this.panel9.TabIndex = 14;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.IconChar = FontAwesome.Sharp.IconChar.SheetPlastic;
            this.btnRelatorio.IconColor = System.Drawing.Color.Black;
            this.btnRelatorio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorio.IconSize = 50;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRelatorio.Location = new System.Drawing.Point(446, 19);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(92, 71);
            this.btnRelatorio.TabIndex = 13;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnVendas.IconColor = System.Drawing.Color.Black;
            this.btnVendas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVendas.IconSize = 70;
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.Location = new System.Drawing.Point(339, 19);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(92, 71);
            this.btnVendas.TabIndex = 13;
            this.btnVendas.Text = "Vendas";
            this.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(110, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 111);
            this.panel2.TabIndex = 1;
            // 
            // btnCadUsuario
            // 
            this.btnCadUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCadUsuario.FlatAppearance.BorderSize = 0;
            this.btnCadUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadUsuario.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnCadUsuario.IconColor = System.Drawing.Color.Black;
            this.btnCadUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadUsuario.IconSize = 50;
            this.btnCadUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadUsuario.Location = new System.Drawing.Point(230, 19);
            this.btnCadUsuario.Name = "btnCadUsuario";
            this.btnCadUsuario.Size = new System.Drawing.Size(92, 71);
            this.btnCadUsuario.TabIndex = 1;
            this.btnCadUsuario.Text = "Usuários";
            this.btnCadUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadUsuario.UseVisualStyleBackColor = false;
            this.btnCadUsuario.Click += new System.EventHandler(this.btnCadUsuario_Click);
            // 
            // btnCadProduto
            // 
            this.btnCadProduto.BackColor = System.Drawing.Color.Transparent;
            this.btnCadProduto.FlatAppearance.BorderSize = 0;
            this.btnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProduto.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProduto.IconChar = FontAwesome.Sharp.IconChar.CartShopping;
            this.btnCadProduto.IconColor = System.Drawing.Color.Black;
            this.btnCadProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadProduto.IconSize = 50;
            this.btnCadProduto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadProduto.Location = new System.Drawing.Point(121, 19);
            this.btnCadProduto.Name = "btnCadProduto";
            this.btnCadProduto.Size = new System.Drawing.Size(92, 71);
            this.btnCadProduto.TabIndex = 1;
            this.btnCadProduto.Text = "Produtos";
            this.btnCadProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadProduto.UseVisualStyleBackColor = false;
            this.btnCadProduto.Click += new System.EventHandler(this.btnCadProduto_Click);
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadCliente.FlatAppearance.BorderSize = 0;
            this.btnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadCliente.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCliente.IconChar = FontAwesome.Sharp.IconChar.Handshake;
            this.btnCadCliente.IconColor = System.Drawing.Color.Black;
            this.btnCadCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadCliente.IconSize = 50;
            this.btnCadCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadCliente.Location = new System.Drawing.Point(10, 19);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(92, 71);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Clientes";
            this.btnCadCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadCliente.UseVisualStyleBackColor = false;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 111);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(328, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 111);
            this.panel4.TabIndex = 3;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lbUsuario.Location = new System.Drawing.Point(27, 554);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(97, 21);
            this.lbUsuario.TabIndex = 6;
            this.lbUsuario.Text = "Bem vindo,";
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Font = new System.Drawing.Font("Nexa Heavy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeUsuario.Location = new System.Drawing.Point(123, 554);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(54, 21);
            this.lbNomeUsuario.TabIndex = 7;
            this.lbNomeUsuario.Text = "label1";
            // 
            // Calendario
            // 
            this.Calendario.BackColor = System.Drawing.Color.White;
            this.Calendario.Font = new System.Drawing.Font("Nexa Heavy", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendario.Location = new System.Drawing.Point(862, 413);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel5.Location = new System.Drawing.Point(858, 409);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 170);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel6.Location = new System.Drawing.Point(1088, 409);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 170);
            this.panel6.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel7.Location = new System.Drawing.Point(862, 409);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 5);
            this.panel7.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel8.Location = new System.Drawing.Point(863, 574);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(226, 5);
            this.panel8.TabIndex = 12;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 603);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCadCliente;
        private FontAwesome.Sharp.IconButton btnCadProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnCadUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private FontAwesome.Sharp.IconButton btnVendas;
        private FontAwesome.Sharp.IconButton btnRelatorio;
        private System.Windows.Forms.Panel panel10;
    }
}

