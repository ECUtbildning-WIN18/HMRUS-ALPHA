using System;
using System.Collections.Generic;
using System.Text;

namespace HMRUS.Domain
{
    public class Theatre
    {
        public string TheatreNumber { get; }
        public int TheatreSeats { get; }


        public Theatre(string theatreNumber, int theatreSeats)
        {
            TheatreNumber = theatreNumber;
            TheatreSeats = theatreSeats;
        }
    }
}
