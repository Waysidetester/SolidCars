using System;
using System.Collections.Generic;
using System.Text;

namespace SolidCars.Data
{
    public class LandVehicles
    {
        public List<IVehicle> _LandVehicles { get; set; }

        public LandVehicles()
        {
            _LandVehicles = new List<IVehicle>();
        }
    }
}
