using DesignPatterns.csharp.part2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap4
{
    public class Numero : IExpressao
    {
        public Numero(int valor)
        {
            Valor = valor;
        }

        public int Valor { get; private set; }

        public int Avalia()
        {
            return Valor;
        }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
