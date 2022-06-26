

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
    }
}
