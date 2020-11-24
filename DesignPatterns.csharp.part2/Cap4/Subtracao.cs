using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap4
{
    public class Subtracao : IExpressao
    {
        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public int Avalia()
        {
            int valorDireita = Direita.Avalia();
            int valorEsquerda = Esquerda.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}
