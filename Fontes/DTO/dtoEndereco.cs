using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DTO
{
    internal class dtoEndereco
    {
        public string cep {  get; set; }
        public string logradouro {  get; set; }
        public string complemento {  get; set; }
        public string unidade { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string estado {  get; set; }
        public string ddd { get; set; }
    }
}
