namespace ns0
{
    using System;

    internal class Class837 : Class822
    {
        internal uint uint_0;

        internal Class837(int A_1, Enum45 A_2, uint A_3)
        {
            base.int_0 = A_1;
            base.enum45_0 = A_2;
            this.uint_0 = A_3;
        }

        internal override void QQUX(Class397 lines)
        {
            if (base.enum45_0 == Enum45.const_116)
            {
                Class968.smethod_2(lines, this.uint_0);
            }
            else
            {
                Class968.smethod_1(lines, this.uint_0);
            }
        }
    }
}

