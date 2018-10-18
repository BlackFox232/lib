using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDKS_06
{
    class HighLevel 
    {
        public byte Adress { get; set; } = 0x1;

        public byte[] Second(ushort b2 , ushort b4 )
        {
            byte[] val = LowLevel.Comm(Adress, 0x2, b2, b4);

            return val;
        }

        public byte[] Third(ushort b2, ushort b4)
        {
            byte[] val = LowLevel.Comm(Adress, 0x2, b2, b4);

            return val;
        }

        public byte[] Four(ushort b2, ushort b4)
        {
            byte[] val = LowLevel.Comm(Adress, 0x2, b2, b4);

            return val;
        }
        
    }
}
