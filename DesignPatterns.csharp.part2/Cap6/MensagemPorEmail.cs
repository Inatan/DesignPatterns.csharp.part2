using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap6
{
    public class MensagemPorEmail : IEnviador
    {
        public void Envia(IMensagem mesagem)
        {
            Console.WriteLine("Enviado a mensagem por email");
            Console.WriteLine(mesagem.Formata());
        }
    }
}
