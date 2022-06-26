namespace CinemaSeatingBooking.Models
{
    public class Booking
    {
        public List<IBookingType> BookedSeats { get; private set; } = new();
        public List<int> RandomInputs { get; private set; } = new();

        public List<IBookingType> BookSeats(List<IBookingType> Seats, int index)
        {
            Seats[index].StatusColor = ConsoleColor.Red;
            BookedSeats.Add(Seats[index]);
            return Seats;
        }

        public bool BookingsAvailable(List<IBookingType> Seats) =>
            Seats.Where(seat => seat.StatusColor == ConsoleColor.Green).Count() != 0;

        public bool AreSeatsAvailable(int numberofseats, List<IBookingType> Seats) =>
            Seats.Where(seat => seat.StatusColor == ConsoleColor.Green).Count() >= numberofseats;
    }
}