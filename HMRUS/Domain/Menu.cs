using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    class Menu
    {
        public void MainMenu()
        {
            
            bool loopMainMenu = true;
            while (loopMainMenu)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("=====WELCOME TO HORRORMOVIES R'us=======");
                Console.WriteLine("     Our featured films are:");
                Console.WriteLine(ShowMovieTitle ));
            }
        }
        public static void ShowMovieTitle(string title)
        {

        }
    }
}
