using CinemaSeatingBooking;

Random rnd = new();
Booking booking = new();
booking.GenerateSeatList();
while (booking.BookSeats(rnd.Next(1,4)));