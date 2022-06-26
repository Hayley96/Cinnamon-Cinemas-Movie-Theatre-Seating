namespace CinemaSeatingBooking.Models
{
    public interface IBookingType
    {
        public string? Name { get; set; }
        public ConsoleColor StatusColor { get; set; }
    }
}