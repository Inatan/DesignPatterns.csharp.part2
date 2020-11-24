using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.csharp.part2.Cap5;

namespace DesignPatterns.csharp.part2.Cap4
{
    public class Soma : IExpressao
    {
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public void Aceita(ImpressoraVisitor impressora)
        {
            impressora.ImpremeSoma(this);
        }

        public int Avalia()
        {
            int valorDireita = Direita.Avalia();
            int valorEsquerda = Esquerda.Avalia();
            return valorEsquerda + valorDireita;
        }
    }
}
