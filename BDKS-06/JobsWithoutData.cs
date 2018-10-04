using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace BDKS_06
{
    public class JobsWithoutData
    {   
        
        static SerialPort port = new SerialPort("COM0", 57600, Parity.None, 8, StopBits.Two);
        static Crc16 crc = new Crc16();

        public static void OpenPort() => port.Open();
        public static void ClosePort() => port.Close();

        public static SerialPort SetPort(string namePort)
        {
            port = new SerialPort(namePort, 57600, Parity.None, 8, StopBits.Two);
            return port;
        }

        public static string StatusPort()
        {
            string status;

            if (port.IsOpen)
            {
                status = "Порт открыт";
            }
            else status = "Порт закрыт";

            return status;
        }
        
        public static string[] GetPortsName()
        {
            string[] portsName = SerialPort.GetPortNames();
            return portsName;
        }

        

        public static void Write(byte[] crcValues)
        {     
            byte[] signature = new byte[crcValues.Length + 2];

            for (int i = 0; i < crcValues.Length; i++)
            {
                signature[i] = crcValues[i];
            }
            
            crcValues = crc.GetCRC(crcValues, crcValues.Length);
            signature[signature.Length - 2] = crcValues[0];
            signature[signature.Length - 1] = crcValues[1];

            if (port.IsOpen)
            {
                try
                {
                    
                
                    port.Write(signature, 0, signature.Length);
                    port.Read(signature, 0, signature.Length);
                }
                catch (TimeoutException) { MessageBox.Show("Ошибка времени выполнения");  }
            }
            else { MessageBox.Show("Порт закрыт"); }
            MessageBox.Show("комманда выполнена успешно");

        }
    }
}
