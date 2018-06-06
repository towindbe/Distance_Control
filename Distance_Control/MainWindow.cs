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
    public partial class MainWindow : Form
    {

        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;






        public MainWindow()
        {
            InitializeComponent();
            CalibrateLF025_button.Enabled = false;



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ComPorts = SerialPort.GetPortNames();
            ComPort_combobox.Items.AddRange(ComPorts);

            if(ComPort_combobox.Items.Count != 0 )
            {
                ComPort_combobox.SelectedIndex = 0;
            }
            
            Disconnect_button.Enabled = false;
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            Connect_button.Enabled = false;
            Disconnect_button.Enabled = true;
            try
            {
                ComPort_label.Text = "Serial Port:      connected";
                CalibrateLF025_button.Enabled = true;
                Atmega328SerialPort.PortName = ComPort_combobox.Text;
                Atmega328SerialPort.BaudRate = 250000;
                Atmega328SerialPort.Open();
                Atmega328SerialPort.DataReceived += Atmega328SerialPort_DataReceived;
                this.myDelegate = new AddDataDelegate(AddDataMethod);
                //status_Block.Text = "Connected";

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Atmega328SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string in_data = Atmega328SerialPort.ReadExisting();
            ReceivedData_textbox.Invoke(this.myDelegate, new Object[] { in_data });
        }

        public void AddDataMethod(String myString)
        {
            ReceivedData_textbox.AppendText(myString);
        }

        private void Calibrate06_button_Click(object sender, EventArgs e)
        {
            try
            {
                Atmega328SerialPort.Write("cxxx");
                
            }

            catch (Exception)
            {

                MessageBox.Show("First Connect please");
            }
        }

        private void ClearReceived_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Atmega328SerialPort.IsOpen)
                {

                    {
                        ReceivedData_textbox.Clear();
                    }


                }
            }

            catch (Exception)
            {

                MessageBox.Show("nothing received");
            }
        }

        private void Disconnect_button_Click(object sender, EventArgs e)
        {
            try
            {
                ComPort_label.Text = "Serial Port:";
                CalibrateLF025_button.Enabled = false;
                Connect_button.Enabled = true;
                Atmega328SerialPort.Close();                

            }
            catch (Exception)
            {

                MessageBox.Show("First Connect and then disconnect");
            }
        }

        

        
    }
}
