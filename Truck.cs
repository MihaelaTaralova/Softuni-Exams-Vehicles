using System;

namespace Vehicles
{
    public class Truck : Vehicles
    {
        private const double AirConsumption = 1.6;
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AirConsumption;
        }
        public override void Refuel(double fuel)
        {
            if (this.FuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            fuel *= 0.95;
            base.Refuel(fuel);
        }

    }
}
