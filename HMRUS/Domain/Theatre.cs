using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    class Theatre
    {
        public string MovieTitle { get; set; }
        public string TheatreNumber { get; set; }//Salongsnummer
        public int TheatreSeats { get; set; }
        public string MoviePlot { get; set; }
        public string MovieDuration { get; set; }
        public decimal MoviePrice { get; set; }

        public Theatre(string movieTitle, string theatreNumber, int theatreSeats, string moviePlot, string movieDuration, decimal moviePrice)
        {
            MovieTitle = movieTitle;
            TheatreNumber = theatreNumber;
            TheatreSeats = theatreSeats;
            MoviePlot = moviePlot;
            MovieDuration = movieDuration;
            MoviePrice = moviePrice;
        }
        #region MovieObjects
        Theatre t1 = new Theatre("Killer Asparagus", "Theatre no.1", 40, "After an agricultural experiment " +
            "went horribly wrong,\n 3 strands of asparagus start killing people and seem unstoppable...", "3h 45min.", 20);
        Theatre t2 = new Theatre("Return of the  Haemorrhaging turnip", "Theatre no.2", 50, "Turnips from 5000BC are found and they start haemorrhaging toxic slime \nthat kills whole " +
            "cities, can anyone put a stop to their expansion?", "4h 52min.", 27);
        Theatre t3 = new Theatre("Project X gone array", "Theatre no.2", 45, "Evil scientists try to develop a new breed of war dogs \nbut fails to contain the " +
            "dangerous beasts they’ve created....", "3h 21min.", 12);
        Theatre t4 = new Theatre("Attack of the space-locusts", "Theatre no.4", 60, "It’s the year 2548 and earth has finally obtained " +
            "peace all over the globe.\nIn come the space-locusts and chaos and mayhem manifests everywhere.", "0h 26min.", 7);
        Theatre t5 = new Theatre("Glenn reaps havoc (SWE, eng. subtitles)", "Theatre no.5", 45, "Toxic ravenous toads take over the swedish town Gothenburg.\n" +
            "Glenn - self - proclaimed hero - comes to save the day...", "1h 52min.", 10);
        Theatre t6 = new Theatre("Santa’s evil cousin", "Theatre no.6", 275, "After having been dormant for the past 250 years Santa’s evil \ncousin, Edgar, wakes up and " +
            "does his best to ruin x-mas by killing as many children as possible", "8h 19min.", 55);
        Theatre t7 = new Theatre("Devils orchard (HUN, eng. subtitles)", "Theatre no.7", 55, "In a rural town outside Budapest farmer Vaçlav comes across a strange \nand ominous garden " +
            "that turns out to be more sinister than anyone could ever imagine... ", "3h 24min.", 12);
        Theatre t8 = new Theatre("Camp men on holiday", "Theatre no.8", 80, "A group of 10 jolly, extravagant and expressive guys go on a \ncamping trip together. Secretly one of the men " +
            "have got a brain tumour which \nhas led to him becoming erratically homophobic and starts taking out the others. Classic who dunnit with a twist.",
            "4h 52min.", 15);
        Theatre t9 = new Theatre("Death inc.", "Theatre no.9", 40, "The year is 2239 and the global government has implemented death squads \ngoing by the name of " +
            "‘Death inc.’. A small group of rebels try to dismantle the organized killing machine \n(Gory way beyond anything you’ve seen so far!!)", "2h 26min.", 12);
        Theatre t10 = new Theatre("Meatgrinder mania", "Theatre no.10", 35, "A butcher is struck by a meteor but instead of dying he’s able \nto develop autonomous meatgrinders that can also walk....",
            "0h 6min.", 2);
        Theatre t11 = new Theatre("My little pony (Directors cut)", "Theatre no.11", 15, "Everything you thought you knew about My little pony - DEBUNKED",
            "17h 46min.", 175); 
        #endregion
        public override string ToString()
        {
            return ($"Title: {MovieTitle}\nTheatre no.: {TheatreNumber}\nNumber of seats: {TheatreSeats}\nPlot of the movie: {MoviePlot}\n" +
                $"Duration of movie: {MovieDuration}\nPrice: {MoviePrice}");
        }
    }
}
