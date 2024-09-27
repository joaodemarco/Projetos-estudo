using CadastroCliente.Fontes.DAL;
using CadastroCliente.Fontes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmProduto : Form
    {
        public string nomeUser { get; set; }
        public frmProduto(string nomeLogin)
        {
            InitializeComponent();
            nomeUser = nomeLogin;
            txtCompra.TextChanged += txtCompra_TextChanged;
            txtVenda.TextChanged += txtVenda_TextChanged;
        }

        public void HabilitarCampos()
        {
            txtCodBarras.Enabled = true;
            txtDesc.Enabled = true;
            msktxtCFOP.Enabled = true;
            txtForn.Enabled = true;
            txtMarca.Enabled = true;
            cbUN.Enabled = true;
            txtCompra.Enabled = true;
            txtVenda.Enabled = true;
            txtDepart.Enabled = true;
            txtComplemento.Enabled = true;
        }
        public void DesabilitarCampos()
        {
            txtCodBarras.Enabled = false;
            txtDesc.Enabled = false;
            msktxtCFOP.Enabled = false;
            txtForn.Enabled = false;
            txtMarca.Enabled = false;
            cbUN.Enabled = false;
            txtCompra.Enabled = false;
            txtVenda.Enabled = false;
            txtDepart.Enabled = false;
            txtComplemento.Enabled = false;
        }
        public void LimparCampos()
        {
            txtID.Text = "";
            txtCodBarras.Text = "";
            txtDesc.Text = "";
            msktxtCFOP.Text = "";
            txtForn.Text = "";
            txtMarca.Text = "";
            cbUN.SelectedIndex = -1;
            cbUN.Text = Text = "";
            txtCompra.Text = "";
            txtVenda.Text = "";
            txtDepart.Text = "";
            txtComplemento.Text = "";
        }
        public bool Validacao()
        {
            if (txtDesc.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, informe a descrição do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (msktxtCFOP.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, informe a CFOP do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (cbUN.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, informe a unidade do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtCompra.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, informe o preço de compra do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtVenda.Text.Length <= 0)
            {
                MessageBox.Show("Por favor, informe o preço de venda do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }


        private void btnIncluirProd_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissoes.inserir_produto == "S")
            {
                HabilitarCampos();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para incluir novos produtos.", "Cadastro de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if (txtDesc.Enabled == false && txtForn.Enabled == false)
            {
                MessageBox.Show("Por favor, clique no botão Incluir para cadastrar um novo produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var permissoes = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissoes.alterar_produto == "S")
            {
                if (txtID.Text == "")
                {
                    if (!Validacao())
                    {
                        return;
                    }
                    string prcompra = (txtCompra.Text.Replace("R", "").Replace("$", "").Replace(",", ".").ToString());
                    string prvenda = (txtVenda.Text.Replace("R", "").Replace("$", "").Replace(",", ".").ToString());

                    dtoProduto Produto = new dtoProduto();
                    Produto.CodBarras = Convert.ToInt32(txtCodBarras.Text);
                    Produto.Descricao = txtDesc.Text;
                    Produto.CFOP = msktxtCFOP.Text;
                    Produto.Fornecedor = txtForn.Text;
                    Produto.Marca = txtMarca.Text;
                    Produto.Unidade = cbUN.Text;
                    Produto.PrCompra = decimal.Parse(prcompra);
                    Produto.ValorVenda = decimal.Parse(prvenda);
                    Produto.Departamento = txtDepart.Text;
                    Produto.Complemento = txtComplemento.Text;

                    dalProduto.InserirProduto(Produto);
                    DesabilitarCampos();
                    LimparCampos();
                    MessageBox.Show("Cadastro salvo com sucesso.", "Cadastro de produtos.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                if (txtID.Text != "")
                {
                    string prcompra = (txtCompra.Text.Replace("R", "").Replace("$", "").Replace(",", ".").ToString());
                    string prvenda = (txtVenda.Text.Replace("R", "").Replace("$", "").Replace(",", ".").ToString());
                    dtoProduto produto = new dtoProduto();
                    produto.Id = Convert.ToInt32(txtID.Text);
                    produto.CodBarras = Convert.ToInt32(txtCodBarras.Text);
                    produto.Descricao = txtDesc.Text;
                    produto.CFOP = msktxtCFOP.Text;
                    produto.Fornecedor = txtForn.Text;
                    produto.Marca = txtMarca.Text;
                    produto.Unidade = cbUN.Text;
                    produto.PrCompra = decimal.Parse(prcompra);
                    produto.ValorVenda = decimal.Parse(prvenda);
                    produto.Departamento = txtDepart.Text;
                    produto.Complemento = txtComplemento.Text;

                    if (dalProduto.AlterarCadastro(produto))
                    {
                        DesabilitarCampos();
                        LimparCampos();
                        MessageBox.Show("Cadastro salvo com sucesso.", "Cadastro de produtos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para alterar produtos.", "Cadastro de produtos.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissoes.pesquisar_produto == "S")
            {
                using (frmPesquisaProduto formPesqProd = new frmPesquisaProduto())
                {
                    if (formPesqProd.ShowDialog() == DialogResult.OK)
                    {
                        if (formPesqProd.produto != null)
                        {
                            txtID.Text = formPesqProd.produto.Id.ToString();
                            txtCodBarras.Text = formPesqProd.produto.CodBarras.ToString();
                            txtDesc.Text = formPesqProd.produto.Descricao;
                            msktxtCFOP.Text = formPesqProd.produto.CFOP;
                            txtForn.Text = formPesqProd.produto.Fornecedor;
                            txtMarca.Text = formPesqProd.produto.Marca;
                            cbUN.Text = formPesqProd.produto.Unidade;
                            txtCompra.Text = formPesqProd.produto.PrCompra.ToString();
                            txtVenda.Text = formPesqProd.produto.ValorVenda.ToString();
                            txtDepart.Text = formPesqProd.produto.Departamento;
                            txtComplemento.Text = formPesqProd.produto.Complemento;
                            HabilitarCampos();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para pesquisar os produtos.", "Cadastro de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
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

        private void msktxtCFOP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.OemPeriod || e.KeyChar == (char)Keys.Decimal)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVenda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCompra_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyCompra();
        }

        private void FormatCurrencyCompra()
        {
            string input = new string(txtCompra.Text.Where(c => char.IsDigit(c)).ToArray());

            if (decimal.TryParse(input, out decimal value))
            {

                txtCompra.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                txtCompra.Select(txtCompra.Text.Length, 0);
            }
            else
            {
                txtCompra.Text = string.Empty;
            }
        }

        private void FormatCurrencyVenda()
        {
            string input = new string(txtVenda.Text.Where(c => char.IsDigit(c)).ToArray());

            if (decimal.TryParse(input, out decimal value))
            {

                txtVenda.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                txtVenda.Select(txtCompra.Text.Length, 0);
            }
            else
            {
                txtVenda.Text = string.Empty;
            }
        }
        private void txtVenda_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyVenda();
        }
    }
}
