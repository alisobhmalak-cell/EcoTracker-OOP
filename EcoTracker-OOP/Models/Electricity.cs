using System;
using System.Collections.Generic;
using System.Text;

namespace EcoTracker_OOP.Models
{
    public enum DeviceType
    {
        Fridge, Freezer, Microwave, WashingMachine,
        DishWasher, AC, Fan, Lights, TV,
        Vacuum, WaterHeater, ElectricKettle, Bell
    }
    public class Electricity : EmissionSource
    {

        // constructor عشان نبعت البيانات للأب
        public Electricity(DeviceType device, double hours) : base("Electricity", hours)
        {
            this.MyDevice = device;
            this.UsageHours = hours;
            this.SourceName = "Device: " + device.ToString();
        }

        // خصائص الجهاز(propertise)
        public DeviceType MyDevice { get; set; }
        public double UsageHours { get; set; }

        // 3. دالة الحساب الموحدة (Override)
        public override double CalculateCarbon()
        {
            double factor = 0;
            switch (MyDevice)
            {
                case DeviceType.AC: factor = 1.5; break;
                case DeviceType.WaterHeater: factor = 2.0; break;
                case DeviceType.ElectricKettle: factor = 1.8; break;
                case DeviceType.Microwave: factor = 1.2; break;
                case DeviceType.WashingMachine: factor = 0.5; break;
                case DeviceType.DishWasher: factor = 0.6; break;
                case DeviceType.Freezer: factor = 0.4; break;
                case DeviceType.Fridge: factor = 0.3; break;
                case DeviceType.Vacuum: factor = 0.7; break;
                case DeviceType.TV: factor = 0.15; break;
                case DeviceType.Fan: factor = 0.08; break;
                case DeviceType.Lights: factor = 0.05; break;
                case DeviceType.Bell: factor = 0.01; break;
                default: factor = 0.1; break;
            }
            
            return UsageHours * factor;
        }
        // :F2 (هيثبت عدد الرقام من بعد العلامه العشريه هيبقى (2
        public override string GetSummary()
        {
            return $"[Electricity] Device: {MyDevice}, Usage: {UsageHours} hours - Emissions: {CalculateCarbon():F2} kg CO2";
        }
    } 
}