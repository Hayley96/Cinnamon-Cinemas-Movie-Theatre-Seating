using CinemaSeatingBooking.Models;

namespace CinemaSeatingBooking.UI
{
    public static class PrintToScreen
    {
        public static void PrintFloorPlan(IBookingType seat)
        {
            var prevColor = Console.BackgroundColor;
            var prevForeColor = Console.ForegroundColor;
            Console.BackgroundColor = seat.StatusColor;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(seat.Name);
            Console.BackgroundColor = prevColor;
            Console.ForegroundColor = prevForeColor;
            Console.Write(" ");
        }
    }
}
