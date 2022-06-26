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
            bookingController.GetFloorPlan(3, 5, "Seat");
        }

        [Test]
        public void BookedSeats_List_Should_Contain_Seat_A1_When_1_Seat_Booked()
        {
            int numberofseats = 1;
            for (int i = 0; i < numberofseats; i++)
            {
                booking.BookSeats(bookingController.Seats!, i);
            }
            Assert.That(booking.BookedSeats[0].Name, Is.EqualTo("A1"));
        }

        [Test]
        public void BookedSeats_List_Should_Contain_Seats_A1_And_A2_When_2_Seats_Booked()
        {
            int numberofseats = 2;
            for (int i = 0; i < numberofseats; i++)
            {
                booking.BookSeats(bookingController.Seats!, i);
            }
            Assert.That(booking.BookedSeats[0].Name, Is.EqualTo("A1"));
            Assert.That(booking.BookedSeats[1].Name, Is.EqualTo("A2"));
        }

        [Test]
        public void AreEnoughSeatsAvailable_Should_Return_True_If_The_Number_Of_Seats_Available_Is_Greater_Than_The_Input_Number()
        {

            Assert.That(booking.AreSeatsAvailable(2, bookingController.Seats!));
        }

        [Test]
        public void AreEnoughSeatsAvailable_Should_Return_False_If_The_Number_Of_Seats_Available_Is_Less_Than_The_Input_Number()
        {
            Assert.That(booking.AreSeatsAvailable(16, bookingController.Seats!), Is.False);
        }

        [Test]
        public void BookingsAvailable_Should_Return_True_If_Available_Seat_Count_Greater_Than_Zero()
        {
            Assert.That(booking!.BookingsAvailable(bookingController.Seats!));
        }

        [Test]
        public void BookingsAvailable_Should_Return_False_If_Available_Seat_Count_Equals_Zero()
        {
            int numberofseats = 15;
            for (int i = 0; i < numberofseats; i++)
            {
                booking.BookSeats(bookingController.Seats!, i);
            }
            Assert.That(booking!.BookingsAvailable(bookingController.Seats!), Is.False);
        }
    }
}