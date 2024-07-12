namespace ns0
{
    using System;

    internal class Class475 : Class445
    {
        internal ulong ulong_0;

        internal Class475()
        {
        }

        internal Class475(long A_1)
        {
            this.ulong_0 = (ulong) A_1;
        }

        internal override void QQVS(Class48 data)
        {
            this.ulong_0 = data.method_16();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.ulong_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_27;
            }
        }
    }
}

