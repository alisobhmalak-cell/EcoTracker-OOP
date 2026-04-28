using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTracker_OOP.Models
{
        public abstract class EmissionSource
        {

            public string SourceName { get; set; }
            public double ConsumptionValue { get; set; }
            public EmissionSource(string name, double value)
            {
                this.SourceName = name;
                this.ConsumptionValue = value;
            }


            public abstract double CalculateCarbon();


            public virtual string GetSummary()
            {
                return $"{SourceName}: {CalculateCarbon():F2} kg CO2";
            }
        }

}
