using FastReport;
using FastReport.Data;
using FastReport.Preview;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroCliente.Fontes.Úteis.Relatório
{
    public class FastReport
    {
        public static void ExibirRelatorio(string nome_relatorio, Dictionary<string, string> data_source, Dictionary<string, string> parametros, string tipo_relatorio)
        {
            string pasta_executavel = AppDomain.CurrentDomain.BaseDirectory;
            string caminho_relatorio = $@"{pasta_executavel}/Relatórios/{nome_relatorio}.frx";

            var relatorio = new Report();
            relatorio.Load(caminho_relatorio);

            var previsualizacao_relatorio = new PreviewControl();
            previsualizacao_relatorio.Dock = DockStyle.Fill;

            var formulario_exibicao_relatorio = new Form();
            var recursos = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            formulario_exibicao_relatorio.WindowState = FormWindowState.Maximized;
            formulario_exibicao_relatorio.StartPosition = FormStartPosition.CenterScreen;
            formulario_exibicao_relatorio.Text = tipo_relatorio;
            formulario_exibicao_relatorio.Icon = ((System.Drawing.Icon)(recursos.GetObject("$this.Icon")));
            formulario_exibicao_relatorio.Controls.Add(previsualizacao_relatorio);
            formulario_exibicao_relatorio.ShowIcon = true;

            foreach (var item in data_source)
            {
                var tabela_relatorio = relatorio.GetDataSource($"{item.Key}") as TableDataSource;
                tabela_relatorio.SelectCommand = $"{item.Value}";
            }

            foreach (var item in parametros)
            {
                relatorio.SetParameterValue(item.Key, item.Value);
            }

            relatorio.Preview = previsualizacao_relatorio;
            relatorio.Prepare();
            relatorio.ShowPrepared();

            formulario_exibicao_relatorio.ShowDialog();
        }
    }
}
