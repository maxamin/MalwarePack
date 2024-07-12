namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1103
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0, 1);
        }

        private static void smethod_1(ArrayList A_0, int A_1)
        {
            if (A_0 != null)
            {
                int count = A_0.Count;
                if (count >= (1 + A_1))
                {
                    Class398 class2 = A_0[(count - A_1) - 1] as Class398;
                    if (class2.Type == Enum26.const_17)
                    {
                        smethod_1(class2.QQSQ, 0);
                    }
                    else if (((class2.Type == Enum26.const_9) || (class2.Type == Enum26.const_10)) && (count >= (2 + A_1)))
                    {
                        Class398 class3 = A_0[(count - A_1) - 2] as Class398;
                        if (class3.Type == Enum26.const_17)
                        {
                            ArrayList qQSQ = class3.QQSQ;
                            if ((qQSQ != null) && (qQSQ.Count > 0))
                            {
                                Class428 class4 = qQSQ[qQSQ.Count - 1] as Class428;
                                if (class4 != null)
                                {
                                    if (class4.arrayList_0 == null)
                                    {
                                        qQSQ.Remove(class4);
                                    }
                                    else
                                    {
                                        qQSQ[qQSQ.Count - 1] = class4.method_7();
                                    }
                                }
                            }
                            smethod_1(class2.QQSQ, 0);
                        }
                    }
                }
            }
        }
    }
}

