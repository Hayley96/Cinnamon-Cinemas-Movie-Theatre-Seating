namespace CinemaSeatingBooking.Models
{
    public class FloorPlanner
    {
        public List<IBookingType>? BookingType { get; private set; } = new();
        private IBookingType? _bookingType;
        public List<IBookingType> GenerateSeatLayout(string typeToBook)
        {
            char seatRow = 'A';
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    BookingTypesFactory.BookingTypesDict[typeToBook]();
                    _bookingType = BookingTypesFactory.bookingType;
                    _bookingType!.Name = seatRow.ToString() + j.ToString();
                    BookingType!.Add(_bookingType);
                }
                seatRow++;
            }
            return BookingType!;
        }

        public List<IBookingType> UpdateSeatLayout(List<IBookingType> seatsLayout, List<IBookingType> bookedSeats)
        {
            for (int i = 0; i < bookedSeats.Count; i++)
                seatsLayout[i].StatusColor = ConsoleColor.Red;
            return seatsLayout;
        }
    }
}