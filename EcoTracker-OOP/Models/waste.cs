using System;

namespace EcoTracker_OOP.Models
{
    public abstract class EmissionSource
    {
        public string SourceName { get; set; }
        public double ConsumptionValue { get; set; }
        public abstract double CalculateCarbon();
    }

    public enum WasteType { Plastic, Paper, Glass, FoodWaste }

    public class Waste : EmissionSource
    {
        public WasteType MyType { get; set; }

        public Waste(WasteType type, double weight)
        {
            this.SourceName = "Waste Section";
            this.MyType = type;
            this.ConsumptionValue = weight;
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
            }
            return ConsumptionValue * factor;
        }
    }
}
