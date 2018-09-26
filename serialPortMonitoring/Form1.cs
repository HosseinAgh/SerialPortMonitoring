using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serialPortMonitoring
{
    public partial class Form1 : Form
    {
        String StrRecive;
        String strbaud;
        public Form1()
        {
            InitializeComponent();
            DBLedOff.BackColor = System.Drawing.Color.Red;
            LBLedOff.BackColor = System.Drawing.Color.Red;
            DBRingOff.BackColor = System.Drawing.Color.Red;
            LBRingOff.BackColor = System.Drawing.Color.Red;
          //  DBLedOff.ForeColor = System.Drawing.Color.White;
          //  LBLedOff.ForeColor = System.Drawing.Color.White;


        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void OpenPortBtn_Click(object sender, EventArgs e)
        {
            strbaud = BuadRateCombo.Text;
            serialPort1.Close();

            try
            {
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.BaudRate = int.Parse(strbaud);
                serialPort1.PortName = PortCombo.Text;
                serialPort1.Open();
                serialPort1.DiscardInBuffer();
                PortLbl.BackColor = System.Drawing.Color.Green;
                PortLbl.ForeColor = System.Drawing.Color.White;
                PortLbl.Text = "( " + PortCombo.Text + ") Connected";
            }
            catch
            {
                PortLbl.Text = "Disconnected";
                PortLbl.BackColor = System.Drawing.Color.Red;
                PortLbl.ForeColor = System.Drawing.Color.White;
                MessageBox.Show("Can't access " + "(" + PortCombo.Text + ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuadRateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            strbaud = BuadRateCombo.Text;

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.BaudRate = int.Parse(strbaud);
                    serialPort1.DiscardInBuffer();
                    PortLbl.BackColor = System.Drawing.Color.Green;
                    PortLbl.ForeColor = System.Drawing.Color.White;
                    PortLbl.Text = "( " + PortCombo.Text + ") Connected";
                }
            }
            catch
            {
                PortLbl.Text = "Disconnected";
                PortLbl.BackColor = System.Drawing.Color.Red;
                PortLbl.ForeColor = System.Drawing.Color.White;
                MessageBox.Show("Can't access " + "(" + PortCombo.Text + ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClosePortBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                PortLbl.Text = "Disconnected";
                PortLbl.BackColor = System.Drawing.Color.Red;
                PortLbl.ForeColor = System.Drawing.Color.White;
                MessageBox.Show("Port (" + PortCombo.Text + ") is Closed", "Close Port", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                listBox1.Items.Add(s);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string s in SerialPort.GetPortNames())
            {
                listBox1.Items.Add(s);
            }
        }
        // available to doble click in available list port and open port
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PortCombo.Text = listBox1.Text;
            strbaud = BuadRateCombo.Text;
            serialPort1.Close();

            try
            {
                serialPort1.DataBits = 8;
                serialPort1.Parity = Parity.None;
                serialPort1.StopBits = StopBits.One;
                serialPort1.BaudRate = int.Parse(strbaud);
                serialPort1.PortName = PortCombo.Text;
                serialPort1.Open();
                serialPort1.DiscardInBuffer();
                PortLbl.BackColor = System.Drawing.Color.Green;
                PortLbl.ForeColor = System.Drawing.Color.White;
                PortLbl.Text = "( " + PortCombo.Text + ") Connected";
            }
            catch
            {
                PortLbl.Text = "Disconnected";
                PortLbl.BackColor = System.Drawing.Color.Red;
                PortLbl.ForeColor = System.Drawing.Color.White;
                MessageBox.Show("Can't access " + "(" + PortCombo.Text + ")", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(SendText.Text);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            StrRecive = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(DisplayText));
        }

        private void DisplayText(object sender , EventArgs e)
        {
            ReciveText.AppendText(StrRecive);

            //data recive to switch button for Dark box
            if (StrRecive == "DBLedOn\n")
            {
                MessageBox.Show("ok");
                DBLedOn.BackColor = System.Drawing.Color.Green;
                DBLedOff.BackColor = System.Drawing.Color.Empty;
            }
            else if (StrRecive == "DBLedOff\n")
            {
                DBLedOn.BackColor = System.Drawing.Color.Empty;
                DBLedOff.BackColor = System.Drawing.Color.Red;
            }
            //data recive to switch Led Button for Light Box
            else if (StrRecive == "LBLedOn\n")
            {
                LBLedOn.BackColor = System.Drawing.Color.Green;
                LBLedOff.BackColor = System.Drawing.Color.Empty;
            }
            else if (StrRecive == "LBLedOff\n")
            {
                LBLedOn.BackColor = System.Drawing.Color.Empty;
                LBLedOff.BackColor = System.Drawing.Color.Red;
            }
            //data recive to switch ring button fore Dark Box
            else if(StrRecive == "DBRingOn\n")
            {
                DBRingOn.BackColor = System.Drawing.Color.Green;
                DBRingOff.BackColor = System.Drawing.Color.Empty;
            }
            else if(StrRecive == "DBRingOff\n")
            {
                DBRingOn.BackColor = System.Drawing.Color.Empty;
                DBRingOff.BackColor = System.Drawing.Color.Red;
            }
            //data recive to switch ring button fore Light Box
            else if (StrRecive == "LBRingOn\n")
            {
                LBRingOn.BackColor = System.Drawing.Color.Green;
                LBRingOff.BackColor = System.Drawing.Color.Empty;
            }
            else if (StrRecive == "LBRingOff\n")
            {
                LBRingOn.BackColor = System.Drawing.Color.Empty;
                LBRingOff.BackColor = System.Drawing.Color.Red;
            }

        }

        private void ClearData_Click(object sender, EventArgs e)
        {
            SendText.Text = "";
            ReciveText.Text = "";
        }

        private void DBLedOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("DBLedOn");
            }
        }

        private void DBLedOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("DBLedOff");
            }
        }

        private void LBLedOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("LBLedOn");
            }
        }

        private void LBLedOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("LBLedOff");
            }
        }

        private void DBRingOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("DBRingOn");
            }
        }

        private void DBRingOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("DBRingOff");
            }
        }

        private void LBRingOn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("LBRingOn");
            }
        }

        private void LBRingOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("LBRingOff");
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = ((float)(trackBar1.Value) / 10).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SubmitDBCurrent_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("Dark Box Current " + ((float)(trackBar1.Value) / 10).ToString() + " time " + numericUpDown1.Value.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("Light Box Current " + ((float)(trackBar2.Value) / 10).ToString() + " time " + numericUpDown2.Value.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = ((float)(trackBar2.Value) / 10).ToString();
        }
    }
}
