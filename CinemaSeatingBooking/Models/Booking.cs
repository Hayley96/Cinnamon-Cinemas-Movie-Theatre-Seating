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
    }
}