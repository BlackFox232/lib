using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;

namespace BDKS_06
{
    public class Port
    {
        static SerialPort port = new SerialPort("COM0", 57600, Parity.None, 8, StopBits.Two);
        static readonly Crc16 crc = new Crc16();

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

        public SerialPort SetPortName(string namePort)
        {
            port = new SerialPort(namePort, 57600, Parity.None, 8, StopBits.Two);

            return port;
        }

        public SerialPort SetPort(SerialPort _port)
        {
            port = _port;
            
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

        public int Write(byte[] wrtSign)
        {
            if (port.IsOpen)
            {
                port.WriteTimeout = 1000;
                port.Write(wrtSign, 0, wrtSign.Length);
                Thread.Sleep(500);
            }
            else
            {
                MessageBox.Show("Порт закрыт");
            }

            return wrtSign.Length;
        }

        public byte[] Read(int n)
        {
            byte[] buff = new byte[port.BytesToRead];
            int cnt = 0;
            List<byte> inBuffer = new List<byte>();

            while (port.BytesToRead > 0)
            {
                port.Read(buff, 0, buff.Length);
                inBuffer.AddRange(buff);
                Thread.Sleep(200);
            }
                    

            foreach (byte item in inBuffer)
            {
                buff[cnt] = Convert.ToByte(inBuffer[cnt]);
                cnt++;
            }

            return buff;
        }
    }
}
