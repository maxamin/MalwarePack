namespace ns0
{
    using System;

    internal class Class450 : Class445
    {
        internal double double_0;

        internal Class450()
        {
        }

        internal Class450(double A_1)
        {
            this.double_0 = A_1;
        }

        internal override void QQVS(Class48 data)
        {
            this.double_0 = data.method_18();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.double_0);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_19;
            }
        }
    }
}

