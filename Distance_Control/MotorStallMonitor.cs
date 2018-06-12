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


namespace Distance_Control
{
    public partial class MotorStallMonitor : Form
    {

        public delegate void AddDataDelegate(String myString_Monitor);
        public AddDataDelegate myDelegate_Monitor;
        private string in_data_Serial;
        private double in_data_LiveChart;
        private bool CanConvert = true;

        public MotorStallMonitor()
        {
            InitializeComponent();
        }

        public SerialTransfer Atmega328SerialPort_Monitor { get; set; }
        public string CustomValue { get; set; }
        public DateTime now;

        private void CalibrateLF025_button_Click(object sender, EventArgs e)
        {
            try
            {
                
                Atmega328SerialPort_Monitor.GetSerialPort().DataReceived += MotorStallMonitor_DataReceived;
                

                Atmega328SerialPort_Monitor.CalibrateLF025LiveChart();
            }

            catch (Exception)
            {

                MessageBox.Show("First Connect please");
            }

            /*now = DateTime.Now;
            StallValue_chart.Series["Stall Values"].Points.AddXY(now, 5);
            now = DateTime.Now;
            StallValue_chart.Series["Stall Values"].Points.AddXY(now, 8);*/


        }

        //_________________________________ Eventhandler Serial Receive __________________________________________

        private void MotorStallMonitor_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data_Serial = Atmega328SerialPort_Monitor.GetSerialPort().ReadLine();

            now = DateTime.Now;
            //StallValue_chart.Series["Stall Values"].Points.AddXY(now, 8);

            CanConvert = double.TryParse(in_data_Serial, out in_data_LiveChart);
            //in_data_LiveChart = double.Parse(in_data_Serial);

            if(CanConvert == true)
            {
                //StallValue_chart.Series["Stall Values"].Points.AddXY(now, in_data_LiveChart);
                StallValue_chart.Series["Stall Values"].Points.AddXY(now, 8);
            }

        }
    }
}
