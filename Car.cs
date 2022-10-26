namespace Vehicles
{
    public class Car : Vehicles
    {
        private const double AirConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += AirConsumption;
        }

    
    }
}
