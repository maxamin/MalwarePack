namespace ns0
{
    using System;

    internal class Class437 : Class398
    {
        internal Class445 class445_0;

        internal Class437()
        {
        }

        internal Class437(Class445 A_1)
        {
            this.class445_0 = A_1;
        }

        internal override Class398 QQUS()
        {
            this.class445_0 = this.class445_0.QQUT();
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

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_37;
            }
        }
    }
}

