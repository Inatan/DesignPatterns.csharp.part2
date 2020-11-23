using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.csharp.part2.Cap1
{
    class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meuBanco";
            conexao.Open();

            return conexao;
        }
    }
}
