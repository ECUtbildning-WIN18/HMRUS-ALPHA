using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    public class Theatre
    {
        public string MovieTitle { get; }
        public string TheatreNumber { get; }//Salongsnummer
        public int TheatreSeats { get; }
        public string MoviePlot { get; }
        public string MovieDuration { get; }
        public decimal MoviePrice { get; }

        public Theatre(string movieTitle, string theatreNumber, int theatreSeats, string moviePlot, string movieDuration, decimal moviePrice)
        {
            MovieTitle = movieTitle;
            TheatreNumber = theatreNumber;
            TheatreSeats = theatreSeats;
            MoviePlot = moviePlot;
            MovieDuration = movieDuration;
            MoviePrice = moviePrice;
        }
        
        //public override string ToString()
        //{
        //    return ($"Title: {MovieTitle}\nTheatre no.: {TheatreNumber}\nNumber of seats: {TheatreSeats}\nPlot of the movie: {MoviePlot}\n" +
        //        $"Duration of movie: {MovieDuration}\nPrice: {MoviePrice}");
        //}
    }
}
