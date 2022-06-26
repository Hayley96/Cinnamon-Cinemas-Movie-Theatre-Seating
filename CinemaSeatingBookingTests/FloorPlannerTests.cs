using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            _bookingController.GetFloorPlan("Seat");
        }

        [Test]
        public void GenerateSeatLayout_Should_Return_A_List_With_15_Seats_When_Input_Value_Is_3_Rows_And_5_SeatsPerRow()
        {
            Assert.That(_floorPlanner.BookingType!.Count, Is.EqualTo(15));
        }
    }
}
