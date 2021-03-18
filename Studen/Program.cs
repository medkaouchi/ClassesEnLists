using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studen
{
    class Program
    {
        static void Main(string[] args)
        {
            bool overschrijven = false;
            List<student> Studenten = new List<student>();
            for (int i = 0; i < 5; i++)
            {
                Studenten.Add(null);
            }
            do
            {
                switch (SelectMenu("Student gegevens invoeren", "Student gegevens tonen"))
                {
                    case 1:
                        Console.WriteLine("Student:\n");
                        int index = SelectMenu("Student 1", "Student 2", "Student 3", "Student 4", "Student 5") - 1;
                        do
                        { if ((Studenten.ElementAt(index) != null && overschrijven) || Studenten.ElementAt(index) == null)
                            {
                                Klassen klas = (Klassen)SelectMenu("Klas 1", "Klas 2", "Klas 3", "Klas 4");
                                Console.Write("Naam: ");
                                string naam = Console.ReadLine();
                                Console.Write("Leeftijd: ");
                                int leeftijd = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Punten Comminicatie: ");
                                int pntcom = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Punten Programming Principles: ");
                                int pntprog = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Punten Web Tech: ");
                                int pntweb = Convert.ToInt32(Console.ReadLine());
                                Studenten.Insert(index, new student(naam, leeftijd, pntcom, pntprog, pntweb));
                                Console.WriteLine("\n\nNieuw Student ingevoerd:");
                                Studenten.ElementAt(index).GeefOverzicht();
                                Console.ReadLine();
                            }

                            else
                            {
                                if (SelectMenu( "De oude gegevens overschrijven", "Nee, de oude gegevens niet overschrijven") == 1)
                                    overschrijven = true;
                            }
                        } while (overschrijven);
                        break;
                    case 2:
                        foreach (var item in Studenten)
                        {
                            if (item != null)
                            {
                                Console.WriteLine("---------------------");
                                item.GeefOverzicht();
                            }
                        }
                        Console.ReadLine();
                        break;
                }
            } while (true);
        }
        static int SelectMenu(params string[] menu)
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;
            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    if (selection == i + 1)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }
                    Console.WriteLine((i + 1) + ": " + menu[i]);
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;

            return selection;
        }
    }
}
