using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap9
{
    public class EmpresaFacade
    {
        // exemplo de legado
        //public Cliente BuscaCliente(string cpf)
        //{
        //    return new ClieanteDAO().BuscaPorCpf(cpf);
        //}

        //public Fatura CriaFatura(Cliente cliente, double valor)
        //{
        //    return new Fatura(cliente, valor);
        //}

        //public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
        //{
        //    GeraCobranca cobranca = new Cobranca(tipo, fatura);
        //    cobranca.Emite();
        //}

        //public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
        //{
        //    ContatoCliente contat new ContatoCliente(cliente, cobranca);
            
        //}
    }
}
