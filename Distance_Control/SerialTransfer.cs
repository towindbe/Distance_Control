using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Distance_Control
{
    public class SerialTransfer
    {

        private SerialPort _port = new SerialPort();
        private int _baudrate = 250000;        
        private bool _portIsOpen = false;


        //____________________________ Sending Codes__________________________________________________
        
        private byte byteStallValue  = 0x61;   // a set Stall Value 
        private byte byteRemove      = 0x62;   // b Remove Electrode
        private byte byteCalibLF025  = 0x63;   // c Calibrate LF025         
        private byte byteReset       = 0x72;   // r Hardware Reset 
        private byte bytePadding     = 0x78;   // x Replacement    
        private byte byteLiveChart   = 0x4C;   // L


        //____________________________ Serial Port Methods __________________________________________   

        // Initialize Data Transfer
        public void InitializeSerialPort(string PortName)
        {
            _port.BaudRate = _baudrate;
            _port.PortName = PortName;
            _port.Open();
            _portIsOpen = true;

        }

        // End Data Transfer
        public void TerminateTransfer()
        {
            _port.Close();
        }

        // get methode
        public SerialPort GetSerialPort()
        {
            return _port;
        }
                

        // get Port Status
        public bool GetPortStatus()
        {
            return _portIsOpen;          // Port open -> return true,   Port closed -> return false
        }

        //____________________________ Motor Action Methods __________________________________________

        public void CalibrateLF025()
        {            
            _port.Write(new byte[] { byteCalibLF025, bytePadding, bytePadding, bytePadding }, 0, 4);
        }

        public void CalibrateLF025LiveChart()
        {
            _port.Write(new byte[] { byteLiveChart, bytePadding, bytePadding, bytePadding }, 0, 4);
        }

        public void RemoveElectrode()
        {            
            _port.Write(new byte[] { byteRemove, bytePadding, bytePadding, bytePadding }, 0, 4);
        }

        public void HardwareReset()
        {
            _port.Write(new byte[] { byteReset, bytePadding, bytePadding, bytePadding }, 0, 4);
        }

        public void SetStallValue(Int32 StallValueInput)
        {
            //UserInputs = enc.GetBytes(StallValueInput);
            _port.Write(new byte[] { byteStallValue, Convert.ToByte(StallValueInput), bytePadding, bytePadding }, 0, 4);
        }
               
        //_____________________________________________________________________________________________
    }
}
