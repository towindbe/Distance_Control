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


        /***************************** Motor Action Methods ************************/

        public void CalibrateLF025()
        {
            _port.Write("cxxx");
        }

        public void RemoveElectrode()
        {
            _port.Write("bxxx");
        }
               
        /***************************************************************************/
    }
}
