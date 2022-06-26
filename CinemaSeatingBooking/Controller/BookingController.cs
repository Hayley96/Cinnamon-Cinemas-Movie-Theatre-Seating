using CinemaSeatingBooking.Models;
using CinemaSeatingBooking.UI;

namespace CinemaSeatingBooking.Controller
{
    public class BookingController
    {
        public Booking? Booking { get; private set; }
        public FloorPlanner? FloorPlanner { get; private set; }
        public List<IBookingType>? Seats { get; private set; }
        public List<int> RandomInputs { get; private set; } = new();

        public BookingController(FloorPlanner floorplanner, Booking seatBooking)
        {
            FloorPlanner = floorplanner;
            Booking = seatBooking;
        }
        public void GetFloorPlan(string typeToBook)
        {
            Seats = FloorPlanner!.GenerateSeatLayout(typeToBook);
            SendItemsToDisplay<string>($"\n\rStarting Available {typeToBook}:", Seats);
        }

        public bool BookSeats(int numberofseats)
        {
            if (numberofseats > Seats!.Where(seat => seat.StatusColor.Equals(ConsoleColor.Green)).Count())
                return false;
            for (int i = 0; i < numberofseats; i++)
            {
                Booking!.BookSeats(Seats!, i);
                FloorPlanner!.UpdateSeatLayout(Seats!, Booking.BookedSeats);
            }
            GenerateResultsForDisplay();
            return true;
        }

        public void GenerateResultsForDisplay()
        {
            //Console.Write("");
            //Console.WriteLine("\n");
            SendItemsToDisplay<string>("\rCurrent Seat Availability:", Seats!);
            SendItemsToDisplay<string>("\rBooked:", Booking!.BookedSeats);
            Helpers.ClearConsoleLinesAbove(3);
        }


        private void SendItemsToDisplay<T1>(T1 DisplayText, List<IBookingType> list)
        {
            Console.Write($"\r{DisplayText} ");
            list.ForEach(x => PrintToScreen.PrintFloorPlan(x));
            Console.WriteLine("\n");
        }
    }
}
