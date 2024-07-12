namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1013
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                Class399 class3 = class2 as Class399;
                if (class3 != null)
                {
                    Class467 class4 = class3.class445_1 as Class467;
                    if (class4 != null)
                    {
                        Class504 class5 = class4.class445_0 as Class504;
                        if (class5 != null)
                        {
                            if ((class5.uint_0 == Class519.class604_0.uint_5) && (class5.class445_0.Length == 2))
                            {
                                A_0[i] = new Class401(class3.class445_0, class5.class445_0[1], Enum1.const_0);
                            }
                            else if ((class5.uint_0 == Class519.class604_0.uint_6) && (class5.class445_0.Length == 2))
                            {
                                A_0[i] = new Class401(class3.class445_0, class5.class445_0[1], Enum1.const_11);
                            }
                        }
                    }
                }
                else
                {
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ != null)
                    {
                        smethod_1(qQSQ);
                    }
                }
            }
        }
    }
}

