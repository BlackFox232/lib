using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace BDKS_06
{
    public class Port
    {

        static SerialPort port = new SerialPort("COM0", 57600, Parity.None, 8, StopBits.Two);
        static Crc16 crc = new Crc16();

        public void OpenPort()
        {
            if (!port.IsOpen == true)
            {
                try
                {
                    port.Open();
                }
                catch (System.IO.IOException)
                {
                    MessageBox.Show("Выберите порт");
                }
                catch (System.UnauthorizedAccessException)
                {
                    MessageBox.Show("Доступ к порту закрыт");
                }
            }
            else
            {
                MessageBox.Show("Порт уже открыт");
            }

        }

        public void ClosePort() => port.Close();

        public SerialPort SetPort(string namePort)
        {
            port = new SerialPort(namePort, 57600, Parity.None, 8, StopBits.Two);

            return port;
        }

        public string StatusPort()
        {
            string status;

            if (port.IsOpen)
            {
                status = "Порт открыт";
            }
            else status = "Порт закрыт";

            return status;
        }

        public string[] GetPortsName()
        {
            string[] portsName = SerialPort.GetPortNames();

            return portsName;
        }

        public void Write(byte[] wrtSign)
        {
            
            if (port.IsOpen)
            {
                port.WriteTimeout = 1000;
                port.Write(wrtSign, 0, wrtSign.Length);
            }
            else
            {
                MessageBox.Show("Порт закрыт");
            }
        }

        public byte[] Read()
        {
            int cnt = port.BytesToRead;
            byte[] inBuffer = new byte[cnt];

            while (port.BytesToRead > 0)
            {
                port.Read(inBuffer, 0, cnt);
            }
            Thread.Sleep(1000);

            return inBuffer;
        }
    }
}
