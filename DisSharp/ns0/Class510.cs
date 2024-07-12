namespace ns0
{
    using System;

    internal class Class510 : Class445
    {
        internal Class445 class445_0;

        internal Class510()
        {
        }

        internal Class510(Class445 A_1)
        {
            this.class445_0 = A_1;
        }

        internal override Class445 QQUS()
        {
            return this;
        }

        internal override Class445 QQUT()
        {
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_63;
            }
        }
    }
}

