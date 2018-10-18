using System;

namespace BDKS_06
{
    public static class LowLevel
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

        public static byte[] Comm(byte b1, byte b2, byte b3, byte b4)
        {

            byte[] msg = new byte[] {
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

        public static byte[] Comm(byte b1, byte b2, ushort s3, byte b4,byte b5 )
        {
            byte[] bytesOne = BitConverter.GetBytes(s3);

            byte[] msg = new byte[] {
                b1,
                b2,
                bytesOne[0],
                bytesOne[1],
                b4,
                b5
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }

        public static byte[] Comm(byte b1 ,byte b2 ,ushort s3 , ushort s4 )
        {
            byte[] bytesOne = BitConverter.GetBytes(s3);
            byte[] bytesTwo = BitConverter.GetBytes(s4);
            
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

        public static byte[] Comm(byte b1, byte b2, byte b3, ushort s4, ushort s5)
        {
            byte[] bytesOne = BitConverter.GetBytes(s4);
            byte[] bytesTwo = BitConverter.GetBytes(s5);

            byte[] msg = new byte[] {
                b1,
                b2,
                b3,
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

        public static byte[] Comm(byte b1, byte b2, byte b3, ushort s4, ushort s5,ushort s6)
        {
            byte[] bytesOne = BitConverter.GetBytes(s4);
            byte[] bytesTwo = BitConverter.GetBytes(s5);
            byte[] bytesThree = BitConverter.GetBytes(s6);

            byte[] msg = new byte[] {
                b1,
                b2,
                b3,
                bytesOne[0],
                bytesOne[1],
                bytesTwo[0],
                bytesTwo[1],
                bytesThree[0],
                bytesThree[1]
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }


        public static byte[] Comm(byte b1, byte b2, byte b3, ushort s4, ushort s5, ushort s6,ushort s7)
        {
            byte[] bytesOne = BitConverter.GetBytes(s4);
            byte[] bytesTwo = BitConverter.GetBytes(s5);
            byte[] bytesThree = BitConverter.GetBytes(s6);
            byte[] bytesFour = BitConverter.GetBytes(s7);

            byte[] msg = new byte[] {
                b1,
                b2,
                b3,
                bytesOne[0],
                bytesOne[1],
                bytesTwo[0],
                bytesTwo[1],
                bytesThree[0],
                bytesThree[1],
                bytesFour[0],
                bytesFour[1]
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }

        public static byte[] Comm(byte b1, byte b2, byte b3, ushort s4, ushort s5, byte b7, byte b8, byte b9, byte b10)
        {
            byte[] bytesOne = BitConverter.GetBytes(s4);
            byte[] bytesTwo = BitConverter.GetBytes(s5);

            byte[] msg = new byte[] {
                b1,
                b2,
                b3,
                bytesOne[0],
                bytesOne[1],
                bytesTwo[0],
                bytesTwo[1],
                b7,
                b8,
                b9,
                b10
                
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }

        public static byte[] Comm(byte b1, byte b2, byte b3, ushort s4, ushort s5, ushort s6,byte b7 , byte b8 , byte b9, byte b10 , byte b11 , byte b12)
        {
            byte[] bytesOne = BitConverter.GetBytes(s4);
            byte[] bytesTwo = BitConverter.GetBytes(s5);
            byte[] bytesThree = BitConverter.GetBytes(s6);          

            byte[] msg = new byte[] {
                b1,
                b2,
                b3,
                bytesOne[0],
                bytesOne[1],
                bytesTwo[0],
                bytesTwo[1],
                bytesThree[0],
                bytesThree[1],
                b7,
                b8,
                b9,
                b10,
                b11,
                b12
            };

            msg = crc.GetCRC(msg);
            port.Write(msg);
            msg = port.Read();

            return msg;
        }
    }
}
