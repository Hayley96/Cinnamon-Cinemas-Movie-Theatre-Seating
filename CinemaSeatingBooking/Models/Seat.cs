namespace CinemaSeatingBooking.Models
{
    public class Seat : IBookingType
    {
        public string? Name { get; set; } = string.Empty;
        public ConsoleColor StatusColor { get; set; } = ConsoleColor.Green;
    }
}