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
        private byte i = 0xef;

        //____________________________ Sending Codes__________________________________________________

        private byte byteCalibLF025  = 0x63; // c Calibrate LF025 
        private byte byteRemove      = 0x62; // b Remove Electrode
        private byte byteReset       = 0x72; // r Hardware Reset 
        private byte byteStallValue  = 0x61; // a set Stall Value 


        //____________________________________________________________________________________________    
         

        // get methode
        public SerialPort GetSerialPort()
        {
            return _port;
        }

        public void InitializeSerialPort(string PortName)
        {
            _port.BaudRate = _baudrate;
            _port.PortName = PortName;
            _port.Open();
        }


        //____________________________ Motor Action Methods __________________________________________

        public void CalibrateLF025()
        {
            _port.Write("cxxx");            
        }

        public void RemoveElectrode()
        {
            _port.Write("bxxx");
        }
               
        //_____________________________________________________________________________________________
    }
}
