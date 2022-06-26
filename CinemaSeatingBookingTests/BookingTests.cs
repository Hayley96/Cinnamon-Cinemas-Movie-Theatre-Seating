using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;
using FluentAssertions;


namespace CinemaSeatingBookingTests
{
    public class BookingTests
    {
        private Booking booking;
        private BookingController bookingController;
        private FloorPlanner floorplanner;

        [SetUp]
        public void Setup()
        {
            booking = new();
            floorplanner = new();
            bookingController = new(floorplanner, booking);
            bookingController.GetFloorPlan("Seat");
        }

        [Test]
        public void BookedSeats_List_Should_Contain_Seat_A1_When_1_Seat_Booked()
        {
            int seatsToBook = 1;
            string expectedResult = "A1";
            booking.BookSeats(bookingController.Seats!, seatsToBook);
            Assert.That(booking.BookedSeats[0].Name, Is.EqualTo(expectedResult));

        }

        [Test]
        public void BookedSeats_List_Should_Contain_Seats_A1_And_A2_When_2_Seats_Booked()
        {
            int seatsToBook = 2;
            string expectedResult1 = "A1";
            string expectedResult2 = "A2";
            booking.BookSeats(bookingController.Seats!, seatsToBook);
            Assert.That(booking.BookedSeats[0].Name, Is.EqualTo(expectedResult1));
            Assert.That(booking.BookedSeats[1].Name, Is.EqualTo(expectedResult2));
        }
    }
}