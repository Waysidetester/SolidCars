using System;
using System.Collections.Generic;
using System.Text;

namespace SolidCars
{
    public class Sedan : IVehicle
    {
        
            public int Wheels { get; set; } = 4;
            public int Doors { get; set; } = 4;
            public int PassengerCapacity { get; set; } = 5;
            public bool Winged { get; set; } = false;
            public string TransmissionType { get; set; } = "Manual";
            public double EngineVolume { get; set; } = 6;
            public double MaxWaterSpeed { get; set; }
            public double MaxLandSpeed { get; set; } = 160.4;
            public double MaxAirSpeed { get; set; }

            public void Drive()
            {
                Console.WriteLine("The Sedan screams down the highway");
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
