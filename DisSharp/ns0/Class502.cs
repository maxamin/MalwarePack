namespace ns0
{
    using System;

    internal class Class502 : Class501
    {
        internal Class502()
        {
        }

        internal Class502(uint A_1)
        {
            base.uint_0 = A_1;
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
                return Enum17.const_56;
            }
        }
    }
}

