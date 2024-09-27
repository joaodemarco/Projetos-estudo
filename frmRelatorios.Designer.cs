namespace CadastroCliente.Fontes
{
    partial class frmRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatorios));
            this.cbRelatorios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.mskDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRelatorios
            // 
            this.cbRelatorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelatorios.FormattingEnabled = true;
            this.cbRelatorios.Items.AddRange(new object[] {
            "Clientes",
            "Produtos",
            "Usuário",
            "Vendas"});
            this.cbRelatorios.Location = new System.Drawing.Point(12, 33);
            this.cbRelatorios.Name = "cbRelatorios";
            this.cbRelatorios.Size = new System.Drawing.Size(121, 21);
            this.cbRelatorios.TabIndex = 0;
            this.cbRelatorios.SelectedIndexChanged += new System.EventHandler(this.cbRelatorios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nexa Heavy", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Período:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(150, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 105);
            this.panel1.TabIndex = 2;
            // 
            // mskDataInicial
            // 
            this.mskDataInicial.BackColor = System.Drawing.SystemColors.Menu;
            this.mskDataInicial.Enabled = false;
            this.mskDataInicial.Location = new System.Drawing.Point(166, 34);
            this.mskDataInicial.Mask = "00/00/0000";
            this.mskDataInicial.Name = "mskDataInicial";
            this.mskDataInicial.Size = new System.Drawing.Size(64, 20);
            this.mskDataInicial.TabIndex = 3;
            this.mskDataInicial.ValidatingType = typeof(System.DateTime);
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Nexa Heavy", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(236, 40);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(14, 14);
            this.lbA.TabIndex = 4;
            this.lbA.Text = "à";
            // 
            // mskDataFinal
            // 
            this.mskDataFinal.BackColor = System.Drawing.SystemColors.Menu;
            this.mskDataFinal.Enabled = false;
            this.mskDataFinal.Location = new System.Drawing.Point(256, 34);
            this.mskDataFinal.Mask = "00/00/0000";
            this.mskDataFinal.Name = "mskDataFinal";
            this.mskDataFinal.Size = new System.Drawing.Size(64, 20);
            this.mskDataFinal.TabIndex = 3;
            this.mskDataFinal.ValidatingType = typeof(System.DateTime);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(330, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 103);
            this.panel2.TabIndex = 5;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnVisualizar.Enabled = false;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Location = new System.Drawing.Point(357, 32);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 6;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // frmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 91);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.mskDataFinal);
            this.Controls.Add(this.mskDataInicial);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbRelatorios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRelatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRelatorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskDataInicial;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.MaskedTextBox mskDataFinal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVisualizar;
    }
}