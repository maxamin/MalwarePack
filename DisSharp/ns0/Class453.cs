namespace ns0
{
    using System;

    internal class Class453 : Class452
    {
        internal Class453()
        {
        }

        internal Class453(ushort A_1)
        {
            base.ushort_0 = A_1;
        }

        internal override Class445 QQUS()
        {
            return base.QQUS();
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
                return Enum17.const_45;
            }
        }
    }
}

