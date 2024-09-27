using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroCliente.Fontes.DAL
{
    public class dalConexao
    {
        public static SqlConnection CNN {  get; set; }

        public static bool Conectar(string IP, string nomeBanco, string login, string senha)
        {
            try
            {
                CNN = new SqlConnection();
                CNN.ConnectionString = $"Server={IP};Database={nomeBanco};User Id={login};Password={senha};";
                CNN.Open();
                return true;
            }
            catch (Exception erro)
            {
                return false;
            }
        }

        public static bool Desconectar()
        {
            if (CNN.State == ConnectionState.Open)
            {
                CNN.Close();
                return true;
            }
            return false;
        }
    }
}
