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
    public partial class Form1 : Form
    {

        public SerialTransfer test = new SerialTransfer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                test.GetSerialPort().Write("bxxx");
            }
            catch
            {
                MessageBox.Show("First Connect and then disconnect");
            }
        }
    }
}
