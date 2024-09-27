using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DTO
{
    public class dtoPermissoes
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string cad_cliente { get; set; }
        public string inserir_cliente { get; set; }
        public string alterar_cliente { get; set; }
        public string pesquisar_cliente {  get; set; }
        public string cad_produto { get; set; }
        public string inserir_produto { get; set; }
        public string alterar_produto { get; set; }
        public string pesquisar_produto { get; set;}
        public string cad_usuario { get; set; }
        public string inserir_usuario { get; set;}
        public string alterar_usuario { get; set; }
        public string pesquisar_usuario { get; set;}

    }
}
