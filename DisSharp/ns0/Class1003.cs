namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1003
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0);
                if (!bool_0)
                {
                    flag = false;
                }
                if (!flag)
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (class2.Type == Enum26.const_6)
                {
                    A_0.RemoveAt(i);
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ != null)
                    {
                        for (int j = qQSQ.Count - 1; j >= 0; j--)
                        {
                            A_0.Insert(i, qQSQ[j]);
                        }
                    }
                    bool_0 = true;
                    return;
                }
                if (class2.QQSQ != null)
                {
                    smethod_1(class2.QQSQ);
                }
            }
        }
    }
}

