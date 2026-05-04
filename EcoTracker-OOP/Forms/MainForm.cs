using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EcoTracker_OOP.Models;
namespace EcoTracker_OOP
{
    public partial class MainForm : Form
    {
        EmissionSource calc;
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbDevice.DataSource = Enum.GetValues(typeof(DeviceType));
            cmbWasteType.DataSource = Enum.GetValues(typeof(WasteType));
            cmbTransportType.DataSource = Enum.GetValues(typeof(VehicleType));
            cmbDevice.SelectedIndex = -1;
            cmbWasteType.SelectedIndex = -1;
            cmbTransportType.SelectedIndex = -1;
        }





        private void btnCalcElec_Click_1(object sender, EventArgs e)
        {
            
       
            try
            {
               
                DeviceType selectedDevice = (DeviceType)Enum.Parse(typeof(DeviceType), cmbDevice.Text);

               
                double hours = double.Parse(txtHours.Text);

               
                Electricity electricityEntry = new Electricity(selectedDevice, hours);

            
                MessageBox.Show(electricityEntry.GetSummary(), "Electricity Consumption Results");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Please Enter Correct Data: " + ex.Message);
            }
        }

        
        private void btnCalcWaste_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                WasteType selectedWaste = (WasteType)Enum.Parse(typeof(WasteType), cmbWasteType.Text);

             
                double weight = double.Parse(txtWeight.Text);

               
                Waste wasteCalc = new Waste(selectedWaste, weight);

              
                MessageBox.Show(wasteCalc.GetSummary(), "Waste Consumption Results");
            }
            catch (Exception ex)
            {
             
                MessageBox.Show("Please Enter Correct Data: " + ex.Message);
            }
        }
        

        private void btnCalcTransport_Click_1(object sender, EventArgs e)
        {
            
            try
            {
               
                VehicleType selectedVehicle = (VehicleType)Enum.Parse(typeof(VehicleType), cmbTransportType.Text);

               
                double distance = double.Parse(txtDistance.Text);

                
                
                Vehicle vehicleCalc = new Vehicle(selectedVehicle, distance);

                MessageBox.Show(vehicleCalc.GetSummary(), "Vehicle Consumption Results");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Please Enter Correct Data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbWasteType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}



