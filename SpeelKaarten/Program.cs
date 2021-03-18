using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeelKaarten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<speelkaart> speelKaartens = new List<speelkaart>();
            for (int i = 0; i < 13; i++)
            {
                speelKaartens.Add(new speelkaart(i + 1, Kleuren.Harten)) ;
                speelKaartens.Add(new speelkaart(i + 1, Kleuren.Klaveren));
                speelKaartens.Add(new speelkaart(i + 1, Kleuren.Ruiten));
                speelKaartens.Add(new speelkaart(i + 1, Kleuren.Schoppen));
            }
            Random rd = new Random();
            int index = rd.Next(0, 51);
            Console.WriteLine(speelKaartens[index].Getal+" van "+speelKaartens[index].Kleur.ToString());
            speelKaartens.RemoveAt(index);
            Console.ReadLine();
        }
    }
}
