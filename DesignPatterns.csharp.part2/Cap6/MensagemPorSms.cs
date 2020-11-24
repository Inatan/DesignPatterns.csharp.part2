using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap6
{
    public class MensagemPorSms : IEnviador
    {
        public void Envia(IMensagem mesagem)
        {
            Console.WriteLine("Enviando a mensagem por Sms");
            Console.WriteLine(mesagem.Formata());
        }

    }
}
