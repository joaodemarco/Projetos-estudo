using CadastroCliente.Fontes.DAL;
using CadastroCliente.Fontes.DTO;
using System;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CadastroCliente.Fontes
{
    public partial class Vendas : Form
    {
        #region Variáveis
        public bool desconto = false;
        private bool desejaAlterar = false;
        public decimal preco;
        public decimal desc;
        public decimal qtd;
        public string nomeLogin { get; set; }

        public decimal totalGeral;
        #endregion
        public Vendas(string nomeUser)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            nomeLogin = nomeUser;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTotalGeral.Text != "" && dalVendas.PesquisarItem(txtNumero.Text) != 0)
            {
                if (e.KeyCode == Keys.Q)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo finalizar essa venda? Finalizadora: Q - Dinheiro.", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (rdValor.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string valorfinal = (dalVendas.TotalGeral(txtNumero.Text) - decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"))).ToString();
                            string descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR")).ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Valor", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "Q - Dinheiro", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string descontogeral = (decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))).ToString(); ;
                            decimal valordescontoreal = (dalVendas.TotalGeral(txtNumero.Text)) - (((decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))) / 100) * dalVendas.TotalGeral(txtNumero.Text));
                            string valorfinal = valordescontoreal.ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Porcentagem", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "Q - Dinheiro", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.R)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo finalizar essa venda? Finalizadora: R - Ficha.", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (rdValor.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string valorfinal = (dalVendas.TotalGeral(txtNumero.Text) - decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"))).ToString();
                            string descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR")).ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Valor", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "R - Ficha", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string descontogeral = (decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))).ToString(); ;
                            decimal valordescontoreal = (dalVendas.TotalGeral(txtNumero.Text)) - (((decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))) / 100) * dalVendas.TotalGeral(txtNumero.Text));
                            string valorfinal = valordescontoreal.ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Porcentagem", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "R - Ficha", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.C)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo finalizar essa venda? Finalizadora: C - Cartão de Crédito.", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (rdValor.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string valorfinal = (dalVendas.TotalGeral(txtNumero.Text) - decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"))).ToString();
                            string descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR")).ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Valor", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "C - Cartão de Crédito", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        if (rdPercent.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string descontogeral = (decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))).ToString(); ;
                            decimal valordescontoreal = (dalVendas.TotalGeral(txtNumero.Text)) - (((decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))) / 100) * dalVendas.TotalGeral(txtNumero.Text));
                            string valorfinal = valordescontoreal.ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Porcentagem", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "C - Cartão de Crédito", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.U)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo finalizar essa venda? Finalizadora: U - Boleto.", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (rdValor.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string valorfinal = (dalVendas.TotalGeral(txtNumero.Text) - decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"))).ToString();
                            string descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR")).ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Valor", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "U - Boleto", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string descontogeral = (decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))).ToString(); ;
                            decimal valordescontoreal = (dalVendas.TotalGeral(txtNumero.Text)) - (((decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))) / 100) * dalVendas.TotalGeral(txtNumero.Text));
                            string valorfinal = valordescontoreal.ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Porcentagem", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "U - Boleto", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.B)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo finalizar essa venda? Finalizadora: B - Cartão de Débito.", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (rdValor.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string valorfinal = (dalVendas.TotalGeral(txtNumero.Text) - decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"))).ToString();
                            string descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR")).ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Valor", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "B - Cartão de Débito", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string descontogeral = (decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))).ToString(); ;
                            decimal valordescontoreal = (dalVendas.TotalGeral(txtNumero.Text)) - (((decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))) / 100) * dalVendas.TotalGeral(txtNumero.Text));
                            string valorfinal = valordescontoreal.ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Porcentagem", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "B - Cartão de Débito", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
                else if (e.KeyCode == Keys.H)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo finalizar essa venda? Finalizadora: H - Cheque.", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (rdValor.Checked == true)
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string valorfinal = (dalVendas.TotalGeral(txtNumero.Text) - decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"))).ToString();
                            string descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR")).ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Valor", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "H - Cheque", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            string valortotal = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
                            string descontogeral = (decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))).ToString(); ;
                            decimal valordescontoreal = (dalVendas.TotalGeral(txtNumero.Text)) - (((decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"))) / 100) * dalVendas.TotalGeral(txtNumero.Text));
                            string valorfinal = valordescontoreal.ToString();
                            string descontoprodutos = (dalVendas.DescontoProdutos(txtNumero.Text)).ToString();
                            if (dalVendas.FinalizarVenda(txtNumero.Text, valortotal.Replace(",", "."), descontogeral.Replace(",", "."), "Porcentagem", descontoprodutos.Replace(",", "."), valorfinal.Replace(",", "."), "H - Cheque", nomeLogin))
                            {
                                MessageBox.Show("Venda finalizada com sucesso!", "Vendas", MessageBoxButtons.OK);
                                DesabilitarTudo();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Erro ao finalizar venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }
            }
        }

        #region Funcoes
        public void HabilitarIncluir()
        {
            txtCod.Enabled = true;
            cbClientes.Enabled = true;
            btnPesquisarCliente.Enabled = true;
            txtObs.Enabled = true;
        }

        public void DesabilitarIncluir()
        {
            txtCod.Enabled = false;
            cbClientes.Enabled = false;
            btnPesquisarCliente.Enabled = false;
            txtObs.Enabled = false;
        }
        public void HabilitarProdutos()
        {
            txtIDProd.Enabled = true;
            txtDesc.Enabled = true;
            cbUN.Enabled = true;
            txtPreco.Enabled = true;
            txtQtd.Enabled = true;
            txtDesconto.Enabled = true;
            txtTotal.Enabled = true;
            dtGridExibirProdutos.Enabled = true;
            btnSalvarProd.Enabled = true;
            btnExcluirProd.Enabled = true;
            btnPesquisarProd.Enabled = true;
        }
        public void DesabilitarProdutos()
        {
            txtIDProd.Text = "";
            txtDesc.Text = "";
            cbUN.Text = "";
            txtPreco.Text = "";
            txtQtd.Text = "";
            txtDesconto.Text = "";
            txtTotal.Text = "";
            txtDescFinal.Text = "";
            txtTotalGeral.Text = "";
            txtIDProd.Enabled = false;
            txtDesc.Enabled = false;
            cbUN.Enabled = false;
            txtPreco.Enabled = false;
            txtQtd.Enabled = false;
            txtDesconto.Enabled = false;
            txtTotal.Enabled = false;
            txtDescFinal.Enabled = false;
            dtGridExibirProdutos.Enabled = false;
            btnSalvarProd.Enabled = false;
            btnExcluirProd.Enabled = false;
            btnPesquisarProd.Enabled = false;
            rdPercent.Enabled = false;
            rdValor.Enabled = false;
            rdPercent.Checked = false;
            rdValor.Checked = false;
        }

        private void FormatCurrencyPreco()
        {
            string input = new string(txtPreco.Text.Where(c => char.IsDigit(c)).ToArray());

            if (decimal.TryParse(input, out decimal value))
            {

                txtPreco.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                txtPreco.Select(txtPreco.Text.Length, 0);
            }
            else
            {
                txtPreco.Text = string.Empty;
            }
        }

        private void DesabilitarTudo()
        {
            txtCod.Enabled = false;
            txtCod.Text = "";
            cbClientes.Enabled = false;
            cbClientes.Items.Clear();
            cbClientes.SelectedIndex = -1;
            btnPesquisarCliente.Enabled = false;
            txtObs.Enabled = false;
            txtObs.Text = "";
            txtDataEmissao.Text = "";
            txtDtFinalizacao.Text = "";
            txtIDProd.Text = "";
            txtDesc.Text = "";
            cbUN.Text = "";
            txtPreco.Text = "";
            txtQtd.Text = "";
            txtDesconto.Text = "";
            txtTotal.Text = "";
            txtDescFinal.Text = "";
            txtTotalGeral.Text = "";
            txtIDProd.Enabled = false;
            txtDesc.Enabled = false;
            cbUN.Enabled = false;
            txtPreco.Enabled = false;
            txtQtd.Enabled = false;
            txtDesconto.Enabled = false;
            txtTotal.Enabled = false;
            txtDescFinal.Enabled = false;
            dtGridExibirProdutos.Enabled = false;
            btnSalvarProd.Enabled = false;
            btnExcluirProd.Enabled = false;
            btnPesquisarProd.Enabled = false;
            txtTotalGeral.Enabled = false;
            txtTotalGeral.Text = "";
            txtNumero.Text = "";
            desconto = false;
            txtDescFinal.TextChanged -= txtDescFinal_TextChanged;
            txtDescFinal.Text = "";
            txtDescFinal.Enabled = false;
            dtGridExibirProdutos.DataSource = null;
            rdValor.Enabled = false;
            rdValor.Checked = false;
            rdPercent.Enabled = false;
            rdPercent.Checked = false;

        }
        private void LimparCampos()
        {
            txtCod.Text = "";
            cbClientes.Items.Clear();
            txtNumero.Text = "";
            txtDataEmissao.Text = "";
            txtDtFinalizacao.Text = "";
            txtObs.Text = "";
            txtIDProd.Text = "";
            txtDesc.Text = "";
            txtPreco.Text = "";
            txtQtd.Text = "";
            txtDesconto.Text = "";
            txtTotal.Text = "";
            dtGridExibirProdutos.Rows.Clear();
            txtDescFinal.Text = "";
            txtTotalGeral.Text = "";
            rdValor.Checked = false;
            rdPercent.Checked = false;
        }
        private void FormatCurrencyDesconto()
        {
            string input = new string(txtDesconto.Text.Where(c => char.IsDigit(c)).ToArray());

            if (decimal.TryParse(input, out decimal value))
            {

                txtDesconto.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                txtDesconto.Select(txtDesconto.Text.Length, 0);
            }
            else
            {
                txtDesconto.Text = string.Empty;
            }
        }

        private void FormatCurrencyTotalProduto()
        {
            string input = new string(txtTotal.Text.Where(c => char.IsDigit(c)).ToArray());

            if (decimal.TryParse(input, out decimal value))
            {

                txtTotal.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                txtTotal.Select(txtTotal.Text.Length, 0);
            }
            else
            {
                txtTotal.Text = string.Empty;
            }
        }

        private void FormatCurrencyTotalGeral()


        {
            string input = new string(txtTotalGeral.Text.Where(c => char.IsDigit(c)).ToArray());

            if (decimal.TryParse(input, out decimal value))
            {

                txtTotalGeral.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                txtTotalGeral.Select(txtTotalGeral.Text.Length, 0);
            }
            else
            {
                txtTotalGeral.Text = string.Empty;
            }
        }

        private void FormatCurrencyDescontoGeral()
        {
            string input = new string(txtDescFinal.Text.Where(c => char.IsDigit(c)).ToArray());

            if (rdValor.Checked == true)
            {
                if (decimal.TryParse(input, out decimal value))
                {

                    txtDescFinal.Text = string.Format(new CultureInfo("pt-BR"), "{0:C}", value / 100);
                    txtDescFinal.Select(txtDescFinal.Text.Length, 0);
                }
                else
                {
                    txtDescFinal.Text = string.Empty;
                }
            }
            else
            {
                if (desconto)
                {
                    string input1 = new string(txtDescFinal.Text.Where(c => char.IsDigit(c)).ToArray());

                    if (!string.IsNullOrEmpty(input1))
                    {
                        if (decimal.TryParse(input1, out decimal value))
                        {
                            if (value > 10000)
                            {
                                value = 10000;
                            }

                            txtDescFinal.Text = string.Format(new CultureInfo("pt-BR"), "{0:N2}%", value / 100);
                            txtDescFinal.Select(txtDescFinal.Text.Length - 1, 0);
                        }
                        else
                        {
                            txtDescFinal.Text = "0,00%";
                        }
                    }
                    else
                    {
                        txtDescFinal.Text = "0,00%";
                        txtDescFinal.Select(txtDescFinal.Text.Length - 1, 0);
                    }
                }
            }
        }

        public bool VerificarInclusaoProd()
        {
            if (txtIDProd.Text == "")
            {
                MessageBox.Show("Não foi selecionado nenhum produto.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtPreco.Text == "" || txtTotal.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos para incluir o produto na venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (txtQtd.Text == "")
            {
                MessageBox.Show("Por favor, informe a quantidade do produto.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        private bool DesejaAlterar(string numerovenda, string idproduto)
        {
            DialogResult resultado = MessageBox.Show("Produto já incluído. Deseja fazer alguma alteração?", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                var produto = dalVendas.PesquisarProduto(numerovenda, idproduto);
                txtIDProd.Text = produto.CodigoProdutoID.ToString();
                txtDesc.Text = produto.Descricao;
                cbUN.Text = produto.Unidade;
                txtPreco.Text = (produto.Preco * 100).ToString();
                txtQtd.Text = produto.Quantidade.ToString();
                txtDesconto.Text = (produto.Desconto * 100).ToString();
                txtTotal.Text = (produto.Total * 100).ToString();
                desejaAlterar = true;
                return true;
            }
            desejaAlterar = false;
            return false;
        }

        #endregion

        private void btnNovo_Click(object sender, EventArgs e)
        {
            desconto = true;
            HabilitarIncluir();
            LimparCampos();
            txtDescFinal.TextChanged += txtDescFinal_TextChanged;

            DateTime dataAtual = DateTime.Now;
            txtDataEmissao.Text = (dataAtual.ToString("dd/MM/yyyy"));
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                cbClientes.Items.Clear();
                if (txtCod.Text == "")
                {
                    return;
                }
                var cliente = dalCliente.PesquisarCliente(Convert.ToInt32(txtCod.Text));
                if (cliente == null)
                {
                    MessageBox.Show("Cliente não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                cbClientes.Items.Add(cliente.Nome);
                cbClientes.SelectedIndex = 0;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            using (frmPesquisaCliente frmPesquisaCliente = new frmPesquisaCliente())
            {
                if (frmPesquisaCliente.ShowDialog() == DialogResult.OK)
                {
                    if (frmPesquisaCliente.cliente != null)
                    {
                        txtCod.Text = (frmPesquisaCliente.cliente.ID.ToString());
                        cbClientes.Items.Clear();
                        cbClientes.Items.Add(frmPesquisaCliente.cliente.Nome);
                        cbClientes.SelectedIndex = 0;
                    }
                }
            }
        }

        private void btnSalvar1_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex <= -1)
            {
                MessageBox.Show("Por favor, selecione um cliente antes de prosseguir.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dtoVendas venda1 = new dtoVendas();
            venda1.CodCliente = txtCod.Text;
            venda1.DataEmissao = DateTime.ParseExact(txtDataEmissao.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            venda1.Observacao = txtObs.Text;
            venda1.Usuario = nomeLogin;

            var numvenda = dalVendas.InserirVenda1(venda1);
            if (numvenda == -1)
            {
                MessageBox.Show("Erro ao inserir venda.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtNumero.Text = numvenda.ToString();
                DesabilitarIncluir();
                HabilitarProdutos();
                txtIDProd.Focus();
                btnSalvar1.Enabled = false;
            }
        }

        private void txtIDProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (txtIDProd.Text == "")
                {
                    return;
                }
                var resultado = dalVendas.PesquisarProduto(txtNumero.Text, txtIDProd.Text);
                if (resultado != null)
                {
                    desejaAlterar = DesejaAlterar(txtNumero.Text, txtIDProd.Text);
                    if (desejaAlterar)
                    {
                        return;
                    }
                    else
                    {
                        txtIDProd.Text = "";
                        txtDesc.Text = "";
                        cbUN.Text = "";
                        txtPreco.Text = "";
                        txtQtd.Text = "";
                        txtDesconto.Text = "";
                        txtTotal.Text = "";
                        return;
                    }
                }
                var produto = dalProduto.PesquisarProdutoID(Convert.ToInt32(txtIDProd.Text));
                if (produto == null)
                {
                    MessageBox.Show("Produto não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                txtDesc.Text = produto.Descricao;
                cbUN.Text = produto.Unidade;
                txtPreco.Text = (produto.ValorVenda / 100).ToString();
                txtQtd.Text = "";
                txtTotal.Text = "";
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == (char)Keys.Oemcomma)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                float preco;
                int qtd;
                float desc;
                if (txtDesconto.Text == "")
                {
                    desc = 0;
                }
                else
                {
                    desc = float.Parse(txtDesconto.Text.Replace("R$", "").Replace(",", "."));
                }
                if (txtQtd.Text == "" || txtQtd.Text == "0")
                {
                    this.SelectNextControl((Control)sender, true, true, true, true);
                    txtQtd.Text = "1";
                    qtd = int.Parse(txtQtd.Text);
                    if (txtPreco.Text != "")
                    {
                        preco = float.Parse(txtPreco.Text.Replace("R$", "").Replace(",", "."));
                        txtTotal.Text = ((preco * qtd) - desc).ToString();
                    }
                    return;
                }
                if (txtPreco.Text == "")
                {
                    txtTotal.Text = "";
                    return;
                }
                if (txtQtd.Text != "" && txtPreco.Text != "")
                {
                    preco = float.Parse(txtPreco.Text.Replace("R$", "").Replace(",", "."));
                    qtd = Convert.ToInt32(txtQtd.Text);
                    if (desc > (preco * qtd))
                    {
                        MessageBox.Show("O valor do desconto não pode ser maior do que preço x quantidade.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtDesconto.Text = "0";
                        return;
                    }
                    txtTotal.Text = ((preco * qtd) - desc).ToString();
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                float preco;
                int qtd;
                float desc;

                if (txtPreco.Text == "")
                {
                    txtTotal.Text = "";
                    return;
                }
                if (txtQtd.Text == "")
                {
                    txtQtd.Text = "1";
                    qtd = 1;
                }
                if (txtDesconto.Text == "")
                {
                    txtDesconto.Text = "0";
                    desc = 0;
                }
                preco = float.Parse(txtPreco.Text.Replace("R$", "").Replace(",", "."));
                qtd = Convert.ToInt32(txtQtd.Text);
                desc = float.Parse(txtDesconto.Text.Replace("R$", "").Replace(",", "."));
                if (desc > (preco * qtd))
                {
                    MessageBox.Show("O valor do desconto não pode ser maior do que preço x quantidade.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDesconto.Text = "0";
                    return;
                }

                txtTotal.Text = ((preco * qtd) - desc).ToString();
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            btnSalvarProd.Focus();
        }

        private void cbClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnPesquisarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbClientes.SelectedIndex == 0)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void txtObs_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbClientes.SelectedIndex == 0)
                {
                    e.Handled = true;
                    this.SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyPreco();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyDesconto();
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyTotalProduto();
        }

        private void txtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
                cbUN.DroppedDown = true;
            }
        }

        private void cbUN_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SelectNextControl((Control)sender, true, true, true, true);
        }

        private void txtIDProd_TextChanged(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            cbUN.SelectedIndex = -1;
            txtPreco.Text = "";
            txtQtd.Text = "";
            txtDesconto.Text = "";
            txtTotal.Text = "";
            desejaAlterar = false;
        }

        private void btnSalvarProd_Click(object sender, EventArgs e)
        {
            if (dalVendas.PesquisarProduto(txtNumero.Text, txtIDProd.Text) != null && desejaAlterar == false)
            {
                MessageBox.Show("Esse produto já foi incluido.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!VerificarInclusaoProd())
            {
                return;
            }
            preco = decimal.Parse(txtPreco.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
            qtd = Convert.ToInt32(txtQtd.Text);
            desc = decimal.Parse(txtDesconto.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
            if (desc > (preco * qtd))
            {
                MessageBox.Show("O desconto não pode ser maior que o preço vezes a quantidade.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (desejaAlterar == false)
            {
                if (!VerificarInclusaoProd())
                {
                    return;
                }
                preco = decimal.Parse(txtPreco.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
                qtd = decimal.Parse(txtQtd.Text);
                desc = decimal.Parse(txtDesconto.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
                string total = ((preco * qtd) - desc).ToString("C", new CultureInfo("pt-BR"));
                string totalnovo = total.Replace("R$", "").Trim();
                decimal totalvalor = decimal.Parse(totalnovo, new CultureInfo("pt-BR"));

                int id = Convert.ToInt32(txtIDProd.Text);
                try
                {
                    var produto = dalProduto.PesquisarProdutoID(id);
                    dtoDetalheVendas detalheproduto = new dtoDetalheVendas();

                    detalheproduto.Numero = txtNumero.Text;
                    var Item = dalVendas.PesquisarItem(detalheproduto.Numero);
                    if (Item == 0)
                    {
                        Item = 1;
                    }
                    else
                    {
                        Item++;
                    }
                    detalheproduto.Item = Item;
                    detalheproduto.CodigoProdutoID = Convert.ToInt32(txtIDProd.Text);
                    detalheproduto.Descricao = txtDesc.Text;
                    detalheproduto.Preco = preco;
                    detalheproduto.Quantidade = qtd;
                    detalheproduto.Desconto = desc;
                    detalheproduto.Total = totalvalor;
                    detalheproduto.Unidade = cbUN.Text;
                    detalheproduto.CFOP = produto.CFOP;
                    detalheproduto.Fornecedor = produto.Fornecedor;
                    detalheproduto.Marca = produto.Marca;
                    detalheproduto.PrCusto = produto.PrCompra;
                    detalheproduto.Departamento = produto.Departamento;
                    detalheproduto.Complemento = produto.Complemento;
                    if (!dalVendas.DetalheVenda(detalheproduto))
                    {
                        MessageBox.Show("Erro ao incluir produto.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var produtosNaoExcluidos = dalVendas.AtualizarDataGrid(detalheproduto.Numero);
                    dtGridExibirProdutos.DataSource = produtosNaoExcluidos;
                    var valorTotal = dalVendas.TotalGeral(txtNumero.Text);
                    txtDescFinal.Enabled = true;
                    rdPercent.Enabled = true;
                    rdValor.Enabled = true;
                    rdValor.Checked = true;
                    txtDescFinal.Text = "R$0,00";
                    txtTotalGeral.Text = (valorTotal).ToString();
                    txtIDProd.Text = "";
                    txtDesc.Text = "";
                    cbUN.SelectedIndex = -1;
                    txtPreco.Text = "";
                    txtQtd.Text = "";
                    txtDesconto.Text = "";
                    txtTotal.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao lançar produto.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                preco = decimal.Parse(txtPreco.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
                qtd = Convert.ToInt32(txtQtd.Text);
                desc = decimal.Parse(txtDesconto.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
                string total = ((preco * qtd) - desc).ToString("C", new CultureInfo("pt-BR"));
                string totalnovo = total.Replace("R$", "").Trim();
                decimal totalvalor = decimal.Parse(totalnovo, new CultureInfo("pt-BR"));
                var produtoalterar = new dtoDetalheVendas();
                produtoalterar.Numero = txtNumero.Text;
                produtoalterar.Item = dalVendas.PesquisarItemPorID(txtNumero.Text, txtIDProd.Text);
                produtoalterar.Descricao = txtDesc.Text;
                produtoalterar.Unidade = cbUN.Text;
                produtoalterar.Preco = preco;
                produtoalterar.Quantidade = qtd;
                produtoalterar.Desconto = desc;
                produtoalterar.Total = totalvalor;
                if (!dalVendas.AtualizarProduto(produtoalterar))
                {
                    MessageBox.Show("Erro ao alterar lançamento.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var produtosNaoExcluidos = dalVendas.AtualizarDataGrid(produtoalterar.Numero);
                    dtGridExibirProdutos.DataSource = produtosNaoExcluidos;
                    dtGridExibirProdutos.Columns["Numero"].Visible = false;
                    dtGridExibirProdutos.Columns["DataLancamento"].Visible = false;
                    dtGridExibirProdutos.Columns["CFOP"].Visible = false;
                    dtGridExibirProdutos.Columns["Fornecedor"].Visible = false;
                    dtGridExibirProdutos.Columns["Marca"].Visible = false;
                    dtGridExibirProdutos.Columns["PrCusto"].Visible = false;
                    dtGridExibirProdutos.Columns["Departamento"].Visible = false;
                    dtGridExibirProdutos.Columns["Complemento"].Visible = false;
                    dtGridExibirProdutos.Columns["Excluido"].Visible = false;
                    dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                    dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                    dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.Format = "C2";
                    dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                    dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.Format = "C2";
                    dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                    var valorTotal = (dalVendas.TotalGeral(txtNumero.Text));
                    txtTotalGeral.Text = (valorTotal).ToString();
                    txtIDProd.Text = "";
                    txtDesc.Text = "";
                    cbUN.SelectedIndex = -1;
                    txtPreco.Text = "";
                    txtQtd.Text = "";
                    txtDesconto.Text = "";
                    txtTotal.Text = "";
                    desejaAlterar = false;
                }
            }

        }

        private void dtGridExibirProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dtGridExibirProdutos.Rows[e.RowIndex];
                string numvenda = row.Cells["Numero"].Value.ToString();
                string id = row.Cells["CodigoProdutoID"].Value.ToString();

                desejaAlterar = DesejaAlterar(numvenda, id);
            }
        }

        private void btnExcluirProd_Click(object sender, EventArgs e)
        {
            if (dtGridExibirProdutos.SelectedRows.Count > -1 && txtIDProd.Text == "")
            {
                DialogResult resultado1 = MessageBox.Show("Deseja mesmo excluir o lançamento do produto selecionado?", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado1 == DialogResult.Yes)
                {
                    int RowIndex = dtGridExibirProdutos.SelectedRows[0].Index;
                    DataGridViewRow row = dtGridExibirProdutos.Rows[RowIndex];

                    string produtoid = row.Cells["CodigoProdutoID"].Value.ToString();

                    if (dalVendas.ExcluirLançamento(txtNumero.Text, produtoid))
                    {
                        txtIDProd.Text = "";
                        txtDesc.Text = "";
                        cbUN.Text = "";
                        txtPreco.Text = "";
                        txtQtd.Text = "";
                        txtDesconto.Text = "";
                        txtTotal.Text = "";
                        txtDescFinal.Text = "";
                        txtTotalGeral.Text = "";
                        var produtosNaoExcluidos = dalVendas.AtualizarDataGrid(txtNumero.Text);
                        var valortotal = (dalVendas.TotalGeral(txtNumero.Text) * 100);
                        dtGridExibirProdutos.DataSource = produtosNaoExcluidos;
                        dtGridExibirProdutos.Columns["Numero"].Visible = false;
                        dtGridExibirProdutos.Columns["DataLancamento"].Visible = false;
                        dtGridExibirProdutos.Columns["CFOP"].Visible = false;
                        dtGridExibirProdutos.Columns["Fornecedor"].Visible = false;
                        dtGridExibirProdutos.Columns["Marca"].Visible = false;
                        dtGridExibirProdutos.Columns["PrCusto"].Visible = false;
                        dtGridExibirProdutos.Columns["Departamento"].Visible = false;
                        dtGridExibirProdutos.Columns["Complemento"].Visible = false;
                        dtGridExibirProdutos.Columns["Excluido"].Visible = false;
                        dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                        dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.Format = "C2";
                        dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.Format = "C2";
                        dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        txtTotalGeral.Text = valortotal.ToString();
                        MessageBox.Show("Lançamento excluído com sucesso.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desejaAlterar = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o lançamento.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desejaAlterar = false;
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            if (dtGridExibirProdutos.SelectedRows.Count <= -1 && txtIDProd.Text == "")
            {
                MessageBox.Show("Nenhum produto selecionado.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dtGridExibirProdutos.SelectedRows.Count <= -1 && txtIDProd.Text != "")
            {
                if (dalVendas.PesquisarItemPorID(txtNumero.Text, txtIDProd.Text) == 0)
                {
                    DialogResult resultado = MessageBox.Show("Deseja mesmo excluir o lançamento deste produto?", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        if (dalVendas.ExcluirLançamento(txtNumero.Text, txtIDProd.Text))
                        {
                            var valorTotal = dalVendas.TotalGeral(txtNumero.Text);
                            txtTotalGeral.Text = valorTotal.ToString();
                            txtIDProd.Text = "";
                            txtDesc.Text = "";
                            cbUN.Text = "";
                            txtPreco.Text = "";
                            txtQtd.Text = "";
                            txtDesconto.Text = "";
                            txtTotal.Text = "";
                            txtDescFinal.Text = "";
                            txtTotalGeral.Text = "";
                            var produtosNaoExcluidos = dalVendas.AtualizarDataGrid(txtNumero.Text);
                            dtGridExibirProdutos.DataSource = produtosNaoExcluidos;
                            dtGridExibirProdutos.Columns["Numero"].Visible = false;
                            dtGridExibirProdutos.Columns["DataLancamento"].Visible = false;
                            dtGridExibirProdutos.Columns["CFOP"].Visible = false;
                            dtGridExibirProdutos.Columns["Fornecedor"].Visible = false;
                            dtGridExibirProdutos.Columns["Marca"].Visible = false;
                            dtGridExibirProdutos.Columns["PrCusto"].Visible = false;
                            dtGridExibirProdutos.Columns["Departamento"].Visible = false;
                            dtGridExibirProdutos.Columns["Complemento"].Visible = false;
                            dtGridExibirProdutos.Columns["Excluido"].Visible = false;
                            dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                            dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                            dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.Format = "C2";
                            dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                            dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.Format = "C2";
                            dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                            MessageBox.Show("Lançamento excluído com sucesso.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            desejaAlterar = false;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não foi possível excluir o lançamento.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            desejaAlterar = false;
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Esse produto ainda não foi incluído.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (dtGridExibirProdutos.SelectedRows.Count >= 0 && txtIDProd.Text != "")
            {
                DialogResult resultado1 = MessageBox.Show($"Deseja mesmo excluir o lançamento deste produto? Código ID: {txtIDProd.Text}", "Vendas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado1 == DialogResult.Yes)
                {
                    if (dalVendas.ExcluirLançamento(txtNumero.Text, txtIDProd.Text))
                    {
                        txtIDProd.Text = "";
                        txtDesc.Text = "";
                        cbUN.Text = "";
                        txtPreco.Text = "";
                        txtQtd.Text = "";
                        txtDesconto.Text = "";
                        txtTotal.Text = "";
                        txtDescFinal.Text = "";
                        txtTotalGeral.Text = "";
                        var valorTotal = dalVendas.TotalGeral(txtNumero.Text);
                        txtTotalGeral.Text = valorTotal.ToString();
                        var produtosNaoExcluidos = dalVendas.AtualizarDataGrid(txtNumero.Text);
                        dtGridExibirProdutos.DataSource = produtosNaoExcluidos;
                        dtGridExibirProdutos.Columns["Numero"].Visible = false;
                        dtGridExibirProdutos.Columns["DataLancamento"].Visible = false;
                        dtGridExibirProdutos.Columns["CFOP"].Visible = false;
                        dtGridExibirProdutos.Columns["Fornecedor"].Visible = false;
                        dtGridExibirProdutos.Columns["Marca"].Visible = false;
                        dtGridExibirProdutos.Columns["PrCusto"].Visible = false;
                        dtGridExibirProdutos.Columns["Departamento"].Visible = false;
                        dtGridExibirProdutos.Columns["Complemento"].Visible = false;
                        dtGridExibirProdutos.Columns["Excluido"].Visible = false;
                        dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.Format = "C2";
                        dtGridExibirProdutos.Columns["Preco"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.Format = "C2";
                        dtGridExibirProdutos.Columns["Desconto"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.Format = "C2";
                        dtGridExibirProdutos.Columns["Total"].DefaultCellStyle.FormatProvider = new CultureInfo("pt-BR");
                        MessageBox.Show("Lançamento excluído com sucesso.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desejaAlterar = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível excluir o lançamento.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        desejaAlterar = false;
                        return;
                    }
                }
            }
        }

        private void txtTotalGeral_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyTotalGeral();
        }

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            cbClientes.SelectedIndex = -1;
            cbClientes.Items.Clear();
        }

        private void btnPesquisarProd_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(nomeLogin);
            if (permissoes.pesquisar_produto == "S")
            {
                using (frmPesquisaProduto formPesqProd = new frmPesquisaProduto())
                {
                    if (formPesqProd.ShowDialog() == DialogResult.OK)
                    {
                        if (formPesqProd.produto != null)
                        {
                            txtIDProd.Text = formPesqProd.produto.Id.ToString();
                            txtDesc.Text = formPesqProd.produto.Descricao;
                            cbUN.Text = formPesqProd.produto.Unidade;
                            txtPreco.Text = (formPesqProd.produto.ValorVenda * 100).ToString();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para pesquisar produtos.", "Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void txtDescFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || (e.KeyChar >= '0' && e.KeyChar <= '9'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (rdValor.Checked == true)
                {
                    if (txtDescFinal.Text == "" || txtDescFinal.Text == "R$0,00")
                    {
                        return;
                    }
                    decimal descontogeral = decimal.Parse(txtDescFinal.Text.Replace("R$", "").Trim(), new CultureInfo("pt-BR"));
                    decimal valortotal = dalVendas.TotalGeral(txtNumero.Text);
                    txtTotalGeral.Text = (((valortotal - (descontogeral)))).ToString();
                    return;
                }
                if (rdPercent.Checked == true)
                {
                    decimal descontogeral = decimal.Parse(txtDescFinal.Text.Replace("%", "").Trim(), new CultureInfo("pt-BR"));
                    decimal valortotal = dalVendas.TotalGeral(txtNumero.Text);
                    decimal percentvalor = (descontogeral / 100) * valortotal;
                    txtTotalGeral.Text = (((valortotal - percentvalor))).ToString("F2");
                    return;
                }
            }
        }

        private void txtDescFinal_TextChanged(object sender, EventArgs e)
        {
            FormatCurrencyDescontoGeral();
        }

        private void rdValor_Click(object sender, EventArgs e)
        {
            txtDescFinal.Text = "R$0,00";
            txtTotalGeral.Text = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
        }

        private void rdPercent_Click(object sender, EventArgs e)
        {
            txtDescFinal.Text = "0,00%";
            txtTotalGeral.Text = (dalVendas.TotalGeral(txtNumero.Text)).ToString();
        }

        private void txtDescFinal_Leave(object sender, EventArgs e)
        {
            txtDescFinal.Text = "0,00%";
            txtDescFinal.Select(txtDescFinal.Text.Length - 1, 0);
        }
    }
}
