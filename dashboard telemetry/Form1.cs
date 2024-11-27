using System.Timers;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dashboard_telemetry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Telemetry Dashboard V1.0";
        }

        /// <summary>
        /// Open Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            button_open.Text = "Opened";
            button_open.Enabled = true;
            button_close.Enabled = false;
            try
            {
                serialPort1.PortName = comboBox_port.Text;
                serialPort1.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            serialPort1.BaudRate = Convert.ToInt32(comboBoxbaud.Text);

        }

        /// <summary>
        /// Upon loading the Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                comboBox_port.Items.Add(port);
            }
            button_close.Enabled = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            button_open.Enabled = false;
            button_close.Enabled = true;
            serialPort1.Close();

        }

        private void textBox_Recieve_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            {
                 tBoxDataIN.Text = serialPort1.ReadLine();
                timer1.Tick += timer1_Tick;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           if(button_open.Enabled == true)
            {
                  receive.Enabled = true;
            }
            if (receive.Enabled == true)
            {
                if (serialPort1.IsOpen)
                {
                            //System.Timers.Timer dataTimer = new System.Timers.Timer();
                            //dataTimer.Elapsed += new ElapsedEventHandler(ReadData);
                            //dataTimer.Interval = 100;
                            // dataTimer.Enabled = true;
                            //tBoxDataIN.Text = serialPort1.ReadLine();
                            timer1.Enabled = true;
                    
                   
                }
            }
            

        }

        private static void ReadData(object source, ElapsedEventArgs e)
        {
          
               // tBoxDataIN.Text = serialPort1.ReadLine();
               // Console.WriteLine("Hello World!");

        } 

        private void chart7_Click(object sender, EventArgs e)
        {

        }

        private void label_port_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_port_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
