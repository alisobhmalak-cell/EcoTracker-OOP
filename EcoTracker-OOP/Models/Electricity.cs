using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTracker_OOP.Models
{
    public class Electricity : EmissionSource
    {

        // constructor عشان نبعت البيانات للأب
        public Electricity(string name, double consumption, double factor) : base(name, consumption)
        {
            this.EmissionFactor = factor;
        }

        // خصائص الجهاز(propertise)
        public double EmissionFactor { get; set; } = 0.5;
        public string DeviceName { get; set; }
        public double ConsumptionRate { get; set; }
        public double UsageHours { get; set; }

        // 3. دالة الحساب الموحدة (Override)
        public override double CalculateCarbon()
        {

            // هنا استخدمنا ال consumptionvalue (اللى جايه من الاب (كأنها عدد الايام 
            return ConsumptionRate * UsageHours * ConsumptionValue * EmissionFactor;
        }

        // :F2 (هيثبت عدد الرقام من بعد العلامه العشريه هيبقى (2
        public override string GetSummary()
        {
            return $"[Electricity] {DeviceName}: {CalculateCarbon():F2} kg CO2";
        }
    } 
}