namespace BDKS_06
{
    public class HighLevel
    {
        public byte Adress { get; set; } = 0x1;

        public byte[] Second(ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x2,
                s2,
                s4);

            return val;
        }

        public byte[] Third(ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x3,
                s2,
                s4);

            return val;
        }

        public byte[] Fourth(ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x4,
                s2,
                s4);

            return val;
        }

        public byte[] Fifth(ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x5,
                s2,
                s4);

            return val;
        }

        public byte[] Sixth(ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x6,
                s2,
                s4);

            return val;
        }

        public byte[] Seventh()
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x7);

            return val;
        }

        public byte[] Eighth(ushort s2, byte b3, byte b4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x8,
                s2,
                b3,
                b4);

            return val;
        }

        public byte[] Nineth(byte b2, ushort s2, ushort s4, ushort s6)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x9,
                b2,
                s2,
                s4,
                s6);

            return val;
        }

        public byte[] Tenth(byte b2, ushort s2, ushort s4, ushort s6, byte b7, byte b8, byte b9, byte b10, byte b11, byte b12)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0xA,
                b2,
                s2,
                s4,
                s6,
                b7,
                b8,
                b9,
                b10,
                b11,
                b12);

            return val;
        }

        public byte[] Eleventh(byte b2, ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0xB,
                b2,
                s2,
                s4
                );

            return val;
        }

        public byte[] Sixteenth(byte b2, ushort s2, ushort s4, ushort s6, ushort s8)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x10,
                b2,
                s2,
                s4,
                s6,
                s8);

            return val;
        }

        public byte[] Seventeenth()
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x11);

            return val;
        }

        public byte[] Eightteenth(byte b2, ushort s2, ushort s4)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x12,
                b2,
                s2,
                s4);

            return val;
        }

        public byte[] Nineteenth(byte b2, ushort s2, ushort s4, byte b5, byte b6, byte b7, byte b8)
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x13,
                b2,
                s2,
                s4,
                b5,
                b6,
                b7,
                b8);

            return val;
        }

        public byte[] ReadRangeAndReboot()
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x40);

            return val;
        }

        public byte[] ReadRangeCompressedAndReboot()
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x41);

            return val;
        }

        public byte[] ReadСompressedRange()
        {
            byte[] val = LowLevel.Comm(
                Adress,
                0x42);

            return val;
        }
    }
}
