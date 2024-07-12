namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1082
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            if (A_0 != null)
            {
                int count = A_0.Count;
                if (count > 0)
                {
                    Class428 class2 = A_0[count - 1] as Class428;
                    if (class2 != null)
                    {
                        bool flag = false;
                        if ((class2.class445_0 == null) || (Class519.class528_0.enum11_0 == Enum11.const_15))
                        {
                            if (class2.ushort_0 == 0)
                            {
                                A_0.Remove(class2);
                                flag = true;
                            }
                            else
                            {
                                class2.bool_0 = true;
                            }
                            if (flag && (A_0.Count > 0))
                            {
                                class2 = A_0[A_0.Count - 1] as Class428;
                                if ((class2 != null) && (class2.class445_0 == null))
                                {
                                    if (class2.ushort_0 == 0)
                                    {
                                        A_0.Remove(class2);
                                    }
                                    else
                                    {
                                        class2.bool_0 = true;
                                    }
                                }
                            }
                        }
                        if (!flag)
                        {
                            count = A_0.Count;
                            if (count >= 2)
                            {
                                Class428 class3 = A_0[count - 1] as Class428;
                                if ((class3 != null) && smethod_2(A_0[count - 2] as Class398))
                                {
                                    A_0.Remove(class3);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static bool smethod_2(Class398 A_0)
        {
            switch (A_0.Type)
            {
                case Enum26.const_26:
                {
                    ArrayList qQSQ = A_0.QQSQ;
                    if ((qQSQ == null) || (qQSQ.Count <= 0))
                    {
                        return false;
                    }
                    return smethod_2(qQSQ[qQSQ.Count - 1] as Class398);
                }
                case Enum26.const_28:
                case Enum26.const_37:
                    return true;
            }
            return false;
        }
    }
}

