namespace CadastroCliente
{
    partial class frmPesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoPesquisaProduto = new FontAwesome.Sharp.IconButton();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.botaoPesquisaProduto);
            this.panel1.Controls.Add(this.txtPesquisa);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 67);
            this.panel1.TabIndex = 0;
            // 
            // botaoPesquisaProduto
            // 
            this.botaoPesquisaProduto.BackColor = System.Drawing.Color.Gainsboro;
            this.botaoPesquisaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisaProduto.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.botaoPesquisaProduto.FlatAppearance.BorderSize = 0;
            this.botaoPesquisaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisaProduto.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.botaoPesquisaProduto.IconColor = System.Drawing.Color.Black;
            this.botaoPesquisaProduto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botaoPesquisaProduto.IconSize = 22;
            this.botaoPesquisaProduto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPesquisaProduto.Location = new System.Drawing.Point(568, 23);
            this.botaoPesquisaProduto.Name = "botaoPesquisaProduto";
            this.botaoPesquisaProduto.Size = new System.Drawing.Size(36, 33);
            this.botaoPesquisaProduto.TabIndex = 3;
            this.botaoPesquisaProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botaoPesquisaProduto.UseVisualStyleBackColor = false;
            this.botaoPesquisaProduto.Click += new System.EventHandler(this.botaoPesquisaProduto_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(143, 30);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(418, 20);
            this.txtPesquisa.TabIndex = 2;
            // 
            // cbTipo
            // 
            this.cbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Id",
            "Cód. Barras",
            "Descrição",
            "Fornecedor",
            "Marca",
            "Departamento"});
            this.cbTipo.BackColor = System.Drawing.Color.Gainsboro;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Id",
            "Cód. Barras",
            "Descrição",
            "Fornecedor",
            "Marca",
            "Departamento"});
            this.cbTipo.Location = new System.Drawing.Point(16, 29);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Location = new System.Drawing.Point(-6, 330);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(634, 182);
            this.panel6.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(608, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 277);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(-23, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 277);
            this.panel3.TabIndex = 6;
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.BackgroundColor = System.Drawing.Color.White;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodBarras,
            this.Descricao,
            this.Fornecedor,
            this.Marca,
            this.Departamento,
            this.PrCompra,
            this.ValorVenda});
            this.dataGridProduto.Location = new System.Drawing.Point(12, 62);
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.Size = new System.Drawing.Size(597, 270);
            this.dataGridProduto.TabIndex = 4;
            this.dataGridProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduto_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // CodBarras
            // 
            this.CodBarras.DataPropertyName = "CodBarras";
            this.CodBarras.HeaderText = "Cód. Barras";
            this.CodBarras.Name = "CodBarras";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Descricao";
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            // 
            // Fornecedor
            // 
            this.Fornecedor.DataPropertyName = "Fornecedor";
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "Marca";
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Departamento
            // 
            this.Departamento.DataPropertyName = "Departamento";
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // PrCompra
            // 
            this.PrCompra.DataPropertyName = "PrCompra";
            this.PrCompra.HeaderText = "Pr. Compra";
            this.PrCompra.Name = "PrCompra";
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "PrVenda";
            this.ValorVenda.HeaderText = "Pr. Venda";
            this.ValorVenda.Name = "ValorVenda";
            // 
            // frmPesquisaProduto
            // 
            this.AcceptButton = this.botaoPesquisaProduto;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 344);
            this.Controls.Add(this.dataGridProduto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.frmPesquisaProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.TextBox txtPesquisa;
        private FontAwesome.Sharp.IconButton botaoPesquisaProduto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
    }
}