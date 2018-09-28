using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    public class Menu
    {
        public int MainMenu(string t1, string t2, string t3, string t4, string t5, string t6, string t7, string t8, string t9, string t10, string t11)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("=====WELCOME TO HORRORMOVIES R'us=======");
            Console.WriteLine("     Our featured films are:");
            Console.WriteLine($"1. {t1}");
            Console.WriteLine($"2. {t2}");
            Console.WriteLine($"3. {t3}");
            Console.WriteLine($"4. {t4}");
            Console.WriteLine($"5. {t5}");
            Console.WriteLine($"6. {t6}");
            Console.WriteLine($"7. {t7}");
            Console.WriteLine($"8. {t8}");
            Console.WriteLine($"9. {t9}");
            Console.WriteLine($"10. {t10}");
            Console.WriteLine($"11. {t11}");
            Console.WriteLine("");
            Console.WriteLine("Choose movie by pressing the corresponding number and then 'Enter'");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public bool MovieSubMenu(string title, string tNumber, int seats, string plot, string duration, decimal price)
        {
            Console.Clear();
            Console.WriteLine($"======{title}======");
            Console.WriteLine("\n"+$"Movie plot: {plot}");
            Console.WriteLine("\n"+$"Length of movie: {duration}");
            Console.WriteLine("\n" + tNumber);
            Console.WriteLine("\n" + $"Number of seats: {seats}");
            Console.WriteLine("\n"+$"Price {price:c}");
            Console.WriteLine("\n Do you want to order ticket(s) for this movie?");
            Console.WriteLine("\n(O)K or (C)ancel");

            char choice = char.Parse(Console.ReadLine());
            if (choice=='O'||choice=='o')
                return true;
            else
            {
                return false;
            }
                
        }
    }
}
