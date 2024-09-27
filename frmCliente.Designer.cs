namespace CadastroCliente
{
    partial class frmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.botaoIncluir = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botaoPesquisarCliente = new FontAwesome.Sharp.IconButton();
            this.botaoSalvar = new FontAwesome.Sharp.IconButton();
            this.lbFantasia = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.cbLogradouro = new System.Windows.Forms.ComboBox();
            this.lbLogradouro = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txtNumeroEnd = new System.Windows.Forms.TextBox();
            this.lbNumeroEnd = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbCelular = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.lbCEP = new System.Windows.Forms.Label();
            this.btnBuscaCEP = new System.Windows.Forms.Button();
            this.msktxtCEP = new System.Windows.Forms.MaskedTextBox();
            this.msktxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.msktxtCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.msktxtCelular = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoIncluir
            // 
            this.botaoIncluir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botaoIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoIncluir.FlatAppearance.BorderSize = 0;
            this.botaoIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoIncluir.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.botaoIncluir.IconColor = System.Drawing.Color.Black;
            this.botaoIncluir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botaoIncluir.IconSize = 30;
            this.botaoIncluir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoIncluir.Location = new System.Drawing.Point(12, 12);
            this.botaoIncluir.Name = "botaoIncluir";
            this.botaoIncluir.Size = new System.Drawing.Size(63, 63);
            this.botaoIncluir.TabIndex = 1;
            this.botaoIncluir.Text = "Incluir";
            this.botaoIncluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botaoIncluir.UseVisualStyleBackColor = false;
            this.botaoIncluir.Click += new System.EventHandler(this.botaoIncluir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.botaoPesquisarCliente);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Location = new System.Drawing.Point(-17, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 90);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(311, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 90);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(195, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 90);
            this.panel3.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(102, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 90);
            this.panel2.TabIndex = 4;
            // 
            // botaoPesquisarCliente
            // 
            this.botaoPesquisarCliente.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botaoPesquisarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.botaoPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisarCliente.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.botaoPesquisarCliente.IconColor = System.Drawing.Color.Black;
            this.botaoPesquisarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botaoPesquisarCliente.IconSize = 30;
            this.botaoPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoPesquisarCliente.Location = new System.Drawing.Point(214, 14);
            this.botaoPesquisarCliente.Name = "botaoPesquisarCliente";
            this.botaoPesquisarCliente.Size = new System.Drawing.Size(82, 64);
            this.botaoPesquisarCliente.TabIndex = 3;
            this.botaoPesquisarCliente.Text = "Pesquisar";
            this.botaoPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botaoPesquisarCliente.UseVisualStyleBackColor = false;
            this.botaoPesquisarCliente.Click += new System.EventHandler(this.botaoPesquisarCliente_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.FlatAppearance.BorderSize = 0;
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSalvar.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.botaoSalvar.IconColor = System.Drawing.Color.Black;
            this.botaoSalvar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botaoSalvar.IconSize = 30;
            this.botaoSalvar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.botaoSalvar.Location = new System.Drawing.Point(119, 14);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(63, 63);
            this.botaoSalvar.TabIndex = 2;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // lbFantasia
            // 
            this.lbFantasia.AutoSize = true;
            this.lbFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFantasia.Location = new System.Drawing.Point(437, 100);
            this.lbFantasia.Name = "lbFantasia";
            this.lbFantasia.Size = new System.Drawing.Size(75, 20);
            this.lbFantasia.TabIndex = 4;
            this.lbFantasia.Text = "Fantasia:";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Enabled = false;
            this.txtFantasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasia.Location = new System.Drawing.Point(441, 123);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(347, 23);
            this.txtFantasia.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(48, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(382, 23);
            this.txtNome.TabIndex = 5;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(44, 100);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(12, 123);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(25, 23);
            this.txtID.TabIndex = 4;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(8, 100);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(30, 20);
            this.lbID.TabIndex = 6;
            this.lbID.Text = "ID:";
            // 
            // cbLogradouro
            // 
            this.cbLogradouro.BackColor = System.Drawing.SystemColors.Window;
            this.cbLogradouro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLogradouro.Enabled = false;
            this.cbLogradouro.FormattingEnabled = true;
            this.cbLogradouro.Items.AddRange(new object[] {
            "Rua",
            "Rodovia",
            "Sítio",
            "Fazenda",
            "Estação",
            "Avenida",
            "Alameda",
            "Condomínio"});
            this.cbLogradouro.Location = new System.Drawing.Point(113, 181);
            this.cbLogradouro.Name = "cbLogradouro";
            this.cbLogradouro.Size = new System.Drawing.Size(91, 21);
            this.cbLogradouro.TabIndex = 9;
            // 
            // lbLogradouro
            // 
            this.lbLogradouro.AutoSize = true;
            this.lbLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogradouro.Location = new System.Drawing.Point(109, 157);
            this.lbLogradouro.Name = "lbLogradouro";
            this.lbLogradouro.Size = new System.Drawing.Size(95, 20);
            this.lbLogradouro.TabIndex = 9;
            this.lbLogradouro.Text = "Logradouro:";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.Location = new System.Drawing.Point(210, 157);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(82, 20);
            this.lbEndereco.TabIndex = 10;
            this.lbEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(214, 178);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(417, 23);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(641, 178);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(147, 23);
            this.txtBairro.TabIndex = 11;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(637, 157);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(55, 20);
            this.lbBairro.TabIndex = 12;
            this.lbBairro.Text = "Bairro:";
            // 
            // txtNumeroEnd
            // 
            this.txtNumeroEnd.Enabled = false;
            this.txtNumeroEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEnd.Location = new System.Drawing.Point(11, 235);
            this.txtNumeroEnd.Name = "txtNumeroEnd";
            this.txtNumeroEnd.Size = new System.Drawing.Size(62, 23);
            this.txtNumeroEnd.TabIndex = 12;
            this.txtNumeroEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroEnd_KeyPress);
            // 
            // lbNumeroEnd
            // 
            this.lbNumeroEnd.AutoSize = true;
            this.lbNumeroEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroEnd.Location = new System.Drawing.Point(7, 214);
            this.lbNumeroEnd.Name = "lbNumeroEnd";
            this.lbNumeroEnd.Size = new System.Drawing.Size(30, 20);
            this.lbNumeroEnd.TabIndex = 14;
            this.lbNumeroEnd.Text = "Nº:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(78, 213);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(271, 235);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(250, 23);
            this.txtCidade.TabIndex = 14;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCidade.Location = new System.Drawing.Point(267, 214);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(63, 20);
            this.lbCidade.TabIndex = 18;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(530, 214);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(43, 20);
            this.lbTipo.TabIndex = 21;
            this.lbTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.SystemColors.Window;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Enabled = false;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbTipo.Location = new System.Drawing.Point(534, 237);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(97, 21);
            this.cbTipo.TabIndex = 15;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.Location = new System.Drawing.Point(637, 212);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(44, 20);
            this.lbCPF.TabIndex = 22;
            this.lbCPF.Text = "CPF:";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNPJ.Location = new System.Drawing.Point(8, 271);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(53, 20);
            this.lbCNPJ.TabIndex = 22;
            this.lbCNPJ.Text = "CNPJ:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.Location = new System.Drawing.Point(269, 271);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(75, 20);
            this.lbTelefone.TabIndex = 22;
            this.lbTelefone.Text = "Telefone:";
            // 
            // lbCelular
            // 
            this.lbCelular.AutoSize = true;
            this.lbCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCelular.Location = new System.Drawing.Point(527, 271);
            this.lbCelular.Name = "lbCelular";
            this.lbCelular.Size = new System.Drawing.Size(62, 20);
            this.lbCelular.TabIndex = 22;
            this.lbCelular.Text = "Celular:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(8, 329);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(57, 20);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(12, 350);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 23);
            this.txtEmail.TabIndex = 20;
            // 
            // lbObservacao
            // 
            this.lbObservacao.AutoSize = true;
            this.lbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObservacao.Location = new System.Drawing.Point(271, 329);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(98, 20);
            this.lbObservacao.TabIndex = 22;
            this.lbObservacao.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.AcceptsTab = true;
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.Location = new System.Drawing.Point(275, 350);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(513, 23);
            this.txtObservacao.TabIndex = 21;
            // 
            // cbEstados
            // 
            this.cbEstados.BackColor = System.Drawing.SystemColors.Window;
            this.cbEstados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstados.Enabled = false;
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbEstados.Location = new System.Drawing.Point(82, 236);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(179, 21);
            this.cbEstados.TabIndex = 13;
            // 
            // lbCEP
            // 
            this.lbCEP.AutoSize = true;
            this.lbCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCEP.Location = new System.Drawing.Point(8, 158);
            this.lbCEP.Name = "lbCEP";
            this.lbCEP.Size = new System.Drawing.Size(45, 20);
            this.lbCEP.TabIndex = 9;
            this.lbCEP.Text = "CEP:";
            // 
            // btnBuscaCEP
            // 
            this.btnBuscaCEP.Enabled = false;
            this.btnBuscaCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaCEP.Location = new System.Drawing.Point(56, 160);
            this.btnBuscaCEP.Name = "btnBuscaCEP";
            this.btnBuscaCEP.Size = new System.Drawing.Size(39, 17);
            this.btnBuscaCEP.TabIndex = 8;
            this.btnBuscaCEP.Text = "Buscar";
            this.btnBuscaCEP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscaCEP.UseVisualStyleBackColor = true;
            this.btnBuscaCEP.Click += new System.EventHandler(this.btnBuscaCEP_Click);
            // 
            // msktxtCEP
            // 
            this.msktxtCEP.Enabled = false;
            this.msktxtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCEP.Location = new System.Drawing.Point(12, 179);
            this.msktxtCEP.Mask = "00000-000";
            this.msktxtCEP.Name = "msktxtCEP";
            this.msktxtCEP.Size = new System.Drawing.Size(91, 23);
            this.msktxtCEP.TabIndex = 7;
            // 
            // msktxtCPF
            // 
            this.msktxtCPF.Culture = new System.Globalization.CultureInfo("en-US");
            this.msktxtCPF.Enabled = false;
            this.msktxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCPF.Location = new System.Drawing.Point(641, 237);
            this.msktxtCPF.Mask = "000.000.000-00";
            this.msktxtCPF.Name = "msktxtCPF";
            this.msktxtCPF.Size = new System.Drawing.Size(147, 23);
            this.msktxtCPF.TabIndex = 16;
            // 
            // msktxtCNPJ
            // 
            this.msktxtCNPJ.Culture = new System.Globalization.CultureInfo("en-US");
            this.msktxtCNPJ.Enabled = false;
            this.msktxtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCNPJ.Location = new System.Drawing.Point(11, 292);
            this.msktxtCNPJ.Mask = "00.000.000/0000-00";
            this.msktxtCNPJ.Name = "msktxtCNPJ";
            this.msktxtCNPJ.Size = new System.Drawing.Size(250, 23);
            this.msktxtCNPJ.TabIndex = 17;
            // 
            // msktxtTelefone
            // 
            this.msktxtTelefone.Enabled = false;
            this.msktxtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtTelefone.Location = new System.Drawing.Point(273, 292);
            this.msktxtTelefone.Mask = "(00)0000-0000";
            this.msktxtTelefone.Name = "msktxtTelefone";
            this.msktxtTelefone.Size = new System.Drawing.Size(250, 23);
            this.msktxtTelefone.TabIndex = 18;
            // 
            // msktxtCelular
            // 
            this.msktxtCelular.Enabled = false;
            this.msktxtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msktxtCelular.Location = new System.Drawing.Point(534, 292);
            this.msktxtCelular.Mask = "(00)00000-0000";
            this.msktxtCelular.Name = "msktxtCelular";
            this.msktxtCelular.Size = new System.Drawing.Size(254, 23);
            this.msktxtCelular.TabIndex = 19;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.msktxtCelular);
            this.Controls.Add(this.msktxtTelefone);
            this.Controls.Add(this.msktxtCNPJ);
            this.Controls.Add(this.msktxtCPF);
            this.Controls.Add(this.msktxtCEP);
            this.Controls.Add(this.btnBuscaCEP);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.lbCelular);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbCNPJ);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtNumeroEnd);
            this.Controls.Add(this.lbNumeroEnd);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbCEP);
            this.Controls.Add(this.lbLogradouro);
            this.Controls.Add(this.cbLogradouro);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.lbFantasia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.botaoIncluir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton botaoIncluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbFantasia;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.ComboBox cbLogradouro;
        private System.Windows.Forms.Label lbLogradouro;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txtNumeroEnd;
        private System.Windows.Forms.Label lbNumeroEnd;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbCelular;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private FontAwesome.Sharp.IconButton botaoSalvar;
        private System.Windows.Forms.ComboBox cbEstados;
        private FontAwesome.Sharp.IconButton botaoPesquisarCliente;
        private System.Windows.Forms.Label lbCEP;
        private System.Windows.Forms.Button btnBuscaCEP;
        private System.Windows.Forms.MaskedTextBox msktxtCEP;
        private System.Windows.Forms.MaskedTextBox msktxtCPF;
        private System.Windows.Forms.MaskedTextBox msktxtCNPJ;
        private System.Windows.Forms.MaskedTextBox msktxtTelefone;
        private System.Windows.Forms.MaskedTextBox msktxtCelular;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}