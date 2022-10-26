using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Bus : Vehicles
    {
        private double airCondition = 1.4;
        private double defaultFuelConsumption;


        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.defaultFuelConsumption = fuelConsumption;
            this.airCondition += fuelConsumption;
        }

        public bool IsEmpty { get; set; }

        public override bool Drive(double distance)
        {
            if(!this.IsEmpty)
            {
                this.FuelConsumption = this.airCondition;
            }
            else
            {
                this.FuelConsumption = defaultFuelConsumption;
            }

            return base.Drive(distance);
            
        }
    }
}
