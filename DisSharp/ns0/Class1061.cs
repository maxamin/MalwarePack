namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1061
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            int num = A_0.Count - 1;
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (i < num)
                {
                    Class417 class3 = class2 as Class417;
                    if (class3 != null)
                    {
                        if (class3.class398_0 == A_0[i + 1])
                        {
                            class3.bool_0 = true;
                        }
                    }
                    else
                    {
                        Class425 class4 = class2 as Class425;
                        if ((class4 != null) && (class4.class398_0 == A_0[i + 1]))
                        {
                            class4.bool_0 = true;
                        }
                    }
                }
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }
    }
}

