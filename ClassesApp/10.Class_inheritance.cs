//A child class (derived class) reuses and extends the features of a parent class (base class).

//➡ Parent Class → gives properties & methods
//➡ Child Class → receives them + can add more
using System;

class Vehicle        // Parent class (Base class)
{
    public string Brand { get; set; }

    public void Start()
    {
        Console.WriteLine("Vehicle is starting...");
    }
}

class Car : Vehicle    // Car inherits Vehicle
{
    public void Honk()
    {
        Console.WriteLine("Car is honking...");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Brand = "Honda";

        Console.WriteLine($"Brand: {myCar.Brand}");

        myCar.Start();  // Inherited from Vehicle
        myCar.Honk();   // Own method of Car
    }
}

