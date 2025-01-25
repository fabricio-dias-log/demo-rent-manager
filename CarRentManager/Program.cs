using System.Globalization;
using CarRentManager.Entities;

namespace CarRentManager;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rental data :");
        Console.WriteLine("Car model: ");
        string carModel = Console.ReadLine();

        Console.WriteLine("Pickup (dd/MM/yyyy hh:mm)");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        Console.WriteLine("Return (dd/MM/yyyy hh:mm)");
        DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

        CarRental carRental = new CarRental(start, finish, new Vehicle(carModel));



    }
}