namespace HMRUS.Domain
{
    public class Theatre
    {
        public string TheatreNumber { get; }
        public int TheatreSeats { get; }
        public int TheatreAvailableSeats { get; set; }

        public Theatre(string theatreNumber, int theatreSeats)
        {
            TheatreNumber = theatreNumber;
            TheatreSeats = theatreSeats;
            TheatreAvailableSeats = theatreSeats;
        }
    }
}
