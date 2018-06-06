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

        public SerialPort GetSerialPort()
        {
            return _port;
        }



        public void CalibrateLF025(string message, SerialPort port)
        {
            //_port.Write(");
        }

    }
}
