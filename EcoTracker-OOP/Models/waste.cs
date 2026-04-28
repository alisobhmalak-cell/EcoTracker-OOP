using System;

namespace EcoTracker_OOP.Models
{
    public enum WasteType { Plastic, Paper, Glass, FoodWaste, Metal, Electronics, Mixed }

    public class Waste : EmissionSource
    {
        public WasteType MyType { get; set; }

        public Waste(WasteType type, double weight) : base("Waste", weight)
        {
            this.MyType = type;
            this.ConsumptionValue = weight;
            this.SourceName = "Waste: " + type.ToString();
        }

        public override double CalculateCarbon()
        {
            double factor = 0;
            switch (MyType)
            {
                case WasteType.Plastic: factor = 2.5; break;
                case WasteType.Paper: factor = 0.5; break;
                case WasteType.Glass: factor = 0.2; break;
                case WasteType.FoodWaste: factor = 0.1; break;
                case WasteType.Metal: factor = 1.8; break;       
                case WasteType.Electronics: factor = 3.5; break; 
                case WasteType.Mixed: factor = 1.2; break;     
            }
            return ConsumptionValue * factor;
        }
        public override string GetSummary()
        {
            return $"[Waste] Material: {MyType}, Weight: {ConsumptionValue} kg - Carbon Footprint: {CalculateCarbon():F2} kg CO2";
        }
    }
}
