using System;

namespace Vehicles
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] inputCar = Console.ReadLine().Split();
            string[] inputTruck = Console.ReadLine().Split();
            string[] inputBus = Console.ReadLine().Split();


            Car car = new Car(double.Parse(inputCar[1]), double.Parse(inputCar[2]), double.Parse(inputCar[3]));
            Truck truck = new Truck(double.Parse(inputTruck[1]), double.Parse(inputTruck[2]), double.Parse(inputTruck[3]));
            Bus bus = new Bus(double.Parse(inputBus[1]), double.Parse(inputBus[2]), double.Parse(inputBus[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
                {
                    string[] info = Console.ReadLine().Split();
                    string command = info[0];
                    string type = info[1];
                    if (command == "Drive")
                    {
                        double distance = double.Parse(info[2]);
                        if (type == "Car")
                        {
                            DriveCommand(car, distance);
                        }
                        else if (type == "Truck")
                        {
                            DriveCommand(truck, distance);
                        }
                        else if (type == "Bus")
                        {
                            bus.IsEmpty = false;
                            DriveCommand(bus, distance);
                        }
                    }
                    else if (command == "Refuel")
                    {
                        double litres = double.Parse(info[2]);
                        if (type == "Car")
                        {
                            car.Refuel(litres);
                        }
                        else if (type == "Truck")
                        {
                            truck.Refuel(litres);
                        }
                        else if (type == "Bus")
                        {
                            bus.Refuel(litres);
                        }
                    }
                    else if (command == "DriveEmpty")
                    {
                        double distance = double.Parse(info[2]);
                        bus.IsEmpty = true;
                        DriveCommand(bus, distance);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Car: {Math.Round(car.FuelQuantity, 2):f2}");
            Console.WriteLine($"Truck: {Math.Round(truck.FuelQuantity, 2):f2}");
            Console.WriteLine($"Bus: {Math.Round(bus.FuelQuantity):f2}");
        }
        static void DriveCommand(Vehicles vehicle, double distance)
        {

            bool canTravel = vehicle.Drive(distance);
            if (canTravel)
            {
                Console.WriteLine($"{vehicle.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{vehicle.GetType().Name} needs refueling");
            }

        }
    }

}

