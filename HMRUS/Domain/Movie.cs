using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    class Movie
    {
        public string MovieTitle { get; }
        public string MoviePlot { get; }
        public string MovieDuration { get; }
        public decimal MoviePrice { get; }
        public Theatre Theatre { get; set; }

        public Movie(string movieTitle, string moviePlot, string movieDuration, decimal moviePrice, Theatre theatre)
        {
            MovieTitle = movieTitle;
            MoviePlot = moviePlot;
            MovieDuration = movieDuration;
            MoviePrice = moviePrice;
        }
    }
}
