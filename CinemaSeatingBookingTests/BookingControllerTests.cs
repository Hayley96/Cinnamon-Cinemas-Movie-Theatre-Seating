using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;

namespace CinemaSeatingBookingTests
{
    public class BookingControllerTests
    {
        private Booking _booking;
        private FloorPlanner _floorplanner;
        private BookingController _bookingController;

        [SetUp]
        public void Setup()
        {
            _booking = new();
            _floorplanner = new();
            _bookingController = new(_floorplanner, _booking);
            _bookingController.GetFloorPlan("Seat");
        }

        [Test]
        public void GetFloorPlan_Retrieves_A_List_Of_15_Seat_Objects_When_3_Rows_5_SeatsPerRow_Is_Selected()
        {
            Assert.That(_bookingController.Seats!.Count(), Is.EqualTo(15));
        }

        [Test]
        public void AreEnoughSeatsAvailable_Should_Return_True_If_The_Number_Of_Seats_Available_Is_Greater_Than_The_Input_Number()
        {
            Assert.That(_bookingController.AreEnoughSeatsAvailable(2));
        }

        [Test]
        public void AreEnoughSeatsAvailable_Should_Return_False_If_The_Number_Of_Seats_Available_Is_Less_Than_The_Input_Number()
        {
            Assert.That(_bookingController.AreEnoughSeatsAvailable(16), Is.False);
        }

        [Test]
        public void BookSeats_Should_Result_In_A_List_Of_BookedSeats_With_Count_Corresponding_To_Input()
        {
            int numberofseats = 3;
            _bookingController.BookSeats(numberofseats);
            Assert.That(_booking.BookedSeats.Count(), Is.EqualTo(numberofseats));
        }
    }
}