﻿using DesignPatterns.csharp.part2.Cap1;
using DesignPatterns.csharp.part2.Cap2;
using DesignPatterns.csharp.part2.Cap3;
using DesignPatterns.csharp.part2.Cap4;
using DesignPatterns.csharp.part2.Cap5;
using DesignPatterns.csharp.part2.Cap6;
using DesignPatterns.csharp.part2.Cap7;
using DesignPatterns.csharp.part2.Cap8;
using DesignPatterns.csharp.part2.Cap9;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq.Expressions;
using System.Xml.Serialization;

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

            // Cap 2 Flyweight
            //NotasMusicais notas = new NotasMusicais();
            //IList<INota> musica = new List<INota>()
            //{
            //    notas.Pega("do"),
            //    notas.Pega("re"),
            //    notas.Pega("mi"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //    notas.Pega("fa"),
            //};
            //Piano piano = new Piano();
            //piano.Toca(musica);

            //Cap 3 Memento - toda vez salvar objeto
            //Historico historico = new Historico();
            //Contrato c = new Contrato(DateTime.Now, "Victor", TipoContrato.Novo);
            //historico.Adiciona(c.SalvaEstado());

            ////Console.WriteLine(c.Tipo);

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //c.Avanca();
            //historico.Adiciona(c.SalvaEstado());

            //Console.WriteLine(c.Tipo);
            //Console.WriteLine(historico.Pega(0).Contrato.Tipo);

            //Cap 4 - Interpreter
            //IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            //Console.WriteLine(esquerda.Avalia()); 
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //Console.WriteLine(direita.Avalia()); 
            //IExpressao soma = new Soma(esquerda,direita);

            //Console.WriteLine(soma.Avalia());
            //Cap 4 - Interpreter nativo do C#
            //Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
            //Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
            //Console.WriteLine(funcao());

            //Cap 5 - Visitor
            //IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
            //Console.WriteLine(esquerda.Avalia());
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //Console.WriteLine(direita.Avalia());
            //IExpressao soma = new Soma(esquerda, direita);
            //Console.WriteLine(soma.Avalia());
            //ImpressoraVisitor impressora = new ImpressoraVisitor();
            //soma.Aceita(impressora);

            //Cap 6 - Bridge

            //IMensagem mensagem = new MensagemAdminstrativa("victor");
            //IEnviador enviador = new MensagemPorSms();
            //mensagem.Enviador = enviador;
            //mensagem.Envia();

            // Cap 7 - Command

            //FilaDeTrabalho fila = new FilaDeTrabalho();
            //Pedido pedido1 = new Pedido("Mauricio", 100.0);
            //Pedido pedido2 = new Pedido("Marcelo", 200.0);

            //fila.Adiciona(new PagaPedido(pedido1));
            //fila.Adiciona(new PagaPedido(pedido2));

            //fila.Adiciona(new FinalizaPedido(pedido1));
            //fila.Processa();

            // Cap 8 - Adapter
            //Cliente cliente = new Cliente();
            //cliente.Nome = "Victor";
            //cliente.Endereco = "Rua Vergueiro";
            //cliente.DataDeNascimento = DateTime.Now;

            //string xml = new GeradorDeXml().GeraXml(cliente);

            //Console.WriteLine(xml);

            // Cap 9 - Façade - Singleton
            //String cpf = "1234";
            //EmpresaFacade facade = new EmpresaFacadeSingleton().Instancia;
            //Cliente cliente = facade.BuscaCliente();

            //fatura = facade.CriaFatura(cliente, 5000);
            //facade.GeraCobranca(tipo.Boleto, fatura)
                
            //Cliente cliente
            //     = new ClientDao().BuscaPorCpf(cpf);
            //Fatura fatura = new Fatura(cliente, 5000);
            //Cobranca cobranca = new Cobranca(Tipo.Boleto, fatura);
            //cobranca.Emite();

            //ContatoCliente contat = new ContatoCliente(cliente, cobranca);
            //contato.Dispara();


            Console.ReadKey();
        }
    }
}
