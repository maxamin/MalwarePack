namespace ns0
{
    using System;

    internal class Class457 : Class456
    {
        internal Class457()
        {
        }

        internal Class457(ushort A_1)
        {
            base.ushort_0 = A_1;
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
                return Enum17.const_3;
            }
        }
    }
}

