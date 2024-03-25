using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;

namespace RoboButton2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SerialPort serialPort;
        protected void Page_Load(object sender, EventArgs e)
        {
            serialPort = new SerialPort("COM4", 9600); // Change COM3 to match your Arduino's COM port
            serialPort.Open();
        }

        protected void OFFButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("0");
        }

        protected void ONButton_Click(object sender, EventArgs e)
        {
            serialPort.Write("1");
        }
        protected void Page_Unload(object sender, EventArgs e)
        {
            // Close the serial port when the page is unloaded
            serialPort.Close();
        }
    }
}