using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarkManager
{
    class Program
    {
        static void Main(string[] args)
        {
            BookMark[] bookmarks = new BookMark[50];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Naam: ");
                string naam = Console.ReadLine();
                Console.WriteLine("Url:  ");
                bookmarks[i] = new BookMark(naam, Console.ReadLine());
            }
            do
            {
                switch (SelectMenu("Bookmarks lijst", "Bookmark aanpassen", "Bookmark verwijderen","Bookmark invoeren"))
                {
                    case 1:
                        string[] books = new string[bookmarks.Length]; int teller = 0;
                        for (int i = 0; i < bookmarks.Length; i++)
                        {
                            if (bookmarks[i] != null)
                            {
                                books[i] = bookmarks[i].naam + " : " + bookmarks[i].url;
                                teller++;
                            }
                            else
                                break;
                        }
                        string[] Books = new string[teller + 1];
                        for (int i = 0; i < teller; i++)
                        {
                            Books[i] = books[i];
                        }
                        Books[teller] = "Trug";
                        bool Trug = false;
                        while (!Trug)
                        {
                            int selected = SelectMenu(Books);
                            if (selected != teller + 1)
                                bookmarks[selected - 1].OpenSite();
                            else
                                Trug = true;
                        }

                        break;
                    case 2:
                        string[] book = new string[bookmarks.Length]; int tel = 0;
                        for (int i = 0; i < bookmarks.Length; i++)
                        {
                            if (bookmarks[i] != null)
                            {
                                book[i] = bookmarks[i].naam + " : " + bookmarks[i].url;
                                tel++;
                            }
                            else
                                break;
                        }
                        string[] Book = new string[tel + 1];
                        for (int i = 0; i < tel; i++)
                        {
                            Book[i] = book[i];
                        }
                        Book[tel] = "Trug";
                            int select = SelectMenu(Book);
                            if (select != tel + 1)
                            {
                                Console.Write("Nieuw naam: ");
                                string Nnaam = Console.ReadLine();
                                Console.Write("Nieuw Url: ");
                                bookmarks[select - 1]=new BookMark(Nnaam,Console.ReadLine());
                            }
                        break;
                    case 3:
                        string[] bookk = new string[bookmarks.Length]; int tell = 0;
                        for (int i = 0; i < bookmarks.Length; i++)
                        {
                            if (bookmarks[i] != null)
                            {
                                bookk[i] = bookmarks[i].naam + " : " + bookmarks[i].url;
                                tell++;
                            }
                            else
                                break;
                        }
                        string[] Bookk = new string[tell + 1];
                        for (int i = 0; i < tell; i++)
                        {
                            Bookk[i] = bookk[i];
                        }
                        Bookk[tell] = "Trug";
                        int selectd = SelectMenu(Bookk);
                        if (selectd != tell + 1)
                        {
                            if (selectd == tell)
                                bookmarks[selectd - 1] = null;
                            else
                            {
                                for (int i = selectd; i < tell; i++)
                                    bookmarks[i - 1] = bookmarks[i];
                                bookmarks[tell-1] = null;
                            }
                        }
                        break;
                    case 4:
                        if (bookmarks[bookmarks.Length - 1] != null)
                        { 
                            Console.WriteLine("Je list is vol!");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write("Naam: ");
                            string nm = Console.ReadLine();
                            Console.Write("Url: ");
                            for (int i = 0; i < bookmarks.Length; i++)
                            {
                                if (bookmarks[i] == null)
                                {
                                    bookmarks[i] = new BookMark(nm, Console.ReadLine());
                                    break;
                                }
                            }
                        }
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
