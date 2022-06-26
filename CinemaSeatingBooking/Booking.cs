namespace CinemaSeatingBooking
{
    public class Booking
    {
        public List<string> Seats { get; private set; }
        public List<string> BookedSeats { get; private set; }
        public List<int> RandomInputs { get; private set; }

        public Booking()
        {
            Seats = new();
            BookedSeats = new();
            RandomInputs = new();
        }

        public void GenerateSeatList()
        {
            char seatRow = 'A';
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Seats.Add(seatRow.ToString() + j.ToString());
                }
                seatRow++;
            }
        }

        public bool BookSeats(int numberofseats)
        {
            RandomInputs.Add(numberofseats);
            if (Seats.Count! > numberofseats)
            {
                for (int i = 0; i < numberofseats; i++)
                {
                    BookedSeats.Add(Seats[0]);
                    Seats.Remove(Seats[0]);
                }
                return true;
            }
            return false;
        }
    }
}