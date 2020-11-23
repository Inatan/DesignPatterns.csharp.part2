using DesignPatterns.csharp.part2.Cap1;
using DesignPatterns.csharp.part2.Cap2;
using System.Collections.Generic;
using System.Data;

namespace DesignPatterns.csharp.part2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cap 1 Factory
            //IDbConnection conexao = new ConnectionFactory().GetConnection();

            //IDbCommand comando = conexao.CreateCommand();
            //comando.CommandText = "select * from tabela";

            NotasMusicais notas = new NotasMusicais();
            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa"),
            };
            Piano piano = new Piano();
            piano.Toca(musica);


        }
    }
}
