// using Car;
using System;


public class CarFactory
{
    public static void Main()
    {
        // Instanciamos un nuevo coche 
        Car car = new Car("rojo", "seat", "panda", 3, "gasoil");

        Console.WriteLine("\n");

        Console.WriteLine("Marca: " + car.getBrand());
        Console.WriteLine("Modelo: " + car.getModel());
        Console.WriteLine("Puertas: " + car.getDoors());
        Console.WriteLine("Combustible: " + car.getFuel());
        Console.WriteLine("Color: " + car.getColor());
    }
}
