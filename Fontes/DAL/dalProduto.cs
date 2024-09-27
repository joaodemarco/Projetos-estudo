using CadastroCliente.Fontes.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.Fontes.DAL
{
    internal class dalProduto
    {
        public static bool InserirProduto(dtoProduto produto)
        {
            var sql = "insert into Produto (CodBarras, Descricao, CFOP, Fornecedor, Marca, Unidade, PrCompra, ValorVenda, Departamento," +
                "Complemento) values (@CodBarras, @Descricao, @CFOP, @Fornecedor, @Marca, @Unidade, @PrCompra, @ValorVenda, @Departamento" +
                ", @Complemento)";
            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {
                cmd.Parameters.AddWithValue("@CodBarras", produto.CodBarras);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@CFOP", produto.CFOP);
                cmd.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                cmd.Parameters.AddWithValue("@Unidade", produto.Unidade);
                cmd.Parameters.AddWithValue("@PrCompra", produto.PrCompra);
                cmd.Parameters.AddWithValue("@ValorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@Departamento", produto.Departamento);
                cmd.Parameters.AddWithValue("@Complemento", produto.Complemento);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception erro)
                {
                    return false;
                }
            }
        }
        
        public static List <dtoProduto> Pesquisar(string Tipo, string inf)
        {
            var sql = "select * from produto";

            switch (Tipo)
            {
                case "Id":
                    sql += " where Id like @filtro";
                    break;
                case "CodBarras":
                    sql += " where CodBarras like @filtro";
                    break;
                case "Descricao":
                    sql += " where Descricao like @filtro ";
                    break;
                case "Fornecedor":
                    sql += " where Fornecedor like @filtro";
                    break;
                case "Marca":
                    sql += " where Marca like @filtro";
                    break;
                case "Departamento":
                    sql += " where Departamento like @filtro";
                    break;
            }
            return dalConexao.CNN.Query<dtoProduto>(sql, new { filtro = $"%{inf}%"}).ToList();
        }

        public static dtoProduto PesquisarProdutoID(int ID)
        {
            var sql = "select * from produto where Id = @id";
            var produtoPesquisa = dalConexao.CNN.Query<dtoProduto>(sql, new { id = ID }).FirstOrDefault();
            return produtoPesquisa;
        }
        public static bool AlterarCadastro(dtoProduto produto)
        {
            if (dalConexao.CNN == null || dalConexao.CNN.State != System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Conexão inválida ou não aberta.");
                return false;
            }
            var sql = "update produto set CodBarras = @CodBarras, Descricao = @Descricao, CFOP = @Cfop, Fornecedor = @Fornecedor, Marca = @Marca" +
                ", Unidade = @Unidade, PrCompra = @PrCompra, ValorVenda = @Valorvenda, Departamento = @Departamento, Complemento = @Complemento where Id = @Id";

            using (SqlCommand cmd = new SqlCommand(sql, dalConexao.CNN))
            {

                cmd.Parameters.AddWithValue("@Id", produto.Id);
                cmd.Parameters.AddWithValue("@Descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("CodBarras", produto.CodBarras);
                cmd.Parameters.AddWithValue("@Cfop", produto.CFOP);
                cmd.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                cmd.Parameters.AddWithValue("@Unidade", produto.Unidade);
                cmd.Parameters.AddWithValue("@PrCompra", produto.PrCompra);
                cmd.Parameters.AddWithValue("@ValorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@Departamento", produto.Departamento);
                cmd.Parameters.AddWithValue("@Complemento", produto.Complemento);

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
