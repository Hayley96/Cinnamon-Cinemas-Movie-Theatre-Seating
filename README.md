# :movie_camera: Cinnamon-Cinemas-Movie-Theatre-Seating

## Introduction
The application is a Seat Booking application which allows a user to input a integer and returns corresponding booked seats.

The application consists of the following structure:

* CinemaSeatingBooking
	* Contains the seat booking application files
* CinemaSeatingBookingTests
	* Contains the tests for the seat booking application

The application features are:
* Select the booking type - currently only have an option for 'Seat'
* Select the number of rows and seats per row
* Select the number of seats to book
* Application will loop through previous step until no more seats are available - All seats booked

The application contains functionality to confirm seat availability and simple input validation.

### Pre-Requisites
- C# / .NET 6
- NuGet

### Technologies & Dependencies
- Console Application
- NUnit testing framework

### How to Get Started
- Fork this repo to your Github and then clone the forked version of this repo.

### Main Entry Point
- The Main Entry Point for the application is: [Program.cs](./CinemaSeatingBooking/Program.cs)

### Running the Unit Tests
- You can run the unit tests in Visual Studio, or you can go to your terminal and inside the root of this directory, run:

`dotnet test`

### Running the Application
- You can run the application in Visual Studio, or you can go to your terminal and inside the root of this directory, run:

`dotnet run`