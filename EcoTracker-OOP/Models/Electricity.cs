using System;
using System.Collections.Generic; 
using System.Text;

namespace CarponOS;

    public class Electricity : EmissionActivity
    {
    // خصائص الجهاز(propertise)
    public string DeviceName { get; set; }
    public double ConsumptionRate { get; set; }
    public double UsageHours { get; set; }
    public double Emission(int Days)   // دالة لحساب الانبعاثات بناءً علي عدد الايام
    {
        return ConsumptionRate * UsageHours * Days * 0.5;

    }
}



