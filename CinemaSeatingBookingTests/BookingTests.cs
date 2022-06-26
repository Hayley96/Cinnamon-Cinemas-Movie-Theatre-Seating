using CinemaSeatingBooking;
using FluentAssertions;


namespace CinemaSeatingBookingTests
{
    public class BookingTests
    {
        private Booking booking;

        [SetUp]
        public void Setup()
        {
            booking = new();
        }

        [Test]
        public void GenerateSeatList_Should_Return_A_List_Of_15_Seats()
        {
            booking.GenerateSeatList();
            Assert.That(booking.Seats.Count, Is.EqualTo(15));
        }

        [Test]
        public void BookedSeats_List_Should_Contain_Seat_A1_When_1_Seat_Booked()
        {
            booking.GenerateSeatList();
            int seatsToBook = 1;
            string expectedResult = "A1";
            booking.BookSeats(seatsToBook);
            Assert.That(booking.BookedSeats[0], Is.EqualTo(expectedResult));

        }

        [Test]
        public void BookedSeats_List_Should_Contain_Seats_A1_And_A2_When_2_Seats_Booked()
        {
            booking.GenerateSeatList();
            int seatsToBook = 2;
            string expectedResult1 = "A1";
            string expectedResult2 = "A2";
            booking.BookSeats(seatsToBook);
            Assert.That(booking.BookedSeats[0], Is.EqualTo(expectedResult1));
            Assert.That(booking.BookedSeats[1], Is.EqualTo(expectedResult2));

        }
    }
}