using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;

Random rnd = new();
FloorPlanner floorPlanner = new();
Booking booking = new();
BookingController bookingController = new(floorPlanner, booking);
bookingController.GetFloorPlan("Seat");
while (booking.BookSeats(bookingController.Seats!, rnd.Next(1,4)));
bookingController.GenerateResultsForDisplay();