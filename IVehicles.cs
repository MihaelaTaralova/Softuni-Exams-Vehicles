using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicles
    {
        double FuelQuantity { get; }
        double FuelConsumption { get; }
        double TankCapacity { get; }

        bool Drive(double distance);
        void Refuel(double fuel);


    }
}
