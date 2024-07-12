namespace ns0
{
    using System;

    internal class Class424 : Class398
    {
        internal Class445 class445_0;
        internal Class445 class445_1;
        internal uint uint_0;

        internal Class424()
        {
        }

        internal Class424(Class445 A_1, uint A_2, Class445 A_3)
        {
            this.class445_0 = Class520.smethod_0(A_1, A_2);
            this.uint_0 = A_2;
            this.class445_1 = A_3;
        }

        internal override Class398 QQUS()
        {
            this.class445_1 = this.class445_1.QQUU(Class821.smethod_7(this.uint_0));
            this.class445_1 = Class821.smethod_9(this.class445_1);
            this.class445_0 = this.class445_0.QQUS();
            this.class445_1 = this.class445_1.QQUT();
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.class445_0 = Class541.smethod_2(data);
            this.uint_0 = data.method_14();
            this.class445_1 = Class541.smethod_2(data);
        }

        internal override void QQVT(Class524 writer)
        {
            this.class445_0.QQRW(writer);
            writer.Write(this.uint_0);
            this.class445_1.QQRW(writer);
        }

        internal override Enum26 Type
        {
            get
            {
                return Enum26.const_24;
            }
        }
    }
}

