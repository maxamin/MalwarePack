namespace ns0
{
    using System;

    internal class Class420 : Class398
    {
        internal Class445 class445_0;
        internal uint uint_0;

        internal Class420()
        {
        }

        internal Class420(Class445 A_1, uint A_2)
        {
            this.class445_0 = A_1;
            this.uint_0 = Class840.smethod_0(A_2);
        }

        internal override Class398 QQUS()
        {
            this.class445_0 = this.class445_0.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.uint_0 = data.method_14();
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write(this.uint_0);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_20;
            }
        }
    }
}

