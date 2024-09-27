using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DTO
{
    internal class dtoDetalheVendas
    {
        public string Numero {  get; set; }
        public int Item {  get; set; }
        public int CodigoProdutoID { get; set; }
        public string Descricao { get; set; }
        public decimal Preco {  get; set; }
        public decimal Quantidade { get; set; }
        public decimal Desconto {  get; set; }
        public decimal Total { get; set; }
        public DateTime DataLancamento { get; set; }
        public string Unidade {  get; set; }
        public string CFOP { get; set; }
        public string Fornecedor {  get; set; }
        public string Marca { get; set; }
        public decimal PrCusto {  get; set; }
        public string Departamento { get; set; }
        public string Complemento {  get; set; }
        public char Excluido { get; set; }
    }
}
