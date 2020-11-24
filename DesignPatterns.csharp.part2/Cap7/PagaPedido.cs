using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap7
{
    class PagaPedido : IComando
    {
        public PagaPedido(Pedido pedido)
        {
            this.Pedido = pedido;
        }

        public Pedido Pedido { get; private set; }

        public void Executa()
        {
            Console.WriteLine($"Pagando o pedido do cliente {Pedido.Cliente}");
            Pedido.Paga();
        }
    }
}
