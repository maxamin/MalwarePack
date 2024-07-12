namespace ns0
{
    using System;

    internal class Class492 : Class445
    {
        internal byte byte_0;
        internal Enum11 enum11_0;
        internal int int_0;
        internal ushort ushort_0;

        internal Class492()
        {
        }

        internal Class492(Enum11 A_1, int A_2, byte A_3, ushort A_4)
        {
            this.enum11_0 = A_1;
            this.int_0 = A_2;
            this.byte_0 = A_3;
            this.ushort_0 = A_4;
        }

        internal override void QQVS(Class48 data)
        {
            this.enum11_0 = (Enum11) data.method_8();
            this.int_0 = data.method_11();
            this.byte_0 = data.method_8();
            this.ushort_0 = data.method_10();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write((byte) this.enum11_0);
            writer.Write(this.int_0);
            writer.Write(this.byte_0);
            writer.Write(this.ushort_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_46;
            }
        }
    }
}

