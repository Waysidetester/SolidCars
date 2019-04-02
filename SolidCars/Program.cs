using System;
using SolidCars.Vehicles;

public class Program
{
    public static void Main()
    {
        var vehicles = new Vechiles();

        foreach (var airVeh in vehicles.SkyVehicles)
        {
            airVeh.Fly();
        }

        foreach (var landVeh in vehicles.LandVehicles)
        {
            landVeh.Drive();
        }

        foreach (var waterVeh in vehicles.WaterVehicles)
        {
            waterVeh.Drive();
        }

        Console.ReadKey();
    }
}