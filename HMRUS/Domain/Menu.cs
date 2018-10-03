using System;
using System.Collections.Generic;
using System.Speech.Synthesis;

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
        List<Movie> movieList = new List<Movie>();
        List<Theatre> theatreList = new List<Theatre>();
        public Menu()
        {
            #region Theatres
            theatreList.Add(new Theatre("Theatre no.1", 40));
            theatreList.Add(new Theatre("Theatre no.2", 50));
            theatreList.Add(new Theatre("Theatre no.2", 45));
            theatreList.Add(new Theatre("Theatre no.4", 60));
            theatreList.Add(new Theatre("Theatre no.5", 45));
            theatreList.Add(new Theatre("Theatre no.6", 275));
            theatreList.Add(new Theatre("Theatre no.7", 55));
            theatreList.Add(new Theatre("Theatre no.8", 80));
            theatreList.Add(new Theatre("Theatre no.9", 40));
            theatreList.Add(new Theatre("Theatre no.10", 35));
            theatreList.Add(new Theatre("Theatre no.11", 15));
            #endregion
            #region Movies
            movieList.Add(new Movie("Killer Asparagus", MoviePlot1, "3h 45min.", 20));
            movieList.Add(new Movie("Return of the  Haemorrhaging turnip", MoviePlot2, "4h 52min.", 27));
            movieList.Add(new Movie("Project X gone array", MoviePlot3, "3h 21min.", 12));
            movieList.Add(new Movie("Attack of the space-locusts", MoviePlot4, "0h 26min.", 7));
            movieList.Add(new Movie("Glenn reaps havoc (SWE, eng. subtitles)", MoviePlot5, "1h 52min.", 10));
            movieList.Add(new Movie("Santa’s evil cousin", MoviePlot6, "8h 19min.", 55));
            movieList.Add(new Movie("Devils orchard (HUN, eng. subtitles)", MoviePlot7, "3h 24min.", 12));
            movieList.Add(new Movie("Camp men on holiday", MoviePlot8, "4h 52min.", 15));
            movieList.Add(new Movie("Death inc.", MoviePlot9, "2h 26min.", 12));
            movieList.Add(new Movie("Meatgrinder mania", MoviePlot10, "0h 6min.", 2));
            movieList.Add(new Movie("My little pony (Directors cut)", MoviePlot11, "17h 46min.", 175));
            #endregion
        }
        public void MainMenu()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("=====WELCOME TO HORRORMOVIES R'us=======");
            Console.WriteLine("     Our featured films are:");
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movieList[i].MovieTitle}");
            }
            Console.WriteLine("");
            Console.WriteLine("Choose movie by pressing the corresponding number and then 'Enter'");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Welcome to horrormovies are us!");

            try
            {
                int choice = int.Parse(Console.ReadLine());
                MovieSubMenu(choice - 1);
            }
            catch
            {
                Console.WriteLine("You can only use numbers stated in the list.");
                Console.WriteLine("Press any key to start over.");
                Console.ReadKey();
                MainMenu();
            }
        }
        public void MovieSubMenu(int choiceA)
        {
            Console.Clear();
            Console.WriteLine($"======{movieList[choiceA].MovieTitle}======");
            Console.WriteLine("\n" + $"Movie plot: {movieList[choiceA].MoviePlot}");
            Console.WriteLine("\n" + $"Length of movie: {movieList[choiceA].MovieDuration}");
            Console.WriteLine("\n" + $"{ theatreList[choiceA].TheatreNumber}");
            Console.WriteLine("\n" + $"Number of seats: {theatreList[choiceA].TheatreSeats}");
            Console.WriteLine("\n" + $"Price {movieList[choiceA].MoviePrice:c}");
            Console.WriteLine("\nDo you want to order ticket(s) for this movie?");
            Console.WriteLine("\n(O)K to proceed or (C)ancel to return to list of movies.");
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("This one is really scary!");
            string buyChoice = Console.ReadLine();

            if (buyChoice.ToUpper() == "O")
            {
                BuyTicket(choiceA);
            }
            else if(buyChoice.ToUpper() == "C")
            {
                MainMenu();
            }
            else
            {
                Console.WriteLine("I'm sorry, I didn't register an 'O' or 'C'");
                Console.WriteLine("Press any key to try again.");
                Console.ReadKey();
                MovieSubMenu(choiceA);
            }
        }
        public void BuyTicket(int choiceB)
        {
            Console.Clear();
            Console.WriteLine($"Movietitle: {movieList[choiceB].MovieTitle}");
            Console.WriteLine($"Price per ticket: {movieList[choiceB].MoviePrice:c}");
            Console.WriteLine($"Number of seats available: {theatreList[choiceB].TheatreAvailableSeats}");
            if (theatreList[choiceB].TheatreAvailableSeats == 0)
            {
                Console.WriteLine("Show sold out!");
                Console.WriteLine("Press any key to return to Main menu.");
                Console.ReadKey();
                MainMenu();
            }
            Console.WriteLine("How many tickets would you like to purchase? ");
            try
            {
                int tickets = int.Parse(Console.ReadLine());
                if (tickets > theatreList[choiceB].TheatreAvailableSeats)
                {
                    Console.WriteLine("You're trying to buy more tickets than are available, bell end!");
                    Console.WriteLine("Press any key to return to try again.");
                    Console.ReadKey();
                    BuyTicket(choiceB);
                }
                else
                {
                    decimal ticketSum = tickets * movieList[choiceB].MoviePrice;
                    Console.WriteLine($"Total amount: {ticketSum:c}");
                    Console.WriteLine("Proceed to checkout? (O)k or (C)ancel to return to Main menu.");
                    string proceed = Console.ReadLine();
                    if (proceed.ToUpper() == "O")
                    {
                        PayTicket(ticketSum, choiceB, tickets);
                    }
                    else if (proceed.ToUpper() == "C")
                    {
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, I didn't register an 'O' or 'C'");
                        Console.WriteLine("Press any key to try again.");
                        Console.ReadKey();
                        MovieSubMenu(choiceB);
                    }
                }
            }
            catch
            {
                Console.WriteLine("You can only use numbers.");
                Console.WriteLine("Press any key to start over.");
                Console.ReadKey();
                BuyTicket(choiceB);
            }
        }
        public void PayTicket(decimal ticketSum, int choiceC, int tickets)
        {
            string cardNumber;
            string cardHolder;
            string cvv;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Type your credit card number: ");
            cardNumber = Console.ReadLine();
            Console.WriteLine("Name on credit card? ");
            cardHolder = Console.ReadLine();
            Console.WriteLine("Type your CVV number: ");
            cvv = Console.ReadLine();
            Console.WriteLine("Please confirm your details before proceeding.");
            Console.WriteLine("\n" + $"CC number: {cardNumber}");
            Console.WriteLine($"Name on card: {cardHolder}");
            Console.WriteLine($"CVV: {cvv}");
            Console.WriteLine("Is this correct (Y)es/(N)o \nTo cancel press 'C'");
            string confirmPayment = Console.ReadLine();
            if (confirmPayment.ToUpper() == "Y")
            {
                Console.WriteLine("");
                Console.WriteLine($"Your creditcard will now be charged with: {ticketSum} ");
                PrintTicket(choiceC, ticketSum, tickets);
            }
            else if (confirmPayment.ToUpper() == "N")
            {
                PayTicket(ticketSum, choiceC, tickets);
            }
            else
            {
                MainMenu();
            }
        }
        public void PrintTicket(int choiceD, decimal ticketSum, int tickets)
        {
            theatreList[choiceD].TheatreAvailableSeats -= tickets;
            Random randomizer = new Random();
            int confirmationNumber = randomizer.Next(1000, 999999999);

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("=====WELCOME TO HORRORMOVIES R'us=======");
            Console.WriteLine("Here is a summary of your order:");
            Console.WriteLine("");
            Console.WriteLine($"You have bought {tickets} tickets to the awesome movie ");
            Console.WriteLine($"{movieList[choiceD].MovieTitle} for a total cost of {ticketSum:c}");
            Console.WriteLine($"Confirmation number: {confirmationNumber}");
            Console.WriteLine("See you soon");
            Console.WriteLine("\nPress any key to go to Main menu:");
            Console.ReadKey();
            MainMenu();
        }
    }
}