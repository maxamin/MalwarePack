namespace ns0
{
    using System;

    internal class Class985
    {
        private const byte byte_0 = 0x44;
        private const byte byte_1 = 0x69;
        private const byte byte_2 = 0x73;
        private const byte byte_3 = 0x23;
        internal short short_0;

        internal void method_0(Class524 A_1)
        {
            A_1.Write((byte) 0x44);
            A_1.Write((byte) 0x69);
            A_1.Write((byte) 0x73);
            A_1.Write((byte) 0x23);
            A_1.Write((short) 12);
        }

        internal void method_1(Class656 A_1, string A_2)
        {
            if (A_1.ReadByte() != 0x44)
            {
                throw new Exception11(A_2);
            }
            if (A_1.ReadByte() != 0x69)
            {
                throw new Exception11(A_2);
            }
            if (A_1.ReadByte() != 0x73)
            {
                throw new Exception11(A_2);
            }
            if (A_1.ReadByte() != 0x23)
            {
                throw new Exception11(A_2);
            }
            this.short_0 = A_1.ReadInt16();
            if (this.short_0 < 12)
            {
                throw new Exception12();
            }
        }
    }
}

