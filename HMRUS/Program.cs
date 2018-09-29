using System;
using HMRUS.Domain;

namespace HMRUS
{
    class Program
    {
        static void Main()
        {

            #region MovieObjects
            const string MoviePlot1 = "After an agricultural experiment's gone horribly wrong,\n 3 strands of asparagus start killing people and seem unstoppable...";
            Theatre t1 = new Theatre("Killer Asparagus", "Theatre no.1", 40, MoviePlot1, "3h 45min.", 20);
            const string MoviePlot2 = "Turnips from 5000BC are found and they start haemorrhaging toxic slime \nthat kills whole cities, can anyone put a stop to their expansion?";
            Theatre t2 = new Theatre("Return of the  Haemorrhaging turnip", "Theatre no.2", 50, MoviePlot2, "4h 52min.", 27);
            const string MoviePlot3 = "Evil scientists try to develop a new breed of war dogs \nbut fails to contain the dangerous beasts they’ve created....";
            Theatre t3 = new Theatre("Project X gone array", "Theatre no.2", 45, MoviePlot3, "3h 21min.", 12);
            const string MoviePlot4 = "It’s the year 2548 and earth has finally obtained peace all over the globe.\nIn come the space-locusts and chaos and mayhem manifests everywhere.";
            Theatre t4 = new Theatre("Attack of the space-locusts", "Theatre no.4", 60, MoviePlot4, "0h 26min.", 7);
            const string MoviePlot5 = "Toxic ravenous toads take over the swedish town Gothenburg.\nGlenn - self - proclaimed hero - comes to save the day...";
            Theatre t5 = new Theatre("Glenn reaps havoc (SWE, eng. subtitles)", "Theatre no.5", 45, MoviePlot5, "1h 52min.", 10);
            const string MoviePlot6 = "After having been dormant for the past 250 years Santa’s evil \ncousin, Edgar, wakes up and does his best to ruin x-mas by killing as many children as possible";
            Theatre t6 = new Theatre("Santa’s evil cousin", "Theatre no.6", 275, MoviePlot6, "8h 19min.", 55);
            const string MoviePlot7 = "In a rural town outside Budapest farmer Vaçlav comes across a strange \nand ominous garden that turns out to be more sinister than anyone could ever imagine... ";
            Theatre t7 = new Theatre("Devils orchard (HUN, eng. subtitles)", "Theatre no.7", 55, MoviePlot7, "3h 24min.", 12);
            const string MoviePlot8 = "A group of 10 jolly, extravagant and expressive guys go on a \ncamping trip together. Secretly one of the men have got a brain tumour which \nhas led to him becoming erratically homophobic and starts taking out the others. Classic who dunnit with a twist.";
            Theatre t8 = new Theatre("Camp men on holiday", "Theatre no.8", 80, MoviePlot8, "4h 52min.", 15);
            const string MoviePlot9 = "The year is 2239 and the global government has implemented death squads \ngoing by the name of ‘Death inc.’. A small group of rebels try to dismantle the organized killing machine \n(Gory way beyond anything you’ve seen so far!!)";
            Theatre t9 = new Theatre("Death inc.", "Theatre no.9", 40, MoviePlot9, "2h 26min.", 12);
            const string MoviePlot10 = "A butcher is struck by a meteor but instead of dying he’s able \nto develop autonomous meatgrinders that can also walk....";
            Theatre t10 = new Theatre("Meatgrinder mania", "Theatre no.10", 35, MoviePlot10, "0h 6min.", 2);
            const string MoviePlot11 = "Everything you thought you knew about My little pony - DEBUNKED";
            Theatre t11 = new Theatre("My little pony (Directors cut)", "Theatre no.11", 15, MoviePlot11, "17h 46min.", 175);
            #endregion


            switch (new Menu().MainMenu(t1.MovieTitle, t2.MovieTitle, t3.MovieTitle, t4.MovieTitle, t5.MovieTitle,
                t6.MovieTitle, t7.MovieTitle, t8.MovieTitle, t9.MovieTitle, t10.MovieTitle, t11.MovieTitle))
            #region SwitchOnMainMenu
            {
                case 1:
                    {
                        if (new Menu().MovieSubMenu(t1.MovieTitle, t1.TheatreNumber, t1.TheatreSeats, t1.MoviePlot, t1.MovieDuration, t1.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 2:
                    {
                        if (new Menu().MovieSubMenu(t2.MovieTitle, t2.TheatreNumber, t2.TheatreSeats, t2.MoviePlot, t2.MovieDuration, t2.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 3:
                    {
                        if (new Menu().MovieSubMenu(t3.MovieTitle, t3.TheatreNumber, t3.TheatreSeats, t3.MoviePlot, t3.MovieDuration, t3.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 4:
                    {
                        if (new Menu().MovieSubMenu(t4.MovieTitle, t4.TheatreNumber, t4.TheatreSeats, t4.MoviePlot, t4.MovieDuration, t4.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 5:
                    {
                        if (new Menu().MovieSubMenu(t5.MovieTitle, t5.TheatreNumber, t5.TheatreSeats, t5.MoviePlot, t5.MovieDuration, t5.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 6:
                    {
                        if (new Menu().MovieSubMenu(t6.MovieTitle, t6.TheatreNumber, t6.TheatreSeats, t6.MoviePlot, t6.MovieDuration, t6.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 7:
                    {
                        if (new Menu().MovieSubMenu(t7.MovieTitle, t7.TheatreNumber, t7.TheatreSeats, t7.MoviePlot, t7.MovieDuration, t7.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }

                case 8:
                    {
                        if (new Menu().MovieSubMenu(t8.MovieTitle, t8.TheatreNumber, t8.TheatreSeats, t8.MoviePlot, t8.MovieDuration, t8.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 9:
                    {
                        if (new Menu().MovieSubMenu(t9.MovieTitle, t9.TheatreNumber, t9.TheatreSeats, t9.MoviePlot, t9.MovieDuration, t9.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 10:
                    {
                        if (new Menu().MovieSubMenu(t10.MovieTitle, t10.TheatreNumber, t10.TheatreSeats, t10.MoviePlot, t10.MovieDuration, t10.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                case 11:
                    {
                        if (new Menu().MovieSubMenu(t11.MovieTitle, t11.TheatreNumber, t11.TheatreSeats, t11.MoviePlot, t11.MovieDuration, t11.MoviePrice))
                        {

                        }
                        else Main(); break;
                    }
                default:
                    {
                        Console.WriteLine("A number in the list, knobhead!");
                        Console.WriteLine("Press any key, that's not a specified key but rather you should \nbang anywhere on the keyboard like the monkey you are");
                        Console.ReadKey();
                        Main(); break;
                    }
            }
            #endregion
        }
    }
}
