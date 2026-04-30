namespace EcoTracker_OOP
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcElectricity = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.cmbDevice = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCaltWaste = new System.Windows.Forms.Button();
            this.cmbWasteType = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalcTransport = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.cmbTransportType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Device";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.cmbDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(54, 154);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(196, 282);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnCalcElectricity
            // 
            this.btnCalcElectricity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcElectricity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcElectricity.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCalcElectricity.Location = new System.Drawing.Point(63, 467);
            this.btnCalcElectricity.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcElectricity.Name = "btnCalcElectricity";
            this.btnCalcElectricity.Size = new System.Drawing.Size(168, 34);
            this.btnCalcElectricity.TabIndex = 4;
            this.btnCalcElectricity.Text = "Calculate";
            this.btnCalcElectricity.UseVisualStyleBackColor = true;
            this.btnCalcElectricity.Click += new System.EventHandler(this.btnCalcElec_Click_1);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(35, 205);
            this.txtHours.Margin = new System.Windows.Forms.Padding(2);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(115, 26);
            this.txtHours.TabIndex = 3;
            // 
            // cmbDevice
            // 
            this.cmbDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(35, 81);
            this.cmbDevice.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(115, 34);
            this.cmbDevice.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbWasteType);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Location = new System.Drawing.Point(369, 235);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(173, 251);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnCaltWaste
            // 
            this.btnCaltWaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaltWaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaltWaste.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCaltWaste.Location = new System.Drawing.Point(378, 526);
            this.btnCaltWaste.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaltWaste.Name = "btnCaltWaste";
            this.btnCaltWaste.Size = new System.Drawing.Size(164, 34);
            this.btnCaltWaste.TabIndex = 2;
            this.btnCaltWaste.Text = "Calculate";
            this.btnCaltWaste.UseVisualStyleBackColor = true;
            this.btnCaltWaste.Click += new System.EventHandler(this.btnCalcWaste_Click);
            // 
            // cmbWasteType
            // 
            this.cmbWasteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWasteType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWasteType.FormattingEnabled = true;
            this.cmbWasteType.Items.AddRange(new object[] {
            "Plastic",
            "Paper",
            "Organic"});
            this.cmbWasteType.Location = new System.Drawing.Point(29, 90);
            this.cmbWasteType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbWasteType.Name = "cmbWasteType";
            this.cmbWasteType.Size = new System.Drawing.Size(107, 34);
            this.cmbWasteType.TabIndex = 1;
            this.cmbWasteType.SelectedIndexChanged += new System.EventHandler(this.cmbWasteType_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(36, 191);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(107, 26);
            this.txtWeight.TabIndex = 0;
            this.txtWeight.TextChanged += new System.EventHandler(this.txtWeight_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtDistance);
            this.groupBox3.Controls.Add(this.cmbTransportType);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(631, 154);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(181, 282);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnCalcTransport
            // 
            this.btnCalcTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTransport.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCalcTransport.Location = new System.Drawing.Point(640, 467);
            this.btnCalcTransport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcTransport.Name = "btnCalcTransport";
            this.btnCalcTransport.Size = new System.Drawing.Size(170, 34);
            this.btnCalcTransport.TabIndex = 2;
            this.btnCalcTransport.Text = "Calculate";
            this.btnCalcTransport.UseVisualStyleBackColor = true;
            this.btnCalcTransport.Click += new System.EventHandler(this.btnCalcTransport_Click_1);
            // 
            // txtDistance
            // 
            this.txtDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistance.Location = new System.Drawing.Point(37, 205);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(2);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(123, 26);
            this.txtDistance.TabIndex = 1;
            // 
            // cmbTransportType
            // 
            this.cmbTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportType.FormattingEnabled = true;
            this.cmbTransportType.Items.AddRange(new object[] {
            "Car",
            "Bus",
            "Train"});
            this.cmbTransportType.Location = new System.Drawing.Point(20, 81);
            this.cmbTransportType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTransportType.Name = "cmbTransportType";
            this.cmbTransportType.Size = new System.Drawing.Size(140, 34);
            this.cmbTransportType.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select Vehicle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(87, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Electricity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(404, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Waste";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(685, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vehicle";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = " Usage Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Weight (Kg)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = " Distance (km)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::EcoTracker_OOP.Properties.Resources.WhatsApp_Image_2026_04_30_at_4_241;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 804);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCalcTransport);
            this.Controls.Add(this.btnCaltWaste);
            this.Controls.Add(this.btnCalcElectricity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.ComboBox cmbDevice;
        private System.Windows.Forms.Button btnCalcElectricity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbWasteType;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTransportType;
        private System.Windows.Forms.Button btnCalcTransport;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Button btnCaltWaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}