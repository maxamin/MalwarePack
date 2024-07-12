namespace ns0
{
    using System;

    internal class Class505 : Class504
    {
        internal Class505(uint A_1, Class445[] A_2)
        {
            base.uint_0 = A_1;
            base.class445_0 = A_2;
        }

        internal override Class445 QQUS()
        {
            if (base.class445_0 != null)
            {
                Class957 class2 = Class821.smethod_5(base.uint_0);
                for (int i = 0; i < base.class445_0.Length; i++)
                {
                    base.class445_0[i] = Class821.smethod_9(base.class445_0[i].QQUU(Class821.smethod_6(class2, i))).QQUT();
                }
            }
            return this;
        }
    }
}

