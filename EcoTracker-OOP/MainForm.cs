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

        }





        private void btnCalcElec_Click_1(object sender, EventArgs e)
        {
            
       
            try
            {
                // 1. تحويل القيمة من الـ ComboBox لنوع الـ Enum
                DeviceType selectedDevice = (DeviceType)Enum.Parse(typeof(DeviceType), cmbDevice.Text);

                // 2. أخذ الساعات من الـ TextBox
                double hours = double.Parse(txtHours.Text);

                // 3. إنشاء الكائن بالترتيب الصحيح (النوع أولاً ثم القيمة)
                Electricity electricityEntry = new Electricity(selectedDevice, hours);

                // 4. عرض النتيجة
                MessageBox.Show(electricityEntry.GetSummary(), "نتائج استهلاك الكهرباء");
            }
            catch (Exception ex)
            {
                MessageBox.Show("تأكدي من إدخال البيانات بشكل صحيح : " + ex.Message);
            }
        }

        
        private void btnCalcWaste_Click(object sender, EventArgs e)
        {
            
            try
            {
                // 1. تحويل القيمة المختارة من الـ ComboBox إلى نوع النفايات (Enum)
                WasteType selectedWaste = (WasteType)Enum.Parse(typeof(WasteType), cmbWasteType.Text);

                // 2. أخذ قيمة الوزن من الـ TextBox وتحويلها إلى رقم (double)
                double weight = double.Parse(txtWeight.Text);

                // 3. إنشاء كائن جديد من كلاس النفايات بالترتيب الصحيح (النوع ثم الوزن)
                Waste wasteCalc = new Waste(selectedWaste, weight);

                // 4. عرض ملخص النتائج في رسالة تنبثق للمستخدم
                MessageBox.Show(wasteCalc.GetSummary(), "نتائج النفايات");
            }
            catch (Exception ex)
            {
                // عرض رسالة تنبيه في حال وجود خطأ في إدخال البيانات
                MessageBox.Show("يرجى التأكد من الاختيارات : " + ex.Message);
            }
        }
        

        private void btnCalcTransport_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                // تحويل القيمة المختارة من القائمة إلى نوع المركبة
                VehicleType selectedVehicle = (VehicleType)Enum.Parse(typeof(VehicleType), cmbTransportType.Text);

                // أخذ المسافة من مربع النص وتحويلها لرقم
                double distance = double.Parse(txtDistance.Text);

                // الترتيب: النوع ثم المسافة
                // إنشاء كائن جديد من كلاس المركبة
                Vehicle vehicleCalc = new Vehicle(selectedVehicle, distance);

                // عرض ملخص النتائج في رسالة
                MessageBox.Show(vehicleCalc.GetSummary(), "نتائج انبعاثات النقل");
            }
            catch (Exception ex)
            {
                // عرض رسالة خطأ في حال إدخال بيانات غير صحيحة
                MessageBox.Show("خطأ في البيانات: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    
}



