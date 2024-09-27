using CadastroCliente.Fontes.DAL;
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
    public partial class frmAlterarUser : Form
    {
        private static string _nome;
        public frmAlterarUser(string nome)
        {
            InitializeComponent();
            _nome = nome;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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
            var usuario = dalUsuario.ConsultarUsuario2(_nome);
            if (usuario.SENHA == txtSenha.Text)
            {
                MessageBox.Show("Essa já é a senha desse usuário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dalUsuario.AlterarSenha(txtSenha.Text, _nome))
            {
                txtSenha.Text = "";
                txtConfirmSenha.Text = "";
                MessageBox.Show("Senha alterada com sucesso.", "Usuário", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro inesperado.", "Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
