using CadastroCliente.Fontes.DAL;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace CadastroCliente
{
    public partial class frmLogin : Form
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int HeightEllipse);

        public static bool LoginBemSucedido { get; private set; } = false;
        public string nomeLogin { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
            if (!dalConexao.Conectar("127.0.0.1", "SistemaLogin", "SisLogin", "190123"))
            {
                MessageBox.Show("Não foi possível estabelecer a conexão.");
                Environment.Exit(0);
            }
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 && txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Preencha os campos para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtUsuario.Text.Length == 0)
            {
                MessageBox.Show("Preencha o campo usuário para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSenha.Text.Length == 0)
            {
                MessageBox.Show("Preencha o campo senha para continuar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var usuario = dalUsuario.ConsultarUsuario(txtUsuario.Text, txtSenha.Text);
            if (usuario == null)
            {
                MessageBox.Show("Nome ou senha incorretos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Text = "";
                return;
            }
            else
            {
                LoginBemSucedido = true;
                nomeLogin = txtUsuario.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!LoginBemSucedido)
            {
                Environment.Exit(0);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
    }
}
