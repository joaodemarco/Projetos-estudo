using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DTO
{
    public class dtoProduto
    {
        public int Id { get; set; }
        public int CodBarras { get; set; }
        public string Descricao { get; set; }
        public string CFOP { get; set; }
        public string Fornecedor { get; set; }
        public string Marca { get; set; }
        public string Unidade { get; set; }
        public decimal PrCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public string Departamento { get; set; }
        public string Complemento { get; set; }
    }
}
