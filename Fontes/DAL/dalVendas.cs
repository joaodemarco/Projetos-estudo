using CadastroCliente.Fontes.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CadastroCliente.Fontes.DAL
{
    internal class dalVendas
    {
        public static int InserirVenda1(dtoVendas venda)
        {
            var sql = "insert into vendas (CodCliente, DataEmissao, Observacao, UsuarioLancamento, StatusVenda) " +
                "values (@codcliente, @dataemissao, @observacao, @usuario, 'P'); select cast (SCOPE_IDENTITY() as int);";
            var parametros = new
            {
                codcliente = venda.CodCliente,
                dataemissao = venda.DataEmissao,
                observacao = venda.Observacao,
                usuario = venda.Usuario,
            };
            try
            {
                using (var conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    var numerovenda = conexao.QuerySingle<int>(sql, parametros);
                    return numerovenda;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro processar venda: {erro.Message}");
                return -1;
            }
        }
        public static int PesquisarItem(string numeroVenda)
        {
            var sql = $"select Item from detalhevendas where Numero = @numero";
            int Item = dalConexao.CNN.Query<int>(sql, new { numero = numeroVenda }).LastOrDefault();
            return Item;
        }

        public static int PesquisarItemPorID(string numerovenda, string id)
        {
            var sql = $"select Item from detalhevendas where Numero = @numero and CodigoProdutoID = @codigoprodutoid";
            var parametros = new
            {
                numero = numerovenda,
                codigoprodutoid = id
            };
            int item = dalConexao.CNN.Query<int>(sql, parametros).FirstOrDefault();
            return item;
        }

        public static bool DetalheVenda(dtoDetalheVendas detalheproduto)
        {
            var sql = $"insert into detalhevendas (Numero, Item, CodigoProdutoID, Descricao, Preco, Quantidade, Desconto, Total, DataLancamento, " +
                $"Unidade, CFOP, Fornecedor, Marca, PrCusto, Departamento, Complemento, Excluido) values (@numero, @item, @codigoprodutoid, @descricao," +
                $" @preco, @quantidade, @desconto, @total, GETDATE(), @unidade, @cfop, @fornecedor, @marca, @prcusto, @departamento, @complemento," +
                $" 'N')";
            var parametros = new
            {
                numero = detalheproduto.Numero,
                item = detalheproduto.Item,
                codigoprodutoid = detalheproduto.CodigoProdutoID,
                descricao = detalheproduto.Descricao,
                preco = detalheproduto.Preco,
                quantidade = detalheproduto.Quantidade,
                desconto = detalheproduto.Desconto,
                total = detalheproduto.Total,
                unidade = detalheproduto.Unidade,
                cfop = detalheproduto.CFOP,
                fornecedor = detalheproduto.Fornecedor,
                marca = detalheproduto.Marca,
                prcusto = detalheproduto.PrCusto,
                departamento = detalheproduto.Departamento,
                complemento = detalheproduto.Complemento
            };
            try
            {
                using (var conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    conexao.Execute(sql, parametros);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao processar lançamento de produto: {ex.Message}");
                return false;
            }
        }
        public static List<dtoDetalheVendas> AtualizarDataGrid(string numerovenda)
        {
            var sql = "select * from detalhevendas where Excluido = 'N' and Numero = @numerovenda";
            var parametros = new
            {
                numerovenda = numerovenda,
            };
            return dalConexao.CNN.Query<dtoDetalheVendas>(sql, parametros).ToList();
        }

        public static bool AtualizarProduto(dtoDetalheVendas detalheproduto)
        {
            var sql = "update detalhevendas set Descricao = @descricao, Preco = @preco, Quantidade = @quantidade, Desconto = @desconto, Total = @total, Unidade = @unidade where Numero = @numero and Item = @item";
            var parametros = new
            {
                numero = detalheproduto.Numero,
                item = detalheproduto.Item,
                descricao = detalheproduto.Descricao,
                preco = detalheproduto.Preco,
                quantidade = detalheproduto.Quantidade,
                desconto = detalheproduto.Desconto,
                total = detalheproduto.Total,
                unidade = detalheproduto.Unidade,
            };
            try
            {
                using (var conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    conexao.Execute(sql, parametros);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao alterar produto: {ex.Message}");
                return false;
            }
        }

        public static dtoDetalheVendas PesquisarProduto(string numerovenda, string id)
        {
            var sql = $"select * from detalhevendas where Numero = @numerovenda and CodigoProdutoID = @codigoprodutoid and Excluido = 'N'";
            var parametros = new
            {
                numerovenda = numerovenda,
                codigoprodutoid = id
            };
            try
            {
                using (var conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    var resultado = conexao.QueryFirst<dtoDetalheVendas>(sql, parametros);
                    return resultado;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao buscar produto: {erro.Message}");
                return null;
            }
        }

        public static bool ExcluirLançamento(string numerovenda, string id)
        {
            var sql = $"update detalhevendas set Excluido = 'S' where CodigoProdutoID = @id and Numero = @numerovenda";
            var parametros = new
            {
                id = id,
                numerovenda = numerovenda
            };
            try
            {
                using (var conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    conexao.Execute(sql, parametros);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static decimal TotalGeral(string numerovenda)
        {
            var sql = $"select SUM(Total) from detalhevendas where Excluido = 'N' and Numero = @numerovenda";
            var parametros = new
            {
                numerovenda = numerovenda,
            };
            try
            {
                using (SqlConnection conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    var totalgeral = conexao.QuerySingleOrDefault<decimal>(sql, parametros);
                    return totalgeral;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao somar os valores dos produtos: {ex.Message}");
                return 0;
            }
        }
        public static bool FinalizarVenda(string numerovenda, string valortotal, string descontogeral, string tipodescontogeral, string descontoprodutos, string valorfinal, string formapgto, string usuario)
        {
            var sql = @"update vendas set DataFechamento = GETDATE(), ValorTotal = @valortotal, DescontoGeral = @descontogeral, 
            TipoDescontoGeral = @tipodescontogeral, DescontoProdutos = @descontoprodutos, ValorFinal = @valorfinal, FormaPgto = @formapgto, StatusVenda = 'E', UsuarioFinalizacao = @usuario where Numero = @numerovenda";
            var parametros = new
            {
                valortotal = valortotal,
                descontogeral = descontogeral,
                tipodescontogeral = tipodescontogeral,
                descontoprodutos = descontoprodutos,
                valorfinal = valorfinal,
                formapgto = formapgto,
                usuario = usuario,
                numerovenda = numerovenda
            };
            try
            {
                using (SqlConnection conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123;"))
                {
                    conexao.Open();
                    conexao.Execute(sql, parametros);
                    return true;
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine($"Erro ao finalizar venda: {erro.Message}");
                return false;
            }
        }

        public static decimal DescontoProdutos(string numerovenda)
        {
            var sql = $"select SUM(Desconto) from detalhevendas where Numero = @numerovenda and Excluido = 'N'";
            var parametros = new
            {
                numerovenda = numerovenda
            };
            try
            {
                using (SqlConnection conexao = new SqlConnection(dalConexao.CNN.ConnectionString + ";Password=190123"))
                {
                    conexao.Open();
                    var descontoprodutos = conexao.QuerySingleOrDefault<decimal>(sql, parametros);
                    return descontoprodutos;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao obter desconto dos produtos: {ex.Message}");
                return 0;
            }
        }      
    }
}
