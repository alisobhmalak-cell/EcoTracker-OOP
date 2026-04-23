using System;

namespace EcoTracker_OOP.Models

{

    public class Vehicle : EmissionSource
    {
   
        private const double EmissionFactor = 0.21;

        public Vehicle(double distance) : base("Vehicle Transport", distance)  
        {
        }

        public override double CalculateCarbon()
        {
            return ConsumpitionValue * EmissionFactor;
        }
    }
}

