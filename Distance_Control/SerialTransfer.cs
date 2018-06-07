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


        //____________________________ Sending Codes__________________________________________________

        private byte byteStallValue  = 0x61;   // a set Stall Value 
        private byte byteRemove      = 0x62;   // b Remove Electrode
        private byte byteCalibLF025  = 0x63;   // c Calibrate LF025         
        private byte byteReset       = 0x72;   // r Hardware Reset 
        private byte bytePadding     = 0x78;   // x Replacement        


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
            _port.Write(new byte[] { byteCalibLF025, bytePadding, bytePadding, bytePadding }, 0, 4);
        }

        public void RemoveElectrode()
        {            
            _port.Write(new byte[] { byteRemove, bytePadding, bytePadding, bytePadding }, 0, 4);
        }

        public void HardwareReset()
        {
            _port.Write(new byte[] { byteReset, bytePadding, bytePadding, bytePadding }, 0, 4);
        }
               
        //_____________________________________________________________________________________________
    }
}
