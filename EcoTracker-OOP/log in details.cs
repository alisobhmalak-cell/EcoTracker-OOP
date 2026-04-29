using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoTracker_OOP
{
    public partial class log_in_details : Form
    {
        public log_in_details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. إخفاء شاشة تسجيل الدخول
            this.Hide();

            // 2. فتح شاشة النجاح
            success_log_in successPage = new success_log_in();
            successPage.Show();
        }
    }
}
