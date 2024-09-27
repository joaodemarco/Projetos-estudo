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
    public partial class frmUsuario : Form
    {
        public string nomeUser { get; set; }
        public frmUsuario(string nomeLogin)
        {
            InitializeComponent();
            nomeUser = nomeLogin;
        }
        private string nome_permissao { get; set; }
        public dtoPermissoes permissao { get; set; }

        private void DesabilitarChecks()
        {
            chkCliente.Enabled = false;
            chkInserirCliente.Enabled = false;
            chkPesquisaCliente.Enabled = false;
            chkAlterarCliente.Enabled = false;
            chkProduto.Enabled = false;
            chkInserirProd.Enabled = false;
            chkAlterarProd.Enabled = false;
            chkPesquisarProd.Enabled = false;
            chkUsuario.Enabled = false;
            chkInserirUser.Enabled = false;
            chkAlterarUser.Enabled = false;
            chkVisualizar.Enabled = false;
            chkCliente.Checked = false;
            chkInserirCliente.Checked = false;
            chkPesquisaCliente.Checked = false;
            chkAlterarCliente.Checked = false;
            chkProduto.Checked = false;
            chkInserirProd.Checked = false;
            chkAlterarProd.Checked = false;
            chkPesquisarProd.Checked = false;
            chkUsuario.Checked = false;
            chkInserirUser.Checked = false;
            chkAlterarUser.Checked = false;
            chkVisualizar.Checked = false;
        }
        private void HabilitarChecks()
        {
            chkCliente.Enabled = true;
            if (chkCliente.Checked != true)
            {
                chkInserirCliente.Enabled = false;
                chkAlterarCliente.Enabled = false;
                chkPesquisaCliente.Enabled = false;
            }
            else
            {
                chkInserirCliente.Enabled = true;
                chkAlterarCliente.Enabled = true;
                chkPesquisaCliente.Enabled = true;
            }
            chkProduto.Enabled = true;
            if (chkProduto.Checked != true)
            {
                chkInserirProd.Enabled = false;
                chkAlterarProd.Enabled = false;
                chkPesquisarProd.Enabled = false;
            }
            else
            {
                chkInserirProd.Enabled = true;
                chkAlterarProd.Enabled = true;
                chkPesquisarProd.Enabled = true;
            }
            chkUsuario.Enabled = true;
            if (chkUsuario.Checked != true)
            {
                chkInserirUser.Enabled = false;
                chkAlterarUser.Enabled = false;
                chkVisualizar.Enabled = false;
            }
            else
            {
                chkInserirUser.Enabled = true;
                chkAlterarUser.Enabled = true;
                chkVisualizar.Enabled = true;
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            var usuarios = dalUsuario.PesquisarUsuario();
            foreach (var usuar in usuarios)
            {
                cbUsuarios.Items.Add(usuar.NOME);
            }
        }

        private void btnIncluirUser_Click(object sender, EventArgs e)
        {
            var permissoes = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissoes.inserir_usuario == "S")
            {
                frmInfUser frm = new frmInfUser();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var usuarios = dalUsuario.PesquisarUsuario();
                    foreach (var usuar in usuarios)
                    {
                        if (!cbUsuarios.Items.Contains(usuar.NOME))
                            cbUsuarios.Items.Add(usuar.NOME);
                    }
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para cadastrar novos usuários.", "Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private bool DesejaAlterar()
        {
            DialogResult result = MessageBox.Show("Deseja alterar a senha?", "Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        private void btnSelec_Click(object sender, EventArgs e)
        {
            if (cbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um usuário na caixa ao lado.", "Usuário");
                return;
            }
            var permissao = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissao.pesquisar_usuario == "S")
            {
                if (cbUsuarios.SelectedIndex >= 0)
                {
                    nome_permissao = cbUsuarios.Text;
                    var permissoes = dalUsuario.VerificarPermissoes(cbUsuarios.Text);

                    if (DesejaAlterar())
                    {
                        frmAlterarUser frm = new frmAlterarUser(cbUsuarios.Text);
                        frm.ShowDialog();

                        if (permissoes.cad_cliente == "S")
                        {
                            chkCliente.Checked = true;
                        }
                        else
                        {
                            chkCliente.Checked = false;
                        }
                        if (permissoes.inserir_cliente == "S")
                        {
                            chkInserirCliente.Checked = true;
                        }
                        else
                        {
                            chkInserirCliente.Checked = false;
                        }
                        if (permissoes.alterar_cliente == "S")
                        {
                            chkAlterarCliente.Checked = true;
                        }
                        else
                        {
                            chkAlterarCliente.Checked = false;
                        }
                        if (permissoes.pesquisar_cliente == "S")
                        {
                            chkPesquisaCliente.Checked = true;
                        }
                        else
                        {
                            chkPesquisaCliente.Checked = false;
                        }
                        if (permissoes.cad_produto == "S")
                        {
                            chkProduto.Checked = true;
                        }
                        else
                        {
                            chkProduto.Checked = false;
                        }
                        if (permissoes.inserir_produto == "S")
                        {
                            chkInserirProd.Checked = true;
                        }
                        else
                        {
                            chkInserirProd.Checked = false;
                        }
                        if (permissoes.alterar_produto == "S")
                        {
                            chkAlterarProd.Checked = true;
                        }
                        else
                        {
                            chkAlterarProd.Checked = false;
                        }
                        if (permissoes.pesquisar_produto == "S")
                        {
                            chkPesquisarProd.Checked = true;
                        }
                        else
                        {
                            chkPesquisarProd.Checked = false;
                        }
                        if (permissoes.cad_usuario == "S")
                        {
                            chkUsuario.Checked = true;
                        }
                        else
                        {
                            chkUsuario.Checked = false;
                        }
                        if (permissoes.inserir_usuario == "S")
                        {
                            chkInserirUser.Checked = true;
                        }
                        else
                        {
                            chkInserirUser.Checked = false;
                        }
                        if (permissoes.alterar_usuario == "S")
                        {
                            chkAlterarUser.Checked = true;
                        }
                        else
                        {
                            chkAlterarUser.Checked = false;
                        }
                        if (permissoes.pesquisar_usuario == "S")
                        {
                            chkVisualizar.Checked = true;
                        }
                        else
                        {
                            chkVisualizar.Checked = false;
                        }
                        HabilitarChecks();
                        btnSalvar.Enabled = true;
                    }
                    if (permissoes.cad_cliente == "S")
                    {
                        chkCliente.Checked = true;
                    }
                    else
                    {
                        chkCliente.Checked = false;
                    }
                    if (permissoes.inserir_cliente == "S")
                    {
                        chkInserirCliente.Checked = true;
                    }
                    else
                    {
                        chkInserirCliente.Checked = false;
                    }
                    if (permissoes.alterar_cliente == "S")
                    {
                        chkAlterarCliente.Checked = true;
                    }
                    else
                    {
                        chkAlterarCliente.Checked = false;
                    }
                    if (permissoes.pesquisar_cliente == "S")
                    {
                        chkPesquisaCliente.Checked = true;
                    }
                    else
                    {
                        chkPesquisaCliente.Checked = false;
                    }
                    if (permissoes.cad_produto == "S")
                    {
                        chkProduto.Checked = true;
                    }
                    else
                    {
                        chkProduto.Checked = false;
                    }
                    if (permissoes.inserir_produto == "S")
                    {
                        chkInserirProd.Checked = true;
                    }
                    else
                    {
                        chkInserirProd.Checked = false;
                    }
                    if (permissoes.alterar_produto == "S")
                    {
                        chkAlterarProd.Checked = true;
                    }
                    else
                    {
                        chkAlterarProd.Checked = false;
                    }
                    if (permissoes.pesquisar_produto == "S")
                    {
                        chkPesquisarProd.Checked = true;
                    }
                    else
                    {
                        chkPesquisarProd.Checked = false;
                    }
                    if (permissoes.cad_usuario == "S")
                    {
                        chkUsuario.Checked = true;
                    }
                    else
                    {
                        chkUsuario.Checked = false;
                    }
                    if (permissoes.inserir_usuario == "S")
                    {
                        chkInserirUser.Checked = true;
                    }
                    else
                    {
                        chkInserirUser.Checked = false;
                    }
                    if (permissoes.alterar_usuario == "S")
                    {
                        chkAlterarUser.Checked = true;
                    }
                    else
                    {
                        chkAlterarUser.Checked = false;
                    }
                    if (permissoes.pesquisar_usuario == "S")
                    {
                        chkVisualizar.Checked = true;
                    }
                    else
                    {
                        chkVisualizar.Checked = false;
                    }
                    HabilitarChecks();
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para visualizar as permissões dos usuários.", "Cadastro de usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var permissao = dalUsuario.VerificarPermissoes(nomeUser);
            if (permissao.alterar_usuario == "S")
            {
                var permissoes = new dtoPermissoes();

                if (chkCliente.Checked)
                {
                    permissoes.cad_cliente = "S";
                }
                else
                {
                    permissoes.cad_cliente = "N";
                }
                if (chkInserirCliente.Checked)
                {
                    permissoes.inserir_cliente = "S";
                }
                else
                {
                    permissoes.inserir_cliente = "N";
                }
                if (chkPesquisaCliente.Checked)
                {
                    permissoes.pesquisar_cliente = "S";
                }
                else
                {
                    permissoes.pesquisar_cliente = "N";
                }
                if (chkAlterarCliente.Checked)
                {
                    permissoes.alterar_cliente = "S";
                }
                else
                {
                    permissoes.alterar_cliente = "N";
                }
                if (chkProduto.Checked)
                {
                    permissoes.cad_produto = "S";
                }
                else
                {
                    permissoes.cad_produto = "N";
                }
                if (chkInserirProd.Checked)
                {
                    permissoes.inserir_produto = "S";
                }
                else
                {
                    permissoes.inserir_produto = "N";
                }
                if (chkPesquisarProd.Checked)
                {
                    permissoes.pesquisar_produto = "S";
                }
                else
                {
                    permissoes.pesquisar_produto = "N";
                }
                if (chkAlterarProd.Checked)
                {
                    permissoes.alterar_produto = "S";
                }
                else
                {
                    permissoes.alterar_produto = "N";
                }
                if (chkUsuario.Checked)
                {
                    permissoes.cad_usuario = "S";
                }
                else
                {
                    permissoes.cad_usuario = "N";
                }
                if (chkInserirUser.Checked)
                {
                    permissoes.inserir_usuario = "S";
                }
                else
                {
                    permissoes.inserir_usuario = "N";
                }
                if (chkVisualizar.Checked)
                {
                    permissoes.pesquisar_usuario = "S";
                }
                else
                {
                    permissoes.pesquisar_usuario = "N";
                }
                if (chkAlterarUser.Checked)
                {
                    permissoes.alterar_usuario = "S";
                }
                else
                {
                    permissoes.alterar_usuario = "N";
                }
                permissoes.Nome = nome_permissao;

                if (dalUsuario.AlterarPermissoes(permissoes))
                {
                    MessageBox.Show("Permissões salvas com sucesso.", "Usuário", MessageBoxButtons.OK);
                    DesabilitarChecks();
                    cbUsuarios.SelectedIndex = -1;
                    return;
                }
                else
                {
                    MessageBox.Show("Erro inesperado. Por favor tente novamente e/ou verifique sua conexão.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para alterar as permissão de usuários.", "Cadastro de usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void chkCliente_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkCliente.Checked)
            {
                chkInserirCliente.Enabled = true;
                chkAlterarCliente.Enabled = true;
                chkPesquisaCliente.Enabled = true;
            }
            else
            {
                chkInserirCliente.Enabled = false;
                chkAlterarCliente.Enabled = false;
                chkPesquisaCliente.Enabled = false;
                chkInserirCliente.Checked = false;
                chkAlterarCliente.Checked = false;
                chkPesquisaCliente.Checked = false;
            }
        }

        private void chkProduto_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkProduto.Checked)
            {
                chkInserirProd.Enabled = true;
                chkPesquisarProd.Enabled = true;
                chkAlterarProd.Enabled = true;
            }
            else
            {
                chkInserirProd.Enabled = false;
                chkPesquisarProd.Enabled = false;
                chkAlterarProd.Enabled = false;
                chkInserirProd.Checked = false;
                chkPesquisarProd.Checked = false;
                chkAlterarProd.Checked = false;
            }
        }

        private void chkUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkUsuario.Checked)
            {
                chkInserirUser.Enabled = true;
                chkAlterarUser.Enabled = true;
                chkVisualizar.Enabled = true;
            }
            else
            {
                chkInserirUser.Enabled = false;
                chkAlterarUser.Enabled = false;
                chkVisualizar.Enabled = false;
                chkInserirUser.Checked = false;
                chkAlterarUser.Checked = false;
                chkVisualizar.Checked = false;
            }
        }
    }
}
