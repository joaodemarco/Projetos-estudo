using CadastroCliente.Fontes.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DAL
{
    internal class dalCliente
    {
        public static bool InserirUsuario(dtoCliente cliente)
        {
            var csql = "insert into cliente (Nome, Fantasia, Logradouro, Endereco, NumeroEndereco, " +
                "Bairro, Estado, Cidade, Tipo, CPF, CNPJ, Telefone, Celular, Email, Observacao, CEP)" +
                "values (@nome, @fantasia, @logradouro, @endereco, @numeroendereco, @bairro, " +
                "@estado, @cidade, @tipo, @cpf, @cnpj, @telefone, @celular, @email, @observacao, @cep)";
            using (SqlCommand cmd = new SqlCommand(csql, dalConexao.CNN))
            {
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@fantasia", cliente.Fantasia);
                cmd.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@numeroendereco", cliente.NumeroEndereco);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@tipo", cliente.Tipo);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("@cnpj", cliente.CNPJ);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.Parameters.AddWithValue("@observacao", cliente.Observacao);
                cmd.Parameters.AddWithValue("@cep", cliente.CEP);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                    return false;
                }
            }
        }

        public static dtoCliente PesquisarCliente(int Id)
        {
            var sql = $"select * from cliente where ID = @id";
            var clientePesquisa = dalConexao.CNN.Query<dtoCliente>(sql, new { id = Id }).FirstOrDefault();
            return clientePesquisa;
        }
        public static List<dtoCliente> Pesquisar(string Tipo, string inf)
        {
            var psql = $"select * from cliente";

            switch (Tipo)
            {
                case "ID":
                    psql += " where ID like @filtro";
                    break;
                case "Nome":
                    psql += " where Nome like @filtro";
                    break;
                case "Cidade":
                    psql += " where Cidade like @filtro";
                    break;
                case "Tipo":
                    psql += " where Tipo like @filtro";
                    break;
                case "CPF":
                    psql += " where CPF like @filtro";
                    break;
                case "CNPJ":
                    psql += " where CNPJ like @filtro";
                    break;
                case "Telefone":
                    psql += " where Celular like @filtro";
                    break;
                case "Celular":
                    psql += " where Celular like @filtro";
                    break;
                case "Email":
                    psql += " where Email like @filtro";
                    break;
            }

            return dalConexao.CNN.Query<dtoCliente>(psql, new { filtro = $"%{inf}%" }).ToList();
        }
        public static bool AlterarCadastro(dtoCliente cliente)
        {
            if (dalConexao.CNN == null || dalConexao.CNN.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Conexão inválida ou não aberta.");
                return false;
            }

            var asql = "UPDATE cliente SET Nome = @Nome, Fantasia = @Fantasia, Logradouro = @Logradouro, Endereco = @Endereco, " +
                       "NumeroEndereco = @NumeroEndereco, Bairro = @Bairro, Estado = @Estado, Cidade = @Cidade, CEP = @Cep, Tipo = @Tipo, " +
                       "CPF = @CPF, CNPJ = @CNPJ, Telefone = @Telefone, Celular = @Celular, Email = @Email, Observacao = @Observacao " +
                       "WHERE Id = @Id";

            using (SqlCommand cmd = new SqlCommand(asql, dalConexao.CNN))
            {
                cmd.Parameters.AddWithValue("@Id", cliente.ID);
                cmd.Parameters.AddWithValue("@Nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@Fantasia", cliente.Fantasia);
                cmd.Parameters.AddWithValue("@Logradouro", cliente.Logradouro);
                cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@NumeroEndereco", cliente.NumeroEndereco);
                cmd.Parameters.AddWithValue("@Bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@Estado", cliente.Estado);
                cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@Tipo", cliente.Tipo);
                cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                cmd.Parameters.AddWithValue("@CNPJ", cliente.CNPJ);
                cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@Celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@Email", cliente.Email);
                cmd.Parameters.AddWithValue("@Observacao", cliente.Observacao);
                cmd.Parameters.AddWithValue("@Cep", cliente.CEP);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                    return false;
                }
            }
        }
    }
}
