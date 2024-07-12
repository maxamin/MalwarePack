namespace ns0
{
    using System;

    internal class Class489 : Class445
    {
        internal Class445 class445_0;
        internal uint uint_0;

        internal Class489()
        {
        }

        internal Class489(Class445 A_1, uint A_2)
        {
            this.class445_0 = Class520.smethod_0(A_1, A_2);
            this.uint_0 = A_2;
        }

        internal override Class445 QQUS()
        {
            this.class445_0 = this.class445_0.QQUS();
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                Class658 class2 = Class821.smethod_2(this.uint_0);
                return Class859.smethod_1(this, class2.enum11_0, class2.int_0, Enum50.const_0);
            }
            return Class860.smethod_0(this, type);
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

        internal override bool QQVV
        {
            get
            {
                return true;
            }
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_41;
            }
        }
    }
}

