using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        private bool DataExisting = true;

        public MotorStallMonitor()
        {
            InitializeComponent();
            //StallValue_chart.Series["Motor Load in %"].Points.AddXY(0, 100);
        }

        public SerialTransfer Atmega328SerialPort_Monitor { get; set; }
        public string CustomValue { get; set; }
        public DateTime now;

        

        private void CalibrateLF025_button_Click(object sender, EventArgs e)
        {
            try
            {
                Atmega328SerialPort_Monitor.CalibrateLF025LiveChart();
                /*Atmega328SerialPort_Monitor.GetSerialPort().DataReceived += MotorStallMonitor_DataReceived;
                this.myDelegate_Monitor = new AddDataDelegate(AddDataMethod);*/
               

                while (DataExisting==true)
                {
                    
                    in_data_Serial = Atmega328SerialPort_Monitor.GetSerialPort().ReadLine();
                    CanConvert = double.TryParse(in_data_Serial, out in_data_LiveChart);

                    if(in_data_LiveChart!=0)
                    {
                        if(in_data_LiveChart < 1024)
                        {
                            StallValue_chart.Series["Motor Load in %"].Points.AddXY(now, (100 - in_data_LiveChart / 10.23));
                        }
                        else
                        {
                            StallValue_chart.Series["Motor Load in %"].Points.AddXY(now, 0);
                        }
                        
                    }
                    else
                    {
                        StallValue_chart.Series["Motor Load in %"].Points.AddXY(now, 100-in_data_LiveChart);
                        DataExisting = false;
                    }
                    //Thread.Sleep(100);
                }
                DataExisting = true;

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

        /*private void MotorStallMonitor_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data_Serial = Atmega328SerialPort_Monitor.GetSerialPort().ReadLine();
            //TestTextbox.Invoke(this.myDelegate_Monitor, new Object[] { in_data_Serial });
            
            now = DateTime.Now;
            //StallValue_chart.Series["Stall Values"].Points.AddXY(now, 8);

            /*CanConvert = double.TryParse(in_data_Serial, out in_data_LiveChart);
            //in_data_LiveChart = double.Parse(in_data_Serial);

            if(CanConvert == true)
            {
                //StallValue_chart.Series["Stall Values"].Points.AddXY(now, in_data_LiveChart);
                //StallValue_chart.Series["Stall Values"].Points.AddXY(now, 8);
            }*/


        /*}

        public void AddDataMethod(String myString_Monitor)
        {
            //TestTextbox.AppendText(myString_Monitor);


            CanConvert = double.TryParse(myString_Monitor, out in_data_LiveChart);
            //in_data_LiveChart = double.Parse(in_data_Serial);

            if (CanConvert == true)
            {
                StallValue_chart.Series["Stall Values"].Points.AddXY(now, in_data_LiveChart);
                //StallValue_chart.Series["Stall Values"].Points.AddXY(now, 8);
            }
        }*/
    }
}
