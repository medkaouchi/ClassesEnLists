using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeelKaarten
{
    public enum Kleuren{Schoppen,Harten,Klaveren,Ruiten};
    class speelkaart
    {
        private int getal;

        public int Getal
        {
            get { return getal; }
            set { getal = value; }
        }

        private Kleuren kleur;

        public Kleuren Kleur
        {
            get { return kleur; }
            set { kleur = value; }
        }
        public speelkaart(int getal,Kleuren kleur)
        {
            this.getal = getal;
            this.kleur = kleur;
        }
    }
}
