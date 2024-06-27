using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboard_telemetry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Dashboard ver. 1";
        }

        /// <summary>
        /// Open Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            button_open.Text = "Opened";
        }

        /// <summary>
        /// Upon loading the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_port.Items.AddRange(ports);
            comboBox_port.SelectedIndex = 0;
            button_close.Enabled = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            button_open.Enabled = false;
            button_close.Enabled = true;
            try
            {
                serialPort1.PortName = comboBox_port.Text;
                serialPort1.Open();
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_Recieve_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart7_Click(object sender, EventArgs e)
        {

        }
    }
}
