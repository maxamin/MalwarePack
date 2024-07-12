namespace ns0
{
    using System;

    internal class Class432 : Class398
    {
        internal Class445 class445_0;
        internal uint uint_0;

        internal Class432()
        {
        }

        internal Class432(uint A_1, Class445 A_2)
        {
            this.uint_0 = A_1;
            this.class445_0 = A_2;
        }

        internal override Class398 QQUS()
        {
            this.class445_0 = this.class445_0.QQUU(Class821.smethod_7(this.uint_0));
            this.class445_0 = Class821.smethod_9(this.class445_0);
            this.class445_0 = this.class445_0.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
            this.class445_0 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.uint_0);
            this.class445_0.QQRW(writer);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_32;
            }
        }
    }
}

