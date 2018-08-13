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

        private int TrackBarDefault = 11;
        private string in_data_Serial;
        private Int32 AngleOutParse;


        public MainWindow()
        {
            InitializeComponent();
            ResetHardware_button.Enabled = false;
            Disconnect_button.Enabled = false;
           
            Sensitivity_groupbox.Enabled = false;
            SetSensitivity_button.Enabled = false;
            OpenStallMonitor_button.Enabled = false;
            ClearReceived_button.Enabled = false;
            setCurrent_groupbox.Enabled = false;
            Position_groupbox.Enabled = false;
            setAngle_button.Enabled = false;
            Calibration_groupbox.Enabled = false;
            Calibration_button.Enabled = false;

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
            try
            {

                ComPort_label.Text = "Serial Port:      connected";
                
                Atmega328SerialPort.InitializeSerialPort(ComPort_combobox.Text);

                Atmega328SerialPort.GetSerialPort().DataReceived += Atmega328SerialPort_DataReceived;
                this.myDelegate = new AddDataDelegate(AddDataMethod);

                Connect_button.Enabled = false;
                Disconnect_button.Enabled = true;
                ResetHardware_button.Enabled = true;                
                Sensitivity_groupbox.Enabled = true;                
                OpenStallMonitor_button.Enabled = true;               
                ClearReceived_button.Enabled = true;
                setCurrent_groupbox.Enabled = true;
                Position_groupbox.Enabled = true;
                Calibration_groupbox.Enabled = true;

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //_________________________________ Eventhandler Serial Receive __________________________________________    

        private void Atmega328SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data_Serial = Atmega328SerialPort.GetSerialPort().ReadExisting();
            ReceivedData_textbox.Invoke(this.myDelegate, new Object[] { in_data_Serial });
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
                OpenStallMonitor_button.Enabled = false;                
                Connect_button.Enabled = true;
                ResetHardware_button.Enabled = false;             
                Sensitivity_groupbox.Enabled = false;
                ClearReceived_button.Enabled = false;
                setCurrent_groupbox.Enabled = false;
                Position_groupbox.Enabled = false;
                Calibration_groupbox.Enabled = false;
                ComPort_label.Text = "Serial Port:  disconnected";
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

            if(Stallvalue_trackbar.Value==11)
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

        private void button1_Click(object sender, EventArgs e)
        {

            
            MotorStallMonitor LiveChartMonitor = new MotorStallMonitor();
            LiveChartMonitor.CustomValue = ComPort_combobox.Text;
            LiveChartMonitor.Atmega328SerialPort_Monitor = Atmega328SerialPort;
            LiveChartMonitor.Show();
            
           

        }

        private void CalibrateHP095_button_Click(object sender, EventArgs e)
        {
            try
            {
                Atmega328SerialPort.CalibrateHP095();   // set 1.6 mm distance             
            }

            catch (Exception)
            {

                MessageBox.Show("First Connect please");
            }
        }

        private void setCurrent_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (Atmega328SerialPort.GetPortStatus())
                {



                    //Atmega328SerialPort.SetStallValue(Int32.Parse(StallValue_textbox.Text));
                    Atmega328SerialPort.SetCurrentValue(Int32.Parse(setCurrent_textbox.Text));


                    //StallValue_textbox.Clear();
                    setCurrent_textbox.Clear();

                    //SetStallValue_button.Enabled = false;
                    setCurrent_button.Enabled = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Value between 0 - 32");
            }
        }

        private void setCurrent_textbox_TextChanged(object sender, EventArgs e)
        {
            setCurrent_button.Enabled = true;
        }

        private void setAngle_button_Click(object sender, EventArgs e)
        {
            try
            {

                if (Atmega328SerialPort.GetPortStatus())
                {



                    //Atmega328SerialPort.SetStallValue(Int32.Parse(StallValue_textbox.Text));
                    Atmega328SerialPort.setFreePosition(double.Parse(setAngle_textbox.Text));


                    //StallValue_textbox.Clear();
                    setAngle_textbox.Clear();

                    //SetStallValue_button.Enabled = false;
                    setAngle_button.Enabled = false;
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Value between 0 - 32");
            }
        }

        private void setAngle_textbox_TextChanged(object sender, EventArgs e)
        {
            
            if((Int32.TryParse(setAngle_textbox.Text, out AngleOutParse)) && Int32.Parse(setAngle_textbox.Text)<3686)
            {
                Angletomm_label.Text = "= " + (Convert.ToDouble(AngleOutParse)/360*0.8) +" mm";
                setAngle_button.Enabled = true;
                
                    

            }
            else
            {
                Angletomm_label.Text = "= Distance in mm";
                setAngle_button.Enabled = false;
            }
          
               
        }

        private void Calibration_button_Click(object sender, EventArgs e)
        {

            try
            {
                if(LowE_button.Checked)
                {
                    Atmega328SerialPort.CalibrateLF025();
                }

                if (HighE_button.Checked)
                {
                    Atmega328SerialPort.CalibrateHP095();
                }
                Calibration_button.Enabled = false;
            }
            catch (Exception)
            {

                MessageBox.Show("Value between 0 - 32");
            }
        }

        private void LowE_button_CheckedChanged(object sender, EventArgs e)
        {
            Calibration_button.Enabled = true;
        }

        private void HighE_button_CheckedChanged(object sender, EventArgs e)
        {
            Calibration_button.Enabled = true;
        }
    }
}
