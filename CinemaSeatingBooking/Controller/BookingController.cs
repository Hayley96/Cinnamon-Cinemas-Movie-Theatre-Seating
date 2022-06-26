using CinemaSeatingBooking.Models;
using CinemaSeatingBooking.UI;

namespace CinemaSeatingBooking.Controller
{
    public class BookingController
    {
        public Booking? SeatBooking { get; private set; }
        public FloorPlanner? FloorPlanner { get; private set; }
        public List<IBookingType>? Seats { get; private set; }
        public List<int> RandomInputs { get; private set; } = new();

        public BookingController(FloorPlanner floorplanner, Booking seatBooking)
        {
            FloorPlanner = floorplanner;
            SeatBooking = seatBooking;
        }
        public void GetFloorPlan(string typeToBook)
        {
            Seats = FloorPlanner!.GenerateSeatLayout(typeToBook);
            SendItemsToDisplay<string>($"\n\rStarting Available {typeToBook}:", Seats);
        }

        public void GenerateResultsForDisplay()
        {
            Console.Write("");
            Console.WriteLine("\n");
            SendItemsToDisplay<string>("\rCurrent Seat Availability:", Seats!);
            SendItemsToDisplay<string>("\rBooked BookingType:", SeatBooking!.BookedSeats);
        }


        private void SendItemsToDisplay<T1>(T1 DisplayText, List<IBookingType> list)
        {
            Console.Write($"\r{DisplayText} ");
            list.ForEach(x => PrintToScreen.PrintFloorPlan(x));
            Console.WriteLine("\n");
        }
    }
}
