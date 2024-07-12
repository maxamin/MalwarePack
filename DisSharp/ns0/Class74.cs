namespace ns0
{
    using System;

    internal abstract class Class74 : Class73
    {
        protected Class74()
        {
        }

        internal bool method_201(Class549.Class530 A_1)
        {
            if (A_1.class630_0 != null)
            {
                Class630 class2 = A_1.class630_0;
                if (class2.enum19_0 != Enum19.const_0)
                {
                    return false;
                }
                if (class2.enum20_0 == Enum20.const_0)
                {
                    Class548.Class529 class3 = Class546.class548_0.arrayList_0[class2.int_0] as Class548.Class529;
                    if (Class519.class581_0[class3.int_1] == Class537.string_755)
                    {
                        return true;
                    }
                }
                else
                {
                    Class553.Class531 class4 = Class546.class553_0.arrayList_0[class2.int_0] as Class553.Class531;
                    if (Class519.class581_0[class4.int_1] == Class537.string_755)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

