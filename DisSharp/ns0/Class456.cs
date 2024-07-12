namespace ns0
{
    using System;

    internal class Class456 : Class445
    {
        internal Enum30 enum30_0;
        internal ushort ushort_0;

        internal Class456()
        {
        }

        internal Class456(ushort A_1)
        {
            this.ushort_0 = A_1;
            this.enum30_0 = Enum30.const_0;
        }

        internal override Class445 QQUU(Class658 type)
        {
            if (type == Class658.class658_0)
            {
                Class568.Class623 class2;
                if (Class519.class528_0.Boolean_8)
                {
                    class2 = Class546.class568_0.arrayList_0[Class519.class528_0.int_6 + this.ushort_0] as Class568.Class623;
                    return Class859.smethod_1(this, class2.enum11_0, class2.int_1, Enum50.const_0);
                }
                if (this.ushort_0 > 0)
                {
                    class2 = Class546.class568_0.arrayList_0[(Class519.class528_0.int_6 + this.ushort_0) - 1] as Class568.Class623;
                    return Class859.smethod_1(this, class2.enum11_0, class2.int_1, Enum50.const_0);
                }
            }
            return Class860.smethod_0(this, type);
        }

        internal override void QQVS(Class48 data)
        {
            this.ushort_0 = data.method_10();
            this.enum30_0 = (Enum30) data.method_8();
        }

        internal override void QQVT(Class524 writer)
        {
            writer.Write(this.ushort_0);
            writer.Write((byte) this.enum30_0);
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
                return Enum17.const_2;
            }
        }
    }
}

