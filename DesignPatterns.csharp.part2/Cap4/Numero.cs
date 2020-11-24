using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap4
{
    public class Numero : IExpressao
    {
        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int numero { get; private set; }

        public int Avalia()
        {
            return numero;
        }
    }
}
