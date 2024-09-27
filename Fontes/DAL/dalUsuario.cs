using CadastroCliente.Fontes.DTO;
using Dapper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DAL
{
    public class dalUsuario
    {
        public static dtoUsuario ConsultarUsuario(string NOME, string SENHA)
        {
            var ssql = $"select * from usuario where NOME = @nome and SENHA = @senha";
            var usuario = dalConexao.CNN.Query<dtoUsuario>(ssql, new { nome = NOME, senha = SENHA }).FirstOrDefault();
            return usuario;
        }

        public static dtoUsuario ConsultarUsuario2(string NOME)
        {
            var ssql = $"select * from usuario where NOME = @nome";
            var usuario = dalConexao.CNN.Query<dtoUsuario>(ssql, new { nome = NOME}).FirstOrDefault();
            return usuario;
        }

        public static List<dtoUsuario> PesquisarUsuario()
        {
            var sql = "select * from usuario";
            var usuario = dalConexao.CNN.Query<dtoUsuario>(sql).ToList();
            return usuario;
        }

        public static bool IncluirUsuario(string NOME, string SENHA)
        {
            var sql = $"insert into usuario (NOME, SENHA, DATA_CRIACAO) values (@nome, @senha, GETDATE())";
            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {
                cmd.Parameters.AddWithValue("@nome", NOME);
                cmd.Parameters.AddWithValue("@senha", SENHA);
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
        public static bool InserirPermissoes(string NOME)
        {
            var sql = $"insert into permissao_usuario (Nome, cad_cliente, inserir_cliente, alterar_cliente, pesquisar_cliente, cad_produto, " +
                $"inserir_produto, alterar_produto, pesquisar_produto, cad_usuario, inserir_usuario, alterar_usuario, pesquisar_usuario) values " +
                $"(@nome, 'N', 'N', 'N','N','N','N','N','N','N','N','N','N')";
            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {
                cmd.Parameters.AddWithValue("@nome", NOME);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception erro)
                {
                    Console.WriteLine(erro.Message);
                    return false;
                }

            }
        }
        public static bool AlterarSenha(string SENHA, string NOME)
        {
            var sql = $"update usuario set SENHA = @senha where NOME = @nome";
            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {
                cmd.Parameters.AddWithValue("@senha", SENHA);
                cmd.Parameters.AddWithValue("@nome", NOME);
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception erro)
                {
                    Console.WriteLine(erro.Message);
                    return false;
                }
            }
        }
        public static dtoPermissoes VerificarPermissoes(string NOME)
        {
            var sql = $"select * from permissao_usuario where Nome = @nome";
            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {
                var parametros = new
                {
                    nome = NOME
                };

                var permissoes = dalConexao.CNN.Query<dtoPermissoes>(sql, parametros).FirstOrDefault();
                return permissoes;
            }
        }
        public static bool AlterarPermissoes(dtoPermissoes permissoes)
        {
            if (dalConexao.CNN == null || dalConexao.CNN.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Conexão inválida ou não aberta.");
                return false;
            }
            var sql = $"update permissao_usuario set cad_cliente = @cad_cliente, inserir_cliente = @inserir_cliente, alterar_cliente = @alterar_cliente, " +
                $"pesquisar_cliente = @pesquisar_cliente, cad_produto = @cad_produto, inserir_produto = @inserir_produto, alterar_produto = @alterar_produto, " +
                $"pesquisar_produto = @pesquisar_produto, cad_usuario = @cad_usuario, inserir_usuario = @inserir_usuario, alterar_usuario = @alterar_usuario, " +
                $"pesquisar_usuario = @pesquisar_usuario where Nome = @nome";
            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {
                var parametros = new
                {
                    cad_cliente = permissoes.cad_cliente,
                    inserir_cliente = permissoes.inserir_cliente,
                    alterar_cliente = permissoes.alterar_cliente,
                    pesquisar_cliente = permissoes.pesquisar_cliente,
                    cad_produto = permissoes.cad_produto,
                    inserir_produto = permissoes.inserir_produto,
                    alterar_produto = permissoes.alterar_produto,
                    pesquisar_produto = permissoes.pesquisar_produto,
                    cad_usuario = permissoes.cad_usuario,
                    inserir_usuario = permissoes.inserir_usuario,
                    alterar_usuario = permissoes.alterar_usuario,
                    pesquisar_usuario = permissoes.pesquisar_usuario,
                    nome = permissoes.Nome
                };
                try
                {
                    int rowsAffected = dalConexao.CNN.Execute(sql, parametros);

                    return rowsAffected > 0;
                }
                catch (Exception erro)
                {
                    Console.WriteLine($"Erro ao alterar permissões: {erro.Message}");
                    return false;
                }
            }
        }
    }
}
