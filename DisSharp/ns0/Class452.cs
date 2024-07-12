namespace ns0
{
    using System;

    internal class Class452 : Class445
    {
        internal bool bool_0;
        internal ushort ushort_0;

        internal Class452()
        {
            this.bool_0 = true;
        }

        internal Class452(ushort A_1)
        {
            this.bool_0 = true;
            this.ushort_0 = A_1;
        }

        internal override Class445 QQUS()
        {
            if (this.bool_0 && Class979.bool_0)
            {
                Class979.smethod_7(this.ushort_0);
                this.bool_0 = false;
            }
            return this;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                return Class859.smethod_1(this, Class525.enum11_0[this.ushort_0], Class525.int_2[this.ushort_0], Enum50.const_0);
            }
            return Class860.smethod_0(this, type);
        }

        internal override void QQVS(Class48 data)
        {
            this.ushort_0 = data.method_10();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.ushort_0);
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
                return Enum17.const_44;
            }
        }
    }
}

