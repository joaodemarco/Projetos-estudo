using CadastroCliente.Fontes.DTO;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroCliente.Fontes.API
{
    internal class viaCep
    {
        public static readonly RestClient restClient = new RestClient("https://viacep.com.br/ws/");
        public async Task<dtoEndereco> BuscarCep(string cep)
        {
            if (string.IsNullOrEmpty(cep) || cep.Length != 9)
            {
                MessageBox.Show("Por favor, insira um CEP válido de 8 dígitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }

            try
            {
                var request = new RestRequest($"{cep}/json/", Method.Get);
                RestResponse response = await restClient.ExecuteAsync(request);

                if (!response.IsSuccessful)
                {
                    MessageBox.Show("Erro ao consultar CEP.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }

                dtoEndereco endereco = JsonConvert.DeserializeObject<dtoEndereco>(response.Content);

                if (endereco == null || endereco.logradouro == null || endereco.cep == null)
                {
                    MessageBox.Show("CEP não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }

                return endereco;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro inesperado: {erro.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
