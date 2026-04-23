using System;

namespace EcoTracker_OOP.Models
{
    public class Vehicle : EmissionSource
    {
        // المعامل هنا ممكن نخليه يتغير حسب نوع الوقود
        public double EmissionFactor { get; set; } = 0.21;

        public string VehicleType { get; set; } 
        public string FuelType { get; set; }    
        public Vehicle(string name, double distance, double factor) : base(name, distance)
        {
            this.EmissionFactor = factor;
        }

        public override double CalculateCarbon()
        {
            
            return ConsumptionValue * EmissionFactor;
        }

        
        public override string GetSummary()
        {
            // :F2 (هيثبت عدد الرقام من بعد العلامه هيبقى (2
            return $"Transport: {SourceName} ({VehicleType}) - Distance: {ConsumptionValue} km";
        }
    }
}
