namespace serialPortMonitoring
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SendText = new System.Windows.Forms.TextBox();
            this.OpenPortBtn = new System.Windows.Forms.Button();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ReciveText = new System.Windows.Forms.TextBox();
            this.PortCombo = new System.Windows.Forms.ComboBox();
            this.BuadRateCombo = new System.Windows.Forms.ComboBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.DBRingOff = new System.Windows.Forms.Button();
            this.DBRingOn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DBLedOff = new System.Windows.Forms.Button();
            this.DBLedOn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LBRingOff = new System.Windows.Forms.Button();
            this.LBRingOn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLedOff = new System.Windows.Forms.Button();
            this.LBLedOn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PortLbl = new System.Windows.Forms.Label();
            this.ClosePortBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ClearData = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SubmitDBCurrent = new System.Windows.Forms.Button();
            this.SubmitLBCurrent = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            resources.ApplyResources(this.CloseBtn, "CloseBtn");
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // SendText
            // 
            resources.ApplyResources(this.SendText, "SendText");
            this.SendText.Name = "SendText";
            // 
            // OpenPortBtn
            // 
            resources.ApplyResources(this.OpenPortBtn, "OpenPortBtn");
            this.OpenPortBtn.Name = "OpenPortBtn";
            this.OpenPortBtn.UseVisualStyleBackColor = true;
            this.OpenPortBtn.Click += new System.EventHandler(this.OpenPortBtn_Click);
            // 
            // SendBtn
            // 
            resources.ApplyResources(this.SendBtn, "SendBtn");
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ReciveText
            // 
            resources.ApplyResources(this.ReciveText, "ReciveText");
            this.ReciveText.Name = "ReciveText";
            // 
            // PortCombo
            // 
            this.PortCombo.FormattingEnabled = true;
            this.PortCombo.Items.AddRange(new object[] {
            resources.GetString("PortCombo.Items"),
            resources.GetString("PortCombo.Items1"),
            resources.GetString("PortCombo.Items2"),
            resources.GetString("PortCombo.Items3"),
            resources.GetString("PortCombo.Items4"),
            resources.GetString("PortCombo.Items5"),
            resources.GetString("PortCombo.Items6"),
            resources.GetString("PortCombo.Items7"),
            resources.GetString("PortCombo.Items8"),
            resources.GetString("PortCombo.Items9"),
            resources.GetString("PortCombo.Items10"),
            resources.GetString("PortCombo.Items11"),
            resources.GetString("PortCombo.Items12"),
            resources.GetString("PortCombo.Items13"),
            resources.GetString("PortCombo.Items14")});
            resources.ApplyResources(this.PortCombo, "PortCombo");
            this.PortCombo.Name = "PortCombo";
            // 
            // BuadRateCombo
            // 
            this.BuadRateCombo.FormattingEnabled = true;
            this.BuadRateCombo.Items.AddRange(new object[] {
            resources.GetString("BuadRateCombo.Items"),
            resources.GetString("BuadRateCombo.Items1"),
            resources.GetString("BuadRateCombo.Items2"),
            resources.GetString("BuadRateCombo.Items3"),
            resources.GetString("BuadRateCombo.Items4"),
            resources.GetString("BuadRateCombo.Items5"),
            resources.GetString("BuadRateCombo.Items6"),
            resources.GetString("BuadRateCombo.Items7")});
            resources.ApplyResources(this.BuadRateCombo, "BuadRateCombo");
            this.BuadRateCombo.Name = "BuadRateCombo";
            this.BuadRateCombo.SelectedIndexChanged += new System.EventHandler(this.BuadRateCombo_SelectedIndexChanged);
            // 
            // RefreshBtn
            // 
            resources.ApplyResources(this.RefreshBtn, "RefreshBtn");
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.SubmitDBCurrent);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.DBRingOff);
            this.panel1.Controls.Add(this.DBRingOn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DBLedOff);
            this.panel1.Controls.Add(this.DBLedOn);
            this.panel1.Controls.Add(this.label6);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Maximum = 21;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // DBRingOff
            // 
            resources.ApplyResources(this.DBRingOff, "DBRingOff");
            this.DBRingOff.Name = "DBRingOff";
            this.DBRingOff.UseVisualStyleBackColor = true;
            this.DBRingOff.Click += new System.EventHandler(this.DBRingOff_Click);
            // 
            // DBRingOn
            // 
            resources.ApplyResources(this.DBRingOn, "DBRingOn");
            this.DBRingOn.Name = "DBRingOn";
            this.DBRingOn.UseVisualStyleBackColor = true;
            this.DBRingOn.Click += new System.EventHandler(this.DBRingOn_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // DBLedOff
            // 
            resources.ApplyResources(this.DBLedOff, "DBLedOff");
            this.DBLedOff.Name = "DBLedOff";
            this.DBLedOff.UseVisualStyleBackColor = true;
            this.DBLedOff.Click += new System.EventHandler(this.DBLedOff_Click);
            // 
            // DBLedOn
            // 
            resources.ApplyResources(this.DBLedOn, "DBLedOn");
            this.DBLedOn.Name = "DBLedOn";
            this.DBLedOn.UseVisualStyleBackColor = true;
            this.DBLedOn.Click += new System.EventHandler(this.DBLedOn_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.SubmitLBCurrent);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.trackBar2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.LBRingOff);
            this.panel2.Controls.Add(this.LBRingOn);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.LBLedOff);
            this.panel2.Controls.Add(this.LBLedOn);
            this.panel2.Controls.Add(this.label9);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // trackBar2
            // 
            resources.ApplyResources(this.trackBar2, "trackBar2");
            this.trackBar2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Maximum = 21;
            this.trackBar2.Minimum = 1;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Value = 1;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // LBRingOff
            // 
            resources.ApplyResources(this.LBRingOff, "LBRingOff");
            this.LBRingOff.Name = "LBRingOff";
            this.LBRingOff.UseVisualStyleBackColor = true;
            this.LBRingOff.Click += new System.EventHandler(this.LBRingOff_Click);
            // 
            // LBRingOn
            // 
            resources.ApplyResources(this.LBRingOn, "LBRingOn");
            this.LBRingOn.Name = "LBRingOn";
            this.LBRingOn.UseVisualStyleBackColor = true;
            this.LBRingOn.Click += new System.EventHandler(this.LBRingOn_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // LBLedOff
            // 
            resources.ApplyResources(this.LBLedOff, "LBLedOff");
            this.LBLedOff.Name = "LBLedOff";
            this.LBLedOff.UseVisualStyleBackColor = true;
            this.LBLedOff.Click += new System.EventHandler(this.LBLedOff_Click);
            // 
            // LBLedOn
            // 
            resources.ApplyResources(this.LBLedOn, "LBLedOn");
            this.LBLedOn.Name = "LBLedOn";
            this.LBLedOn.UseVisualStyleBackColor = true;
            this.LBLedOn.Click += new System.EventHandler(this.LBLedOn_Click);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // PortLbl
            // 
            resources.ApplyResources(this.PortLbl, "PortLbl");
            this.PortLbl.Name = "PortLbl";
            // 
            // ClosePortBtn
            // 
            resources.ApplyResources(this.ClosePortBtn, "ClosePortBtn");
            this.ClosePortBtn.Name = "ClosePortBtn";
            this.ClosePortBtn.UseVisualStyleBackColor = true;
            this.ClosePortBtn.Click += new System.EventHandler(this.ClosePortBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            resources.ApplyResources(this.listBox1, "listBox1");
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ClearData
            // 
            resources.ApplyResources(this.ClearData, "ClearData");
            this.ClearData.Name = "ClearData";
            this.ClearData.UseVisualStyleBackColor = true;
            this.ClearData.Click += new System.EventHandler(this.ClearData_Click);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SubmitDBCurrent
            // 
            resources.ApplyResources(this.SubmitDBCurrent, "SubmitDBCurrent");
            this.SubmitDBCurrent.Name = "SubmitDBCurrent";
            this.SubmitDBCurrent.UseVisualStyleBackColor = true;
            this.SubmitDBCurrent.Click += new System.EventHandler(this.SubmitDBCurrent_Click);
            // 
            // SubmitLBCurrent
            // 
            resources.ApplyResources(this.SubmitLBCurrent, "SubmitLBCurrent");
            this.SubmitLBCurrent.Name = "SubmitLBCurrent";
            this.SubmitLBCurrent.UseVisualStyleBackColor = true;
            this.SubmitLBCurrent.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown2
            // 
            resources.ApplyResources(this.numericUpDown2, "numericUpDown2");
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClearData);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ClosePortBtn);
            this.Controls.Add(this.PortLbl);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.BuadRateCombo);
            this.Controls.Add(this.PortCombo);
            this.Controls.Add(this.ReciveText);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.OpenPortBtn);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.Button OpenPortBtn;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox ReciveText;
        private System.Windows.Forms.ComboBox PortCombo;
        private System.Windows.Forms.ComboBox BuadRateCombo;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button DBRingOff;
        private System.Windows.Forms.Button DBRingOn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DBLedOff;
        private System.Windows.Forms.Button DBLedOn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LBRingOff;
        private System.Windows.Forms.Button LBRingOn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button LBLedOff;
        private System.Windows.Forms.Button LBLedOn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label PortLbl;
        private System.Windows.Forms.Button ClosePortBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button ClearData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SubmitDBCurrent;
        private System.Windows.Forms.Button SubmitLBCurrent;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

