using System.Globalization;
using CarRentManager.Entities;
using CarRentManager.Services;

namespace CarRentManager;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data :");
        Console.Write("Car model: ");
        string carModel = Console.ReadLine();

        Console.Write("Pickup (dd/MM/yyyy hh:mm)");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Return (dd/MM/yyyy hh:mm)");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.Write("Price per hour: ");
        double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Price per day: ");
        double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));

        RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

        rentalService.ProcessInvoice(carRental);

        Console.WriteLine();
        Console.WriteLine("INVOICE:");
        Console.WriteLine(carRental.Invoice);
    }
}