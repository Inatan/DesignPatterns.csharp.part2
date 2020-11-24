using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.csharp.part2.Cap6
{
    public class MensagemAdminstrativa : IMensagem
    {
        public string Nome { get; private set; }
        public IEnviador Enviador { get; set; }

        public MensagemAdminstrativa(string nome)
        {
            Nome = nome;
        }


        public void Envia()
        {
            Enviador.Envia(this);
            //Console.WriteLine("Enviado a mesnagem por SMS");
            //Console.WriteLine($"Mensagem para o cliente {Nome}");
        }

        public string Formata()
        {
            return $"Enviado a mensagem para o adminsitrador {Nome}";
        }

    }
}
