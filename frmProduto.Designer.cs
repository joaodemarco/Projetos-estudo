namespace CadastroCliente
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPesquisarProd = new FontAwesome.Sharp.IconButton();
            this.btnSalvarProd = new FontAwesome.Sharp.IconButton();
            this.btnIncluirProd = new FontAwesome.Sharp.IconButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtCodBarras = new System.Windows.Forms.TextBox();
            this.lbCodBarras = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbCFOP = new System.Windows.Forms.Label();
            this.lbForn = new System.Windows.Forms.Label();
            this.txtForn = new System.Windows.Forms.TextBox();
            this.lbMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lbUN = new System.Windows.Forms.Label();
            this.lbCompra = new System.Windows.Forms.Label();
            this.lbVenda = new System.Windows.Forms.Label();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.lbDepart = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.cbUN = new System.Windows.Forms.ComboBox();
            this.msktxtCFOP = new System.Windows.Forms.MaskedTextBox();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPesquisarProd);
            this.panel1.Controls.Add(this.btnSalvarProd);
            this.panel1.Controls.Add(this.btnIncluirProd);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 92);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(301, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 92);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(184, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 92);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(89, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 92);
            this.panel2.TabIndex = 4;
            // 
            // btnPesquisarProd
            // 
            this.btnPesquisarProd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPesquisarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarProd.FlatAppearance.BorderSize = 0;
            this.btnPesquisarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProd.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnPesquisarProd.IconColor = System.Drawing.Color.Black;
            this.btnPesquisarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisarProd.IconSize = 30;
            this.btnPesquisarProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarProd.Location = new System.Drawing.Point(204, 14);
            this.btnPesquisarProd.Name = "btnPesquisarProd";
            this.btnPesquisarProd.Size = new System.Drawing.Size(82, 63);
            this.btnPesquisarProd.TabIndex = 3;
            this.btnPesquisarProd.Text = "Pesquisar";
            this.btnPesquisarProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisarProd.UseVisualStyleBackColor = false;
            this.btnPesquisarProd.Click += new System.EventHandler(this.btnPesquisarProd_Click);
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalvarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarProd.FlatAppearance.BorderSize = 0;
            this.btnSalvarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarProd.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSalvarProd.IconColor = System.Drawing.Color.Black;
            this.btnSalvarProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalvarProd.IconSize = 30;
            this.btnSalvarProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarProd.Location = new System.Drawing.Point(107, 13);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(63, 63);
            this.btnSalvarProd.TabIndex = 2;
            this.btnSalvarProd.Text = "Salvar";
            this.btnSalvarProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalvarProd.UseVisualStyleBackColor = false;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // btnIncluirProd
            // 
            this.btnIncluirProd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnIncluirProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirProd.FlatAppearance.BorderSize = 0;
            this.btnIncluirProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirProd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnIncluirProd.IconColor = System.Drawing.Color.Black;
            this.btnIncluirProd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIncluirProd.IconSize = 30;
            this.btnIncluirProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluirProd.Location = new System.Drawing.Point(14, 13);
            this.btnIncluirProd.Name = "btnIncluirProd";
            this.btnIncluirProd.Size = new System.Drawing.Size(63, 63);
            this.btnIncluirProd.TabIndex = 1;
            this.btnIncluirProd.Text = "Incluir";
            this.btnIncluirProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluirProd.UseVisualStyleBackColor = false;
            this.btnIncluirProd.Click += new System.EventHandler(this.btnIncluirProd_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(12, 120);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(63, 23);
            this.txtID.TabIndex = 4;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(7, 98);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 20);
            this.lbID.TabIndex = 9;
            this.lbID.Text = "ID:";
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Enabled = false;
            this.txtCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodBarras.Location = new System.Drawing.Point(86, 120);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Size = new System.Drawing.Size(111, 23);
            this.txtCodBarras.TabIndex = 5;
            this.txtCodBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodBarras_KeyPress);
            // 
            // lbCodBarras
            // 
            this.lbCodBarras.AutoSize = true;
            this.lbCodBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodBarras.Location = new System.Drawing.Point(82, 98);
            this.lbCodBarras.Name = "lbCodBarras";
            this.lbCodBarras.Size = new System.Drawing.Size(97, 20);
            this.lbCodBarras.TabIndex = 9;
            this.lbCodBarras.Text = "Cód. Barras:";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(208, 120);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(506, 23);
            this.txtDesc.TabIndex = 6;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(204, 98);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(84, 20);
            this.lbDesc.TabIndex = 9;
            this.lbDesc.Text = "Descrição:";
            // 
            // lbCFOP
            // 
            this.lbCFOP.AutoSize = true;
            this.lbCFOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCFOP.Location = new System.Drawing.Point(721, 98);
            this.lbCFOP.Name = "lbCFOP";
            this.lbCFOP.Size = new System.Drawing.Size(56, 20);
            this.lbCFOP.TabIndex = 9;
            this.lbCFOP.Text = "CFOP:";
            // 
            // lbForn
            // 
            this.lbForn.AutoSize = true;
            this.lbForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForn.Location = new System.Drawing.Point(7, 158);
            this.lbForn.Name = "lbForn";
            this.lbForn.Size = new System.Drawing.Size(95, 20);
            this.lbForn.TabIndex = 9;
            this.lbForn.Text = "Fornecedor:";
            // 
            // txtForn
            // 
            this.txtForn.Enabled = false;
            this.txtForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForn.Location = new System.Drawing.Point(12, 181);
            this.txtForn.Name = "txtForn";
            this.txtForn.Size = new System.Drawing.Size(541, 23);
            this.txtForn.TabIndex = 8;
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            this.lbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(560, 158);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(57, 20);
            this.lbMarca.TabIndex = 9;
            this.lbMarca.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(564, 181);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(163, 23);
            this.txtMarca.TabIndex = 9;
            // 
            // lbUN
            // 
            this.lbUN.AutoSize = true;
            this.lbUN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUN.Location = new System.Drawing.Point(729, 158);
            this.lbUN.Name = "lbUN";
            this.lbUN.Size = new System.Drawing.Size(36, 20);
            this.lbUN.TabIndex = 9;
            this.lbUN.Text = "UN:";
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompra.Location = new System.Drawing.Point(7, 222);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(92, 20);
            this.lbCompra.TabIndex = 9;
            this.lbCompra.Text = "Pr. Compra:";
            // 
            // lbVenda
            // 
            this.lbVenda.AutoSize = true;
            this.lbVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVenda.Location = new System.Drawing.Point(105, 222);
            this.lbVenda.Name = "lbVenda";
            this.lbVenda.Size = new System.Drawing.Size(83, 20);
            this.lbVenda.TabIndex = 9;
            this.lbVenda.Text = "Pr. Venda:";
            // 
            // txtVenda
            // 
            this.txtVenda.Enabled = false;
            this.txtVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenda.Location = new System.Drawing.Point(109, 245);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(88, 23);
            this.txtVenda.TabIndex = 12;
            this.txtVenda.TextChanged += new System.EventHandler(this.txtVenda_TextChanged);
            this.txtVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVenda_KeyPress);
            // 
            // txtDepart
            // 
            this.txtDepart.Enabled = false;
            this.txtDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepart.Location = new System.Drawing.Point(208, 245);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(345, 23);
            this.txtDepart.TabIndex = 13;
            // 
            // lbDepart
            // 
            this.lbDepart.AutoSize = true;
            this.lbDepart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepart.Location = new System.Drawing.Point(205, 222);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(116, 20);
            this.lbDepart.TabIndex = 9;
            this.lbDepart.Text = "Departamento:";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(564, 245);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(224, 23);
            this.txtComplemento.TabIndex = 14;
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplemento.Location = new System.Drawing.Point(560, 222);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(112, 20);
            this.lbComplemento.TabIndex = 9;
            this.lbComplemento.Text = "Complemento:";
            // 
            // cbUN
            // 
            this.cbUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUN.Enabled = false;
            this.cbUN.FormattingEnabled = true;
            this.cbUN.Items.AddRange(new object[] {
            "PC",
            "CX",
            "KG",
            "CP",
            "LT",
            "UN",
            "ML",
            "MT",
            "JG",
            "FD",
            "SC",
            "BD",
            "TD",
            "OC",
            "PAR",
            "KIT",
            "PT",
            "GL",
            "PR",
            "MI"});
            this.cbUN.Location = new System.Drawing.Point(733, 183);
            this.cbUN.Name = "cbUN";
            this.cbUN.Size = new System.Drawing.Size(57, 21);
            this.cbUN.TabIndex = 15;
            // 
            // msktxtCFOP
            // 
            this.msktxtCFOP.Culture = new System.Globalization.CultureInfo("es-US");
            this.msktxtCFOP.Enabled = false;
            this.msktxtCFOP.Location = new System.Drawing.Point(725, 121);
            this.msktxtCFOP.Mask = "0.000";
            this.msktxtCFOP.Name = "msktxtCFOP";
            this.msktxtCFOP.Size = new System.Drawing.Size(65, 20);
            this.msktxtCFOP.TabIndex = 16;
            // 
            // txtCompra
            // 
            this.txtCompra.Enabled = false;
            this.txtCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompra.Location = new System.Drawing.Point(11, 245);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(88, 23);
            this.txtCompra.TabIndex = 11;
            this.txtCompra.TextChanged += new System.EventHandler(this.txtCompra_TextChanged);
            this.txtCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompra_KeyPress);
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.msktxtCFOP);
            this.Controls.Add(this.cbUN);
            this.Controls.Add(this.lbCFOP);
            this.Controls.Add(this.lbUN);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbComplemento);
            this.Controls.Add(this.lbDepart);
            this.Controls.Add(this.lbVenda);
            this.Controls.Add(this.lbCompra);
            this.Controls.Add(this.lbForn);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.lbCodBarras);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtForn);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodBarras);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnIncluirProd;
        private FontAwesome.Sharp.IconButton btnSalvarProd;
        private FontAwesome.Sharp.IconButton btnPesquisarProd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtCodBarras;
        private System.Windows.Forms.Label lbCodBarras;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbCFOP;
        private System.Windows.Forms.Label lbForn;
        private System.Windows.Forms.TextBox txtForn;
        private System.Windows.Forms.Label lbMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lbUN;
        private System.Windows.Forms.Label lbCompra;
        private System.Windows.Forms.Label lbVenda;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.Label lbDepart;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.ComboBox cbUN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MaskedTextBox msktxtCFOP;
        private System.Windows.Forms.TextBox txtCompra;
    }
}