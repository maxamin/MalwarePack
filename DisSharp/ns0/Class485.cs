namespace ns0
{
    using System;

    internal class Class485 : Class484
    {
        internal Class485()
        {
        }

        internal Class485(Class445 A_1, uint A_2)
        {
            base.class445_0 = Class520.smethod_0(A_1, A_2);
            base.uint_0 = A_2;
        }

        internal override Class445 QQUS()
        {
            base.class445_0 = base.class445_0.QQUS();
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type.byte_0 > 0)
            {
                return new Class454(this);
            }
            return this;
        }

        internal override Enum17 Type
        {
            get
            {
                return Enum17.const_37;
            }
        }
    }
}

