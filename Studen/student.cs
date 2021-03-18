using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studen
{
    enum Klassen {EA1,EA2,EA3,EA4};
    class student
    {
        public string naam { get; set; }
        public int leeftijd { get; set; }
        public Klassen klas { get; set; }
        public int puntenCommunicatie { get; set; }
        public int puntenProgramminrPrinciples { get; set; }
        public int puntenWebTech { get; set; }

        public double BerekenTotaalCijfer()
        {
            return (puntenCommunicatie + puntenProgramminrPrinciples + puntenWebTech ) / 3.0;
        }
        public void GeefOverzicht()
        {
            Console.WriteLine($"{naam}, {leeftijd} jaar.");
            Console.WriteLine($"Klas: {klas}.");
            Console.WriteLine();
            Console.WriteLine("Cijferrapport");
            Console.WriteLine("*************");
            Console.WriteLine($"Communicatie:\t\t{puntenCommunicatie}");
            Console.WriteLine($"Programming Principles:\t{puntenProgramminrPrinciples}");
            Console.WriteLine($"Web Tech:\t\t{puntenWebTech}");
            Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():0.0}");
        }
        public student() { }
        public student (string naam,int leeftijd,int pntCom,int pntProg,int pntWeb)
        {
            this.naam = naam;
            this.leeftijd = leeftijd;
            this.puntenCommunicatie = pntCom;
            this.puntenProgramminrPrinciples = pntProg;
            this.puntenWebTech = pntWeb;

        }
    }
}
