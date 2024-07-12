namespace ns0
{
    using System;

    internal class Class630
    {
        internal Enum19 enum19_0;
        internal Enum20 enum20_0;
        internal int int_0;

        internal Class630()
        {
        }

        internal Class630(Enum19 A_1)
        {
            this.enum19_0 = A_1;
        }

        internal void method_0(Class524 A_1)
        {
            A_1.Write((byte) this.enum19_0);
            A_1.Write((byte) this.enum20_0);
            A_1.Write(this.int_0);
        }

        internal void method_1(Class656 A_1)
        {
            this.enum19_0 = (Enum19) A_1.ReadByte();
            this.enum20_0 = (Enum20) A_1.ReadByte();
            this.int_0 = A_1.ReadInt32();
        }
    }
}

