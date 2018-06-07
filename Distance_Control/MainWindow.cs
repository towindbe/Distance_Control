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
               

        public SerialTransfer Atmega328SerialPort = new SerialTransfer();

        private int TrackBarDefault = 15;
        

        public MainWindow()
        {
            InitializeComponent();
            CalibrateLF025_button.Enabled = false;
            RemoveElectrode_button.Enabled = false;
            ResetHardware_button.Enabled = false;
            Disconnect_button.Enabled = false;
            StallValue_groupbox.Enabled = false;
            SetStallValue_button.Enabled = false;
            Sensitivity_groupbox.Enabled = false;
            SetSensitivity_button.Enabled = false;



        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            string[] ComPorts = SerialPort.GetPortNames();
            ComPort_combobox.Items.AddRange(ComPorts);

            if(ComPort_combobox.Items.Count != 0 )
            {
                ComPort_combobox.SelectedIndex = 0;
            }            
            
        }

        private void Connect_button_Click(object sender, EventArgs e)
        {
            Connect_button.Enabled = false;
            Disconnect_button.Enabled = true;
            ResetHardware_button.Enabled = true;
            StallValue_groupbox.Enabled = true;
            Sensitivity_groupbox.Enabled = true;
            try
            {
                ComPort_label.Text = "Serial Port:      connected";
                CalibrateLF025_button.Enabled = true;
                RemoveElectrode_button.Enabled = true;
                Atmega328SerialPort.InitializeSerialPort(ComPort_combobox.Text);
                Atmega328SerialPort.GetSerialPort().DataReceived += Atmega328SerialPort_DataReceived;
                this.myDelegate = new AddDataDelegate(AddDataMethod);             
                
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //_________________________________ Eventhandler Serial Receive __________________________________________    

        private void Atmega328SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string in_data = Atmega328SerialPort.GetSerialPort().ReadExisting();
            ReceivedData_textbox.Invoke(this.myDelegate, new Object[] { in_data });
        }

        public void AddDataMethod(String myString)
        {
            ReceivedData_textbox.AppendText(myString);
        }
        //________________________________________________________________________________________________________
        
        private void CalibrateLF025_button_Click(object sender, EventArgs e)
        {
            try
            {
                Atmega328SerialPort.CalibrateLF025();   // 0.6 mm distance              
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
                if (Atmega328SerialPort.GetSerialPort().IsOpen)
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
                RemoveElectrode_button.Enabled = false;
                Connect_button.Enabled = true;
                ResetHardware_button.Enabled = false;
                StallValue_groupbox.Enabled = false;
                Sensitivity_groupbox.Enabled = false;
                Atmega328SerialPort.GetSerialPort().Close();                

            }
            catch (Exception)
            {

                MessageBox.Show("First Connect and then disconnect");
            }
        }

        private void RemoveElectrode_button_Click(object sender, EventArgs e)
        {
            try
            {
                Atmega328SerialPort.RemoveElectrode();                
            }

            catch (Exception)
            {

                MessageBox.Show("First Connect please");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 xu = new Form1();
            xu.Show();
        }

        private void ResetHardware_button_Click(object sender, EventArgs e)
        {
            try
            {
                Atmega328SerialPort.HardwareReset();
            }

            catch (Exception)
            {

                MessageBox.Show("First Connect please");
            }
        }

        private void StallValue_textbox_TextChanged(object sender, EventArgs e)
        {
            SetStallValue_button.Enabled = true;

        }

        private void SetStallValue_button_Click(object sender, EventArgs e)
        {

            try
            {

                if (Atmega328SerialPort.GetPortStatus())
                {
                    
                    Atmega328SerialPort.SetStallValue(Int32.Parse(StallValue_textbox.Text));


                    StallValue_textbox.Clear();
                    SetStallValue_button.Enabled = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("type in value");
            }
            
        }

        private void Sensitivity_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Sensitivity_checkbox.Checked)
            {
                Stallvalue_trackbar.Value = TrackBarDefault;
                Sensitivity_checkbox.Checked = true;
            }            
        }

        private void Stallvalue_trackbar_ValueChanged(object sender, EventArgs e)
        {

            if(Stallvalue_trackbar.Value==15)
            {
                Sensitivity_checkbox.Checked = true;
            }

            else
            {
                Sensitivity_checkbox.Checked = false;
            }
            SetSensitivity_button.Enabled = true;
        }

        private void SetSensitivity_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (Atmega328SerialPort.GetPortStatus())
                {

                    Atmega328SerialPort.SetStallValue(Stallvalue_trackbar.Value);
                    SetSensitivity_button.Enabled = false;
                                      
                }

            }
            catch (Exception)
            {

                MessageBox.Show("type in value");
            }
        }

        private void Sensitivity_checkbox_Click(object sender, EventArgs e)
        {
            if(Sensitivity_checkbox.Checked)
            {
                SetSensitivity_button.Enabled = true;
            }
            
        }
    }
}
