using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    public class Menu
    {
        #region MoviePlotConstants
        const string MoviePlot1 = "After an agricultural experiment's gone horribly wrong,\n 3 strands of asparagus start killing people and seem unstoppable...";
        const string MoviePlot2 = "Turnips from 5000BC are found and they start haemorrhaging toxic slime \nthat kills whole cities, can anyone put a stop to their expansion?";
        const string MoviePlot3 = "Evil scientists try to develop a new breed of war dogs \nbut fails to contain the dangerous beasts they’ve created....";
        const string MoviePlot4 = "It’s the year 2548 and earth has finally obtained peace all over the globe.\nIn come the space-locusts and chaos and mayhem manifests everywhere.";
        const string MoviePlot5 = "Toxic ravenous toads take over the swedish town Gothenburg.\nGlenn - self - proclaimed hero - comes to save the day...";
        const string MoviePlot6 = "After having been dormant for the past 250 years Santa’s evil \ncousin, Edgar, wakes up and does his best to ruin x-mas by killing as many children as possible";
        const string MoviePlot7 = "In a rural town outside Budapest farmer Vaçlav comes across a strange \nand ominous garden that turns out to be more sinister than anyone could ever imagine... ";
        const string MoviePlot8 = "A group of 10 jolly, extravagant and expressive guys go on a \ncamping trip together. Secretly one of the men have got a brain tumour which \nhas led to him becoming erratically homophobic and starts taking out the others. Classic who dunnit with a twist.";
        const string MoviePlot9 = "The year is 2239 and the global government has implemented death squads \ngoing by the name of ‘Death inc.’. A small group of rebels try to dismantle the organized killing machine \n(Gory way beyond anything you’ve seen so far!!)";
        const string MoviePlot10 = "A butcher is struck by a meteor but instead of dying he’s able \nto develop autonomous meatgrinders that can also walk....";
        const string MoviePlot11 = "Everything you thought you knew about My little pony - DEBUNKED";
        #endregion
        Movie[] movieArray = new Movie[11];
        Theatre[] theatreArray = new Theatre[11];
        public Menu()
        {
            #region Theatres
            Theatre t1 = new Theatre("Theatre no.1", 40);
            Theatre t2 = new Theatre("Theatre no.2", 50);
            Theatre t3 = new Theatre("Theatre no.2", 45);
            Theatre t4 = new Theatre("Theatre no.4", 60);
            Theatre t5 = new Theatre("Theatre no.5", 45);
            Theatre t6 = new Theatre("Theatre no.6", 275);
            Theatre t7 = new Theatre("Theatre no.7", 55);
            Theatre t8 = new Theatre("Theatre no.8", 80);
            Theatre t9 = new Theatre("Theatre no.9", 40);
            Theatre t10 = new Theatre("Theatre no.10", 35);
            Theatre t11 = new Theatre("Theatre no.11", 15);

            theatreArray[0] = t1;
            theatreArray[1] = t2;
            theatreArray[2] = t3;
            theatreArray[3] = t4;
            theatreArray[4] = t5;
            theatreArray[5] = t6;
            theatreArray[6] = t7;
            theatreArray[7] = t8;
            theatreArray[8] = t9;
            theatreArray[9] = t10;
            theatreArray[10] = t11;
            #endregion

            #region Movies
            Movie m1 = new Movie("Killer Asparagus", MoviePlot1, "3h 45min.", 20, t1);
            Movie m2 = new Movie("Return of the  Haemorrhaging turnip", MoviePlot2, "4h 52min.", 27, t2);
            Movie m3 = new Movie("Project X gone array", MoviePlot3, "3h 21min.", 12, t3);
            Movie m4 = new Movie("Attack of the space-locusts", MoviePlot4, "0h 26min.", 7, t4);
            Movie m5 = new Movie("Glenn reaps havoc (SWE, eng. subtitles)", MoviePlot5, "1h 52min.", 10, t5);
            Movie m6 = new Movie("Santa’s evil cousin", MoviePlot6, "8h 19min.", 55, t6);
            Movie m7 = new Movie("Devils orchard (HUN, eng. subtitles)", MoviePlot7, "3h 24min.", 12, t7);
            Movie m8 = new Movie("Camp men on holiday", MoviePlot8, "4h 52min.", 15, t8);
            Movie m9 = new Movie("Death inc.", MoviePlot9, "2h 26min.", 12, t9);
            Movie m10 = new Movie("Meatgrinder mania", MoviePlot10, "0h 6min.", 2, t10);
            Movie m11 = new Movie("My little pony (Directors cut)", MoviePlot11, "17h 46min.", 175, t11);

            movieArray[0] = m1;
            movieArray[1] = m2;
            movieArray[2] = m3;
            movieArray[3] = m4;
            movieArray[4] = m5;
            movieArray[5] = m6;
            movieArray[6] = m7;
            movieArray[7] = m8;
            movieArray[8] = m9;
            movieArray[9] = m10;
            movieArray[10] = m11;
            #endregion
        }

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("=====WELCOME TO HORRORMOVIES R'us=======");
            Console.WriteLine("     Our featured films are:");
            for (int i = 0; i < movieArray.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {movieArray[i].MovieTitle}");
            }
            Console.WriteLine("");
            Console.WriteLine("Choose movie by pressing the corresponding number and then 'Enter'");
            int choice = int.Parse(Console.ReadLine());

            MovieSubMenu(choice - 1);

        }
        public void MovieSubMenu(int choiceA)
        {
            Console.Clear();
            Console.WriteLine($"======{movieArray[choiceA].MovieTitle}======");
            Console.WriteLine("\n" + $"Movie plot: {movieArray[choiceA].MoviePlot}");
            Console.WriteLine("\n" + $"Length of movie: {movieArray[choiceA].MovieDuration}");
            Console.WriteLine("\n" + $"{ theatreArray[choiceA].TheatreNumber}");
            Console.WriteLine("\n" + $"Number of seats: {theatreArray[choiceA].TheatreSeats}");
            Console.WriteLine("\n" + $"Price {movieArray[choiceA].MoviePrice:c}");
            Console.WriteLine("\nDo you want to order ticket(s) for this movie?");
            Console.WriteLine("\n(O)K or (C)ancel");
            string buyChoice = Console.ReadLine();

            if (buyChoice.ToUpper()=="O")//(buyChoice == "o" || buyChoice == "O")
            {
                BuyTicket(choiceA);
            }
            else
            {
                MainMenu();
            }
        }

        public void BuyTicket(int choiceB)
        {
            Console.Clear();
            Console.WriteLine($"Movietitle: {movieArray[choiceB].MovieTitle}");
            Console.WriteLine($"Price per ticket: {movieArray[choiceB].MoviePrice:c}");
            Console.WriteLine($"Number of seats: {theatreArray[choiceB].TheatreSeats}");
            Console.WriteLine("How many tickets would you like to purchase? ");
            int tickets = int.Parse(Console.ReadLine());
            decimal ticketSum = tickets * movieArray[choiceB].MoviePrice;
            Console.WriteLine($"Total amount: {ticketSum:c}");
            Console.WriteLine("Proceed to checkout? (y/n)");
            string proceed = Console.ReadLine();
            if (proceed.ToUpper() == "Y")
                PayTicket(ticketSum, choiceB, tickets);
            else
                MainMenu();
        }
        public void PayTicket(decimal ticketSum, int choiceC, int tickets)
        {
            string cardNumber;
            string cvv;
            Console.WriteLine("Type your credit card number: ");
            cardNumber = Console.ReadLine();
            Console.WriteLine("Type your CVV number: ");
            cvv = Console.ReadLine();
            Console.WriteLine("Please confirm your details before proceeding.");
            Console.WriteLine("\n"+$"CC number: {cardNumber}");
            Console.WriteLine($"CVV: {cvv}");
            Console.WriteLine("Is this correct (y/n)");
            string confirmPayment = Console.ReadLine();
            if (confirmPayment.ToUpper() == "Y")
            {
                Console.Clear();
                Console.WriteLine($"Your creditcard will now be charged with: {ticketSum} ");
                PrintTicket(choiceC, ticketSum, tickets);
            }
            else
                PayTicket(ticketSum, choiceC, tickets);
        }
        public void PrintTicket(int choiceD, decimal ticketSum, int tickets)
        {
            Random randomizer = new Random();
            int confirmationNumber = randomizer.Next(1000, 9999);


            Console.WriteLine("=====WELCOME TO HORRORMOVIES R'us=======");
            Console.WriteLine("Here is a summary of your order:");
            Console.WriteLine("");
            Console.WriteLine($"You have bought {tickets} tickets to the awesome movie //n{movieArray[choiceD].MovieTitle} for a total cost of {ticketSum:c}");
            Console.WriteLine($"Confirmation number: {confirmationNumber}");
            Console.WriteLine("See you soon");
            Console.WriteLine("\nPress any key to go to Main menu:");
            Console.ReadKey();
            MainMenu();
        }
    }
}