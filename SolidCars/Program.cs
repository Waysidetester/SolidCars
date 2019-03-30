using System.Linq;
using System.Collections.Generic;
using SolidCars.Data;
using SolidCars;
using System;

public class Program
{
    public static void Main()
    {
        var sky = new AirVehicles();
        var ground = new LandVehicles();
        var sea = new WaterVehicles();


        var x = new Cessna();
        sky._AirVehicles.Add(x);
        sky._AirVehicles.Add(new Helicopter());

        ground._LandVehicles.Add(new Motorcycle());
        ground._LandVehicles.Add(new Sedan());

        sea._WaterVehicles.Add(new JetSki());
        sea._WaterVehicles.Add(new SpeedBoat());
        // With a single `foreach`, have each vehicle Fly()
        foreach (var airVeh in sky._AirVehicles)
        {
            airVeh.Fly();
        }

        // With a single `foreach`, have each road vehicle Drive()
        foreach (var landVeh in ground._LandVehicles)
        {
            landVeh.Drive();
        }

        // With a single `foreach`, have each water vehicle Drive()
        foreach (var waterVeh in sea._WaterVehicles)
        {
            waterVeh.Drive();
        }

        Console.ReadKey();
    }
}