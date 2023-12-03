using System;
using System.Collections.Generic;

// Абстрактний клас Vehicle
abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    public abstract void Move();
}

// Клас Human
class Human : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Human is moving.");
    }
}

// Спадкоємці класу Vehicle
class Car : Vehicle
{
    public string Model { get; set; }

    public override void Move()
    {
        Console.WriteLine($"Car {Model} is moving.");
    }
}

class Bus : Vehicle
{
    public int PassengerCapacity { get; set; }

    public override void Move()
    {
        Console.WriteLine($"Bus with capacity {PassengerCapacity} is moving.");
    }
}

class Train : Vehicle
{
    public string TrainType { get; set; }

    public override void Move()
    {
        Console.WriteLine($"Train of type {TrainType} is moving.");
    }
}

// Клас Route
class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
}

// Клас TransportNetwork
class TransportNetwork
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public void CalculateOptimalRoute(Route route, Vehicle vehicle)
    {
        // Логіка розрахунку оптимального маршруту
        Console.WriteLine($"Optimal route calculated for {vehicle.GetType().Name} from {route.StartPoint} to {route.EndPoint}.");
    }

    public void BoardPassengers(Vehicle vehicle, int passengers)
    {
        // Логіка посадки пасажирів
        Console.WriteLine($"{passengers} passengers boarded the {vehicle.GetType().Name}.");
    }

    public void DisembarkPassengers(Vehicle vehicle, int passengers)
    {
        // Логіка висадки пасажирів
        Console.WriteLine($"{passengers} passengers disembarked from the {vehicle.GetType().Name}.");
    }
}

