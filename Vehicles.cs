using System;

namespace Vehicles
{
    public abstract class Vehicles : IVehicles
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vehicles(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            
        }

        public double FuelQuantity
        {
            get
            {
                return this.fuelQuantity;
            }
            protected set
            {
                if (value > this.tankCapacity)
                {
                    fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public virtual double FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }
            protected set
            {
                this.fuelConsumption = value;
            }
        }
        public double TankCapacity 
        {
            get
            {
                return this.tankCapacity;
            }
            protected set
            {
                this.tankCapacity = value;
            }
        }

        public virtual bool Drive(double distance)
        {
            bool canDrive = this.FuelQuantity - this.FuelConsumption * distance >= 0;
            if (canDrive)
            {
                this.fuelQuantity -= this.FuelConsumption * distance;
                return true;
            }
            return false;
        }

        public virtual void Refuel(double fuel)
        {
            if(fuel <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }
            if (this.fuelQuantity + fuel > TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {fuel} fuel in the tank");
            }
            else
            {
                this.fuelQuantity += fuel;
               
            }
        }

    }
}
