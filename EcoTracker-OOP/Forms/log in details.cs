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
        private ErrorProvider errorProvider1;

        public log_in_details()
        {
            InitializeComponent();

            // Ensure errorProvider1 exists and is associated with this form.
            errorProvider1 = new ErrorProvider();
            errorProvider1.ContainerControl = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        
            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox1.Text))
            {
               
                MessageBox.Show("Please fill in all the details (Name, Email, and Password) first!",
                                "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        
           
            if (char.IsDigit(e.KeyChar))
            {
               
                e.Handled = true;

               
                errorProvider1.SetError(textBox2, "Names cannot contain numbers!");
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }
    }
    
}
