using System;
using System.Collections.Generic;
using System.Text;

namespace SolidCars.Data
{
    public class AirVehicles
    {
        public List<IVehicle> _AirVehicles { get; set; }

        public AirVehicles()
        {
            _AirVehicles = new List<IVehicle>()
            {
                new Cessna(),
                new Helicopter()
            };
        }
    }
}
