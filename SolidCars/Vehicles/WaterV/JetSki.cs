﻿using System;

namespace SolidCars
{
    public class JetSki : IVehicle
    {
        public int Wheels { get; set; } = 0;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "automatic";
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; } = 110;
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("The jetski zips through the waves with the greatest of ease");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            throw new NotImplementedException();
        }
        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
