using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DTO
{
    internal class dtoVendas
    {
        public int numero { get; set; }
        public string CodCliente { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataFechamento { get; set; }
        public float ValorTotal { get; set; }
        public float DescontoGeral { get; set; }
        public float DescontoProdutos {  get; set; }
        public string FormaPgto {  get; set; }
        public char StatusVenda { get; set; }
        public string Usuario { get; set; }
        public string CodIDProdutos {  get; set; }
        public string Observacao {  get; set; }
    }
}
