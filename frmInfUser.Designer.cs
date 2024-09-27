namespace CadastroCliente
{
    partial class frmInfUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInfUser));
            this.lbNome = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSenha = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbConfirmSenha = new MaterialSkin.Controls.MaterialLabel();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Depth = 0;
            this.lbNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbNome.Location = new System.Drawing.Point(8, 21);
            this.lbNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(54, 19);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.ForeColor = System.Drawing.Color.Gray;
            this.txtNome.Location = new System.Drawing.Point(12, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 13);
            this.txtNome.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 1);
            this.panel1.TabIndex = 2;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Depth = 0;
            this.lbSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSenha.Location = new System.Drawing.Point(8, 86);
            this.lbSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(54, 19);
            this.lbSenha.TabIndex = 0;
            this.lbSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtSenha.Location = new System.Drawing.Point(12, 112);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '●';
            this.txtSenha.Size = new System.Drawing.Size(147, 13);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(12, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 1);
            this.panel2.TabIndex = 3;
            // 
            // lbConfirmSenha
            // 
            this.lbConfirmSenha.AutoSize = true;
            this.lbConfirmSenha.Depth = 0;
            this.lbConfirmSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbConfirmSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbConfirmSenha.Location = new System.Drawing.Point(8, 148);
            this.lbConfirmSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbConfirmSenha.Name = "lbConfirmSenha";
            this.lbConfirmSenha.Size = new System.Drawing.Size(125, 19);
            this.lbConfirmSenha.TabIndex = 0;
            this.lbConfirmSenha.Text = "Confirmar Senha:";
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.BackColor = System.Drawing.SystemColors.Menu;
            this.txtConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmSenha.ForeColor = System.Drawing.Color.Gray;
            this.txtConfirmSenha.Location = new System.Drawing.Point(12, 172);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '●';
            this.txtConfirmSenha.Size = new System.Drawing.Size(147, 13);
            this.txtConfirmSenha.TabIndex = 2;
            this.txtConfirmSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmSenha_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(13, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(149, 1);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(11, 188);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(149, 1);
            this.panel4.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.BackColor = System.Drawing.Color.LightGray;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.Location = new System.Drawing.Point(50, 202);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(63, 36);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "INCLUIR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmInfUser
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 246);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtConfirmSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbConfirmSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInfUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lbConfirmSenha;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
    }
}