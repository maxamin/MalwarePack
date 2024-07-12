namespace ns0
{
    using System;

    internal class Class473 : Class445
    {
        internal int int_0;

        internal Class473()
        {
        }

        internal Class473(int A_1)
        {
            this.int_0 = A_1;
        }

        internal override void QQVS(Class48 data)
        {
            this.int_0 = data.method_11();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.int_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_25;
            }
        }
    }
}

