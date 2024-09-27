using CadastroCliente.Fontes.DAL;
using CadastroCliente.Fontes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmPesquisaProduto : Form
    {
        public dtoProduto produto { get; set; }
        public frmPesquisaProduto()
        {
            InitializeComponent();
            this.AcceptButton = botaoPesquisaProduto;
            cbTipo.SelectedIndexChanged += new EventHandler(cbTipo_SelectedIndexChanged);
            AtualizarEstadoTxtPesquisa();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarEstadoTxtPesquisa();
        }

        private void AtualizarEstadoTxtPesquisa()
        {
            txtPesquisa.Enabled = cbTipo.SelectedIndex > -1;
        }
        public void CarregarProdutos (string Tipo, string inf)
        {
            var produtos = dalProduto.Pesquisar(Tipo, inf);
            dataGridProduto.DataSource = produtos;
        }

        private void frmPesquisaProduto_Load(object sender, EventArgs e)
        {
            CarregarProdutos("Nenhum", "");
        }

        private void botaoPesquisaProduto_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                CarregarProdutos("Nenhum", "");
                return;
            }
            if (cbTipo.SelectedIndex == 1)
            {
                CarregarProdutos("CodBarras", txtPesquisa.Text);
                return;
            }
            if (cbTipo.SelectedIndex == 2)
            {
                CarregarProdutos("Descricao", txtPesquisa.Text);
                return;
            }
            CarregarProdutos(cbTipo.Text, txtPesquisa.Text);
        }

        private void dataGridProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ValorCelula = dataGridProduto.Rows[e.RowIndex].Cells[1].Value;
                produto = dalProduto.PesquisarProdutoID(Convert.ToInt32(ValorCelula));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
