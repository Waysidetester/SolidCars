using SolidCars.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidCars.Vehicles
{
    public class Vechiles
    {
        public List<IVehicle> SkyVehicles { get; }
        public List<IVehicle> LandVehicles { get; }
        public List<IVehicle> WaterVehicles { get; }

        public Vechiles()
        {
            SkyVehicles = new AirVehicles()._AirVehicles;
            LandVehicles = new LandVehicles()._LandVehicles;
            WaterVehicles = new WaterVehicles()._WaterVehicles;
        }
    }
}
