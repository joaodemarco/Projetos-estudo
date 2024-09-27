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
    public partial class frmInfUser : Form
    {
        public frmInfUser()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "" || txtConfirmSenha.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtSenha.Text != txtConfirmSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem, por favor verifique.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtSenha.Text.Length < 3)
            {
                MessageBox.Show("A senha não pode ter menos que 3 caracteres.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usuarios = dalUsuario.PesquisarUsuario();
            foreach (var usuar in usuarios)
            {
                if (usuar.NOME == txtNome.Text)
                {
                    MessageBox.Show("Já existe um usuário com esse nome no sistema.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }


            dtoUsuario usuario = new dtoUsuario();
            usuario.NOME = txtNome.Text;
            usuario.SENHA = txtSenha.Text;

            if (dalUsuario.IncluirUsuario(usuario.NOME, usuario.SENHA))
            {
                dalUsuario.InserirPermissoes(usuario.NOME);
                txtNome.Text = "";
                txtSenha.Text = "";
                txtConfirmSenha.Text = "";
                MessageBox.Show("Cadastro salvo com sucesso!", "Usuário", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }    
            
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtConfirmSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
