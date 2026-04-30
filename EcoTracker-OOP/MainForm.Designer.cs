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
            this.cmbWasteType = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCalcTransport = new System.Windows.Forms.Button();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.cmbTransportType = new System.Windows.Forms.ComboBox();
            this.btnCaltWaste = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Device";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalcElectricity);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.cmbDevice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(107, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 443);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Electricity";
            // 
            // btnCalcElectricity
            // 
            this.btnCalcElectricity.Location = new System.Drawing.Point(48, 329);
            this.btnCalcElectricity.Name = "btnCalcElectricity";
            this.btnCalcElectricity.Size = new System.Drawing.Size(172, 45);
            this.btnCalcElectricity.TabIndex = 4;
            this.btnCalcElectricity.Text = "Calculate";
            this.btnCalcElectricity.UseVisualStyleBackColor = true;
            this.btnCalcElectricity.Click += new System.EventHandler(this.btnCalcElec_Click_1);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(48, 243);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(172, 38);
            this.txtHours.TabIndex = 3;
            this.txtHours.Text = "txtHours";
            // 
            // cmbDevice
            // 
            this.cmbDevice.FormattingEnabled = true;
            this.cmbDevice.Location = new System.Drawing.Point(48, 157);
            this.cmbDevice.Name = "cmbDevice";
            this.cmbDevice.Size = new System.Drawing.Size(172, 39);
            this.cmbDevice.TabIndex = 2;
            this.cmbDevice.Text = "cmbDevice";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCaltWaste);
            this.groupBox2.Controls.Add(this.cmbWasteType);
            this.groupBox2.Controls.Add(this.txtWeight);
            this.groupBox2.Location = new System.Drawing.Point(709, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 443);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Waste";
            // 
            // cmbWasteType
            // 
            this.cmbWasteType.FormattingEnabled = true;
            this.cmbWasteType.Items.AddRange(new object[] {
            "Plastic",
            "Paper",
            "Organic"});
            this.cmbWasteType.Location = new System.Drawing.Point(54, 77);
            this.cmbWasteType.Name = "cmbWasteType";
            this.cmbWasteType.Size = new System.Drawing.Size(174, 39);
            this.cmbWasteType.TabIndex = 1;
            this.cmbWasteType.Text = "cmbWasteType";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(54, 223);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(172, 38);
            this.txtWeight.TabIndex = 0;
            this.txtWeight.Text = "Weight";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCalcTransport);
            this.groupBox3.Controls.Add(this.txtDistance);
            this.groupBox3.Controls.Add(this.cmbTransportType);
            this.groupBox3.Location = new System.Drawing.Point(1294, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(305, 443);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transportation";
            // 
            // btnCalcTransport
            // 
            this.btnCalcTransport.Location = new System.Drawing.Point(39, 327);
            this.btnCalcTransport.Name = "btnCalcTransport";
            this.btnCalcTransport.Size = new System.Drawing.Size(202, 47);
            this.btnCalcTransport.TabIndex = 2;
            this.btnCalcTransport.Text = "Calculate Transport";
            this.btnCalcTransport.UseVisualStyleBackColor = true;
            this.btnCalcTransport.Click += new System.EventHandler(this.btnCalcTransport_Click_1);
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(39, 203);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(202, 38);
            this.txtDistance.TabIndex = 1;
            this.txtDistance.Text = "Distance (KM)";
            // 
            // cmbTransportType
            // 
            this.cmbTransportType.FormattingEnabled = true;
            this.cmbTransportType.Items.AddRange(new object[] {
            "Car",
            "Bus",
            "Train"});
            this.cmbTransportType.Location = new System.Drawing.Point(6, 77);
            this.cmbTransportType.Name = "cmbTransportType";
            this.cmbTransportType.Size = new System.Drawing.Size(276, 39);
            this.cmbTransportType.TabIndex = 0;
            this.cmbTransportType.Text = "cmbTransportType";
            // 
            // btnCaltWaste
            // 
            this.btnCaltWaste.Location = new System.Drawing.Point(42, 322);
            this.btnCaltWaste.Name = "btnCaltWaste";
            this.btnCaltWaste.Size = new System.Drawing.Size(200, 50);
            this.btnCaltWaste.TabIndex = 2;
            this.btnCaltWaste.Text = "Calculate";
            this.btnCaltWaste.UseVisualStyleBackColor = true;
            this.btnCaltWaste.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1781, 1329);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}