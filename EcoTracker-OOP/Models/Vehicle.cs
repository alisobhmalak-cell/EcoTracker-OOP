using System;

namespace EcoTracker_OOP.Models
{
    public enum VehicleType { Petrol_Car, Diesel_Car, Electric_Car, Petrol_Bus, Diesel_Bus, Motorcycle, Truck }
    public class Vehicle : EmissionSource
    {
        // المعامل هنا ممكن نخليه يتغير حسب نوع الوقود
        public VehicleType MyVehicleType { get; set; }
        public Vehicle(VehicleType type, double distance) : base("Transport", distance)
        {
            this.MyVehicleType = type;
            this.SourceName = "Vehicle: " + type.ToString();
        }
        public override double CalculateCarbon()
        {
            double factor = 0;
            switch (MyVehicleType)
            {
                case VehicleType.Petrol_Car: factor = 0.21; break;
                case VehicleType.Diesel_Car: factor = 0.18; break;
                case VehicleType.Electric_Car: factor = 0.05; break; 
                case VehicleType.Motorcycle: factor = 0.1; break;
                case VehicleType.Petrol_Bus: factor = 0.85; break;
                case VehicleType.Diesel_Bus: factor = 0.8; break;
                case VehicleType.Truck: factor = 1.1; break;
            }
            return ConsumptionValue * factor;
        }


        public override string GetSummary()
        {

            return $"[Vehicle] Type: {MyVehicleType}, Distance: {ConsumptionValue} km - Emissions: {CalculateCarbon():F2} kg CO2";
        }
    }
}
