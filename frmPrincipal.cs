using CadastroCliente.Fontes;
using CadastroCliente.Fontes.DAL;
using FastReport.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(string nomeLogin)
        {
            InitializeComponent();
            lbNomeUsuario.Text = nomeLogin;
        }

        public string nomeLogin { get; set; }

        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(lbNomeUsuario.Text);
            if (permissoes.cad_cliente == "S")
            {
                var formCadCliente = new frmCliente(lbNomeUsuario.Text);
                formCadCliente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar o cadastro de clientes.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(lbNomeUsuario.Text);
            if (permissoes.cad_produto == "S")
            {
                var formCadProduto = new frmProduto(lbNomeUsuario.Text);
                formCadProduto.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar o cadastro de produtos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnCadUsuario_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(lbNomeUsuario.Text);
            if (permissoes.cad_usuario == "S")
            {
                var formCadUser = new frmUsuario(lbNomeUsuario.Text);
                formCadUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seu usuário não tem permissão para acessar o cadastro de usuários.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var frmRelatorio = new frmRelatorios(lbNomeUsuario.Text);
            frmRelatorio.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            var frmVendas = new Vendas(lbNomeUsuario.Text);
            frmVendas.ShowDialog();
        }
    }
}
