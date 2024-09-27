using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroCliente.Fontes
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios(string nomeUsuario)
        {
            InitializeComponent();
        }
        public void VerificarRelatorio()
        {
            if(cbRelatorios.SelectedIndex == 0)
            {
                btnVisualizar.Enabled = true;
            }
            if (cbRelatorios.SelectedIndex == 1)
            {
                btnVisualizar.Enabled = true;
            }
            if (cbRelatorios.SelectedIndex == 2)
            {
                btnVisualizar.Enabled = true;
            }
        }

        private void btnVisualizar_Click(object sender, System.EventArgs e)
        {
            if (cbRelatorios.SelectedIndex == 0)
            {
                Dictionary<string, string> datasource = new Dictionary<string, string>();
                datasource.Add("dbo_Cliente", "select * from cliente");
                Dictionary<string, string> parametros = new Dictionary<string, string>();
                parametros.Add("", "");
                Fontes.Úteis.Relatório.FastReport.ExibirRelatorio("relClientes", datasource, parametros, "Relatório de clientes");
            }
            
            if (cbRelatorios.SelectedIndex == 1)
            {
                Dictionary<string, string> datasource = new Dictionary<string, string>();
                datasource.Add("dbo_Produto", "select * from produto");
                Dictionary<string, string> parametros = new Dictionary<string, string>();
                parametros.Add("", "");
                Fontes.Úteis.Relatório.FastReport.ExibirRelatorio("relProdutos", datasource, parametros, "Relatório de produtos");
            }
            if (cbRelatorios.SelectedIndex == 2)
            {
                Dictionary<string, string> datasource = new Dictionary<string, string>();
                datasource.Add("relatorio", "select u.senha, u.DATA_CRIACAO, pu.* from usuario u left join permissao_usuario pu on u.ID = pu.ID");
                Dictionary<string, string> parametros = new Dictionary<string, string>();
                parametros.Add("", "");
                Fontes.Úteis.Relatório.FastReport.ExibirRelatorio("relUsuarios", datasource, parametros, "Relatório de usuários");
            }
        }

        private void cbRelatorios_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            VerificarRelatorio();
        }
    }
}
