namespace CinemaSeatingBooking.Models
{
    public static class BookingTypesFactory
    {
        public static IBookingType? bookingType { get; private set; }
        public static readonly Dictionary<string, Action> BookingTypesDict = new()
        {
            {"Seat", () => bookingType = new Seat()}
        };
    }
}
