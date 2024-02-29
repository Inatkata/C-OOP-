using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }
        private const double DEFAULT_FUEL_CONSUMPTIION = 1.25;
        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUMPTIION;

        public virtual void Drive(double kilometers)
        {
            double fuelLeft = Fuel - FuelConsumption * kilometers;
            if (fuelLeft >= 0)
            {
                Fuel = fuelLeft;
            }
        }
    }
}
