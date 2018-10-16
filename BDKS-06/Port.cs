using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKS_06
{
    public class LowLevelCommand
    {
        static Port port = new Port() ;
        static Crc16 crc = new Crc16();

        public static byte[] Comm(byte b1, byte b2)
        {
            
            byte[] msg = new byte[] {
                b1,
                b2
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }

        public static byte[] Comm(byte b1 ,byte b2 ,ushort b3 , ushort b4 )
        {
            byte[] bytesOne = BitConverter.GetBytes(b1);
            byte[] bytesTwo = BitConverter.GetBytes(b2);
            
            byte[] msg = new byte[] {
                b1,
                b2,
                bytesOne[0],
                bytesOne[1],
                bytesTwo[0],
                bytesTwo[1]
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }

        public static byte[] Comm(byte b1, byte b2, byte b3, ushort b4, ushort b5)
        {
            byte[] bytesOne = BitConverter.GetBytes(b1);
            byte[] bytesTwo = BitConverter.GetBytes(b2);

            byte[] msg = new byte[] {
                b1,
                b2,
                bytesOne[0],
                bytesOne[1],
                bytesTwo[0],
                bytesTwo[1]
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }
    }
}
