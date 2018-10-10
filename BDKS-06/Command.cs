using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKS_06
{
    public class Commands
    {
        static Port port = new Port() ;
        static Crc16 crc = new Crc16();

        static byte[] msg { get; set; }

        public static byte[] Comm2(byte b1, byte b2, byte b3, byte b4)
        {
            msg =new byte[] {
                0x1,
                0x2,
                b1,
                b2,
                b3,
                b4
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }

        public static byte[] Comm3(ushort b1,ushort b2)
        {
            byte[] bytesOne = BitConverter.GetBytes(b1);
            byte[] bytesTwo = BitConverter.GetBytes(b2);
            msg = new byte[] {
                0x1,
                0x3,
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
