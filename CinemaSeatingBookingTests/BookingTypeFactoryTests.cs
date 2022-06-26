using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;

namespace CinemaSeatingBookingTests
{
    public class BookingTypeFactoryTests
    {
        private Booking _booking;
        private FloorPlanner _floorPlanner;
        private BookingController _bookingController;

        [SetUp]
        public void Setup()
        {
            _booking = new();
            _floorPlanner = new();
            _bookingController = new(_floorPlanner, _booking);
            _bookingController.GetFloorPlan(3, 5,"Seat");
        }

        [Test]
        public void BookingTypeFactory_Dictionary_Action_Should_Return_An_Instance_Of_The_Selected_Object()
        {
            string result = BookingTypesFactory.bookingType!.GetType().Name;
            string expectedresult = "Seat";
            Assert.That(result, Is.EqualTo(expectedresult));
        }
    }
}