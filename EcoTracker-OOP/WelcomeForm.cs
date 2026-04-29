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
    public partial class WelcomeForm : Form
    {
        bool dragging = false;
        Point startPoint = new Point(0, 0);
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            // بنخلي الصورة هي الحاضن (Parent) للزراير عشان الشفافية تشتغل صح
            button1.Parent = pictureBox1; // استبدلي button1 باسم الزرار الأول عندك
            button2.Parent = pictureBox1; // ده زرار Close اللي إنتِ عاملاه

            // بنخلي الخلفية شفافة
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;

            // ملحوظة: لو الزراير مكانها اتغير أو اختفت، هنحتاج نظبط الـ Location يدوي
            // button2.Location = new Point(700, 10); // مثال لمكان زرار القفل
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
