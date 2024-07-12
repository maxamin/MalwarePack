namespace ns0
{
    using System;

    internal class Class498 : Class445
    {
        internal uint uint_0;

        internal Class498()
        {
        }

        internal Class498(uint A_1)
        {
            this.uint_0 = Class840.smethod_0(A_1);
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                return new Class470(new Class447(0), this, Enum31.const_0);
            }
            return this;
        }

        internal override void QQVS(Class48 data)
        {
            this.uint_0 = data.method_14();
        }

        internal override void QQVT(Class524 writer)
        {
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
                return Enum17.const_52;
            }
        }
    }
}

