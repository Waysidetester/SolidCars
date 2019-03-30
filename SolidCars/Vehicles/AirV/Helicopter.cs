using System;

namespace SolidCars
{
    public class Helicopter : IVehicle
    {
        public int Wheels { get; set; } = 8;
        public int Doors { get; set; } = 4;
        public int PassengerCapacity { get; set; } = 10;
        public bool Winged { get; set; } = false;
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 31.1;
        public double MaxWaterSpeed { get; set; }
        public double MaxLandSpeed { get; set; }
        public double MaxAirSpeed { get; set; } = 116;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("The Helicopter effortlessly glides over the terrain like a gleaming god of the Sun");
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
