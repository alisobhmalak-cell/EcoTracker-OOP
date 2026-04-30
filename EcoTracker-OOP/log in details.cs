using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
          
        
            // 1. التحقق من أن الخانات ليست فارغة
            // استبدلي textBox2 و textBox3 و textBox1 بالأسماء اللي عندك في الـ Design
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // لو فيه خانة فاضية، أظهر رسالة تحذير ووقف الكود هنا
                MessageBox.Show("Please fill in all the details (Name, Email, and Password) first!",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 2. لو البيانات كاملة، نفذ عملية الانتقال
                MessageBox.Show("Success! Your account has been created.", "Verdix Eco-Tracker");

                MainForm mainPage = new MainForm();
                mainPage.Show();
                this.Hide();
            }
        }
        

        private void log_in_details_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void log_in_details_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
