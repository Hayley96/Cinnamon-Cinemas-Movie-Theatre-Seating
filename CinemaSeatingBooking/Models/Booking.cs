namespace CinemaSeatingBooking.Models
{
    public class Booking
    {
        public List<IBookingType> BookedSeats { get; private set; } = new();
        public List<int> RandomInputs { get; private set; } = new();

        public bool BookSeats(List<IBookingType> Seats, int numberofseats)
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