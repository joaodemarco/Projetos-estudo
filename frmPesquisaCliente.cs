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
    public partial class frmPesquisaCliente : Form
    {
        public dtoCliente cliente { get; set; }

        public frmPesquisaCliente()
        {
            InitializeComponent();
            cbTipoPesquisa.SelectedIndex = 1;
            CultureInfo culture = new CultureInfo("en-US");
        }

        public void CarregarClientes(string Tipo, string inf)
        {
            var clientes = dalCliente.Pesquisar(Tipo, inf);

            dataGridClientes.DataSource = clientes;
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            CarregarClientes("Nenhum", "");
        }

        private void botaoPesquisaCliente_Click(object sender, EventArgs e)
        {
            if (cbTipoPesquisa.Text == "")
            {
                CarregarClientes("Nenhum", "");
            }
            CarregarClientes(cbTipoPesquisa.Text, txtPesquisa.Text);
        }

        public void dataGridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var ValorCelula = dataGridClientes.Rows[e.RowIndex].Cells[0].Value;
                cliente = dalCliente.PesquisarCliente(Convert.ToInt32(ValorCelula));
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                CarregarClientes(cbTipoPesquisa.Text, txtPesquisa.Text);
            }
        }
    }
}
