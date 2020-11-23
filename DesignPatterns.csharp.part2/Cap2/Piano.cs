using System;
using System.Collections.Generic;

namespace DesignPatterns.csharp.part2.Cap2
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
