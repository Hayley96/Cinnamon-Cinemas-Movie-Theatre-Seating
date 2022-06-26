using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;

namespace CinemaSeatingBookingTests
{
    public class SeatFloorPlanTests
    {
        private Booking _booking;
        private BookingController _bookingController;
        private FloorPlanner _floorPlanner;
        [SetUp]
        public void Setup()
        {
            _booking = new();
            _floorPlanner = new();
            _bookingController = new(_floorPlanner, _booking);
            _bookingController.GetFloorPlan(3, 5, "Seat");
        }

        [Test]
        public void GenerateSeatLayout_Should_Return_A_List_With_15_Seats_When_Input_Value_Is_3_Rows_And_5_SeatsPerRow()
        {
            Assert.That(_floorPlanner.BookingType!.Count, Is.EqualTo(15));
        }

        [Test]
        public void UpdateSeatLayout_Should_Update_The_Seat_Status_Color_For_The_Number_Of_Booked_Seats()
        {
            int numberofseats = 2;
            _bookingController.BookSeats(numberofseats);
            var result = _bookingController.Seats!.Where(seat => seat.StatusColor.Equals(ConsoleColor.Red)).Count();
            var expectedResult = 2;

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}