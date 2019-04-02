using System;
using System.Collections.Generic;
using System.Text;

namespace SolidCars.Data
{
    public class WaterVehicles
    {
        public List<IVehicle> _WaterVehicles { get; set; }

        public WaterVehicles()
        {
            _WaterVehicles = new List<IVehicle>
            {
                new JetSki(),
                new SpeedBoat()
            };
        }
    }
}
