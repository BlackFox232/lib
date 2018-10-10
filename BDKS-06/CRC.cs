using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKS_06
{
    class Crc16
    {
        public byte [] GetCRC(byte[] crcValues)
        {

            byte[] signature = new byte[crcValues.Length + 2];

            for (int i = 0; i < crcValues.Length; i++)
            {
                signature[i] = crcValues[i];
            }

            crcValues = CalcCRC(crcValues, crcValues.Length);
            signature[signature.Length - 2] = crcValues[0];
            signature[signature.Length - 1] = crcValues[1];

            return signature;
        }

        private byte[] CalcCRC(byte[] buf, int len)
        {
            UInt16 crc = 0xFFFF;

            for (int pos = 0; pos < len; pos++)
            {
                crc ^= (UInt16)buf[pos];

                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                        crc >>= 1;
                }
            }
            
            byte[] bytes = BitConverter.GetBytes(crc);

            return bytes;
        }
    }
}
  


