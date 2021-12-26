using MyStudies.Driver;
using System;


public class Practices
{
    public static void Main()
    {
        // First practice 24/12/2021
        Car car = new Car("Rojo", "Seat", "Panda", 3, "Gasoil");

        Console.WriteLine("\n");
        Console.WriteLine("------------------------");
        Console.WriteLine("Second practice 26/12/2021");

        Console.WriteLine("Brand: " + car.getBrand());
        Console.WriteLine("Model: " + car.getModel());
        Console.WriteLine("Doors: " + car.getDoors());
        Console.WriteLine("Fuel: "  + car.getFuel());
        Console.WriteLine("Color: " + car.getColor());

        // Second practice 26/12/2021
        Driver driver = new Driver("Otto", 1.82, car);

        Console.WriteLine("\n");
        Console.WriteLine("------------------------");
        Console.WriteLine("Second practice 26/12/2021");

        Console.WriteLine("Name: " + driver.getName());
        Console.WriteLine("Height: " + driver.getHeigth());
        Console.WriteLine("Car: " + driver.getCar());
    }
}
