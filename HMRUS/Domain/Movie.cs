namespace HMRUS.Domain
{
    class Movie
    {
        public string MovieTitle { get; }
        public string MoviePlot { get; }
        public string MovieDuration { get; }
        public decimal MoviePrice { get; }

        public Movie(string movieTitle, string moviePlot, string movieDuration, decimal moviePrice)
        {
            MovieTitle = movieTitle;
            MoviePlot = moviePlot;
            MovieDuration = movieDuration;
            MoviePrice = moviePrice;
        }
    }
}
