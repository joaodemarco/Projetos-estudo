using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DTO
{
    public class dtoCliente
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Logradouro { get; set; }
        public string Endereco { get; set; }
        public int NumeroEndereco { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Tipo { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; } 
        public string Observacao { get; set; }
    }
}
