using CadastroCliente.Fontes.API;
using CadastroCliente.Fontes.DAL;
using CadastroCliente.Fontes.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmCliente : Form
    {
        public string nomeUser { get; set; }
        public frmCliente(string nomeLogin)
        {
            InitializeComponent();
            msktxtCEP.KeyDown += txtCEP_KeyDown;
            nomeUser = nomeLogin;
        }

        void HabilitarCampos()
        {
            btnBuscaCEP.Enabled = true;
            txtNome.Enabled = true;
            txtFantasia.Enabled = true;
            cbLogradouro.Enabled = true;
            msktxtCEP.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtNumeroEnd.Enabled = true;
            cbEstados.Enabled = true;
            txtCidade.Enabled = true;
            cbTipo.Enabled = true;
            msktxtCPF.Enabled = true;
            msktxtCNPJ.Enabled = true;
            msktxtTelefone.Enabled = true;
            msktxtCelular.Enabled = true;
            txtEmail.Enabled = true;
            txtObservacao.Enabled = true;
        }
        void DesabilitarCampos()
        {
            btnBuscaCEP.Enabled = false;
            txtNome.Enabled = false;
            txtFantasia.Enabled = false;
            cbLogradouro.Enabled = false;
            msktxtCEP.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtNumeroEnd.Enabled = false;
            cbEstados.Enabled = false;
            txtCidade.Enabled = false;
            cbTipo.Enabled = false;
            msktxtCPF.Enabled = false;
            msktxtCNPJ.Enabled = false;
            msktxtTelefone.Enabled = false;
            msktxtCelular.Enabled = false;
            txtEmail.Enabled = false;
            txtObservacao.Enabled = false;
        }
        void LimparCampos()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtFantasia.Text = "";
            cbLogradouro.SelectedIndex = -1;
            msktxtCEP.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtNumeroEnd.Text = "";
            cbEstados.SelectedIndex = -1;
            txtCidade.Text = "";
            cbTipo.SelectedIndex = -1;
            msktxtCPF.Text = "";
            msktxtCNPJ.Text = "";
            msktxtTelefone.Text = "";
            msktxtCelular.Text = "";
            txtEmail.Text = "";
            txtObservacao.Text = "";
        }
        public bool Validacao()
        {
            if (txtID.Enabled == false && txtNome.Enabled == false)
            {
                MessageBox.Show("Para fazer um cadastro, por favor clique no botão Incluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtNome.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cbLogradouro.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo logradouro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtEndereco.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo endereço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtNumeroEnd.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo do número do endereço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtBairro.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo bairro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cbEstados.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo estado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtCidade.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cbTipo.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, preencha o campo referente ao tipo da pessoa.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (msktxtCPF.Text.Length <= 0 && cbTipo.Text != "Jurídica")
            {
                MessageBox.Show("Por favor, preencha o campo CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (msktxtCNPJ.Text.Length <= 0 && cbTipo.Text != "Física")
            {
                MessageBox.Show("Por favor, preencha o campo CNPJ.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private void botaoIncluir_Click(object sender, EventArgs e)
        {
            var permissao = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissao.inserir_cliente == "S")
            {
                LimparCampos();
                HabilitarCampos();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para incluir novos clientes.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissoes.alterar_cliente == "S")
            {
                if (txtID.Text == "")
                {
                    if (!Validacao())
                    {
                        return;
                    }

                    dtoCliente cliente = new dtoCliente();
                    cliente.Nome = txtNome.Text;
                    cliente.Fantasia = txtFantasia.Text;
                    cliente.Logradouro = cbLogradouro.Text;
                    cliente.CEP = msktxtCEP.Text;
                    cliente.Endereco = txtEndereco.Text;
                    cliente.NumeroEndereco = Convert.ToInt32(txtNumeroEnd.Text);
                    cliente.Bairro = txtBairro.Text;
                    cliente.Estado = cbEstados.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Tipo = cbTipo.Text;
                    cliente.CPF = msktxtCPF.Text;
                    cliente.CNPJ = msktxtCNPJ.Text;
                    cliente.Telefone = msktxtTelefone.Text;
                    cliente.Celular = msktxtCelular.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Observacao = txtObservacao.Text;

                    dalCliente.InserirUsuario(cliente);
                    LimparCampos();
                    DesabilitarCampos();
                    MessageBox.Show("Cadastro salvo com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (txtID.Text != "")
                {
                    var dto = new dtoCliente();

                    dto.ID = int.Parse(txtID.Text);
                    dto.Nome = txtNome.Text;
                    dto.Fantasia = txtFantasia.Text;
                    dto.Logradouro = cbLogradouro.Text;
                    dto.CEP = msktxtCEP.Text;
                    dto.Endereco = txtEndereco.Text;
                    dto.NumeroEndereco = int.Parse(txtID.Text);
                    dto.Bairro = txtBairro.Text;
                    dto.Estado = cbEstados.Text;
                    dto.Cidade = txtCidade.Text;
                    dto.Tipo = cbTipo.Text;
                    dto.CPF = msktxtCPF.Text;
                    dto.CNPJ = msktxtCNPJ.Text;
                    dto.Telefone = msktxtTelefone.Text;
                    dto.Celular = msktxtCelular.Text;
                    dto.Email = txtEmail.Text;
                    dto.Observacao = txtObservacao.Text;

                    if (msktxtCNPJ.Text == "" && cbTipo.Text == "Jurídica")
                    {
                        MessageBox.Show("Por favor informe o CNPJ para a pessoa jurídica.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    bool sucesso = dalCliente.AlterarCadastro(dto);

                    if (sucesso)
                    {
                        MessageBox.Show("Cadastro salvo com sucesso.", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        LimparCampos();
                        DesabilitarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao salvar o cadastro.", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para alterar/salvar cadastros.", "Cadastro de Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtNumeroEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void botaoPesquisarCliente_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissoes.pesquisar_cliente == "S")
            {
                using (frmPesquisaCliente formPesqCli = new frmPesquisaCliente())
                {
                    if (formPesqCli.ShowDialog() == DialogResult.OK)
                    {
                        if (formPesqCli.cliente != null)
                        {
                            txtID.Text = formPesqCli.cliente.ID.ToString();
                            txtNome.Text = formPesqCli.cliente.Nome;
                            txtFantasia.Text = formPesqCli.cliente.Fantasia;
                            cbLogradouro.Text = formPesqCli.cliente.Logradouro;
                            msktxtCEP.Text = formPesqCli.cliente.CEP;
                            txtEndereco.Text = formPesqCli.cliente.Endereco;
                            txtNumeroEnd.Text = formPesqCli.cliente.NumeroEndereco.ToString();
                            txtBairro.Text = formPesqCli.cliente.Bairro;
                            cbEstados.Text = formPesqCli.cliente.Estado;
                            txtCidade.Text = formPesqCli.cliente.Cidade;
                            cbTipo.Text = formPesqCli.cliente.Tipo;
                            msktxtCPF.Text = formPesqCli.cliente.CPF;
                            msktxtCNPJ.Text = formPesqCli.cliente.CNPJ;
                            msktxtTelefone.Text = formPesqCli.cliente.Telefone;
                            msktxtCelular.Text = formPesqCli.cliente.Celular;
                            txtEmail.Text = formPesqCli.cliente.Email;
                            txtObservacao.Text = formPesqCli.cliente.Observacao;
                            HabilitarCampos();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para pesquisar clientes.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void msktxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void msktxtCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void msktxtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void msktxtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private async void btnBuscaCEP_Click(object sender, EventArgs e)
        {
            string cep = msktxtCEP.Text.Trim();
            viaCep viacep = new viaCep();
            dtoEndereco endereco = await viacep.BuscarCep(cep);

            if (endereco != null)
            {
                txtEndereco.Text = endereco.logradouro;
                cbEstados.Text = endereco.estado;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.localidade;
                return;
            }
            return;
        }
        private async void txtCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string cep = msktxtCEP.Text.Trim();
                viaCep viacep = new viaCep();
                dtoEndereco endereco = await viacep.BuscarCep(cep);

                if (endereco != null)
                {
                    txtEndereco.Text = endereco.logradouro;
                    cbEstados.Text = endereco.estado;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.localidade;
                    return;
                }
                return;
            }
        }
    }
}
