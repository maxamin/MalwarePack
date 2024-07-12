namespace ns0
{
    using System;

    internal class Class833 : Class822
    {
        internal ushort ushort_0;

        internal Class833(int A_1, Enum45 A_2, ushort A_3)
        {
            base.int_0 = A_1;
            base.enum45_0 = A_2;
            this.ushort_0 = A_3;
        }

        internal override void QQUX(Class397 lines)
        {
            int num = (Class519.class528_0.int_6 + this.ushort_0) - ((Class519.class528_0.Boolean_8 || Class519.class528_0.Boolean_18) ? 0 : 1);
            Class568.Class623 class2 = Class546.class568_0.arrayList_0[num] as Class568.Class623;
            lines.method_10(new Class336(Class519.class581_0[class2.int_0]));
        }
    }
}

