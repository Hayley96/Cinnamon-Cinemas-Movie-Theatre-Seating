using CinemaSeatingBooking.Controller;
using CinemaSeatingBooking.Models;
using CinemaSeatingBooking.UI;

int ValidMessage = 0, rows, seatsPerRow, numberOfSeatsToBook = 0;

Random rnd = new();
InputMessageController inputMessageController = new();
FloorPlanner FloorPlanner = new();
Booking booking = new();
BookingController bookingController = new(FloorPlanner, booking);


inputMessageController.ProcessCompleted += UIH_ProcessCompleted!;
string TypeToBook = inputMessageController.DisplayObjectTypeMenu("\rChoose A Object To Book", Helpers.DisplayClasses, BookingTypesFactory.BookingTypesDict);
inputMessageController.AskUserUntilInputIsValid("\rSelect Number of Rows: ");
rows = ValidMessage;

inputMessageController.AskUserUntilInputIsValid($"\rSelect Number of {TypeToBook} Per Row: ");
seatsPerRow = ValidMessage;

bookingController.GetFloorPlan(rows, seatsPerRow, TypeToBook);

while (bookingController.BookingsAvailable())
{
    inputMessageController.AskUserUntilInputIsValid($"\rNumber of {TypeToBook} To Book?: ");
    numberOfSeatsToBook = ValidMessage;
    if (bookingController.AreEnoughSeatsAvailable(numberOfSeatsToBook))
        bookingController.BookSeats(numberOfSeatsToBook);
}
Helpers.ExitProgram();

inputMessageController.ProcessCompleted -= UIH_ProcessCompleted!;

void UIH_ProcessCompleted(object sender, int successfulResult) => ValidMessage = successfulResult;