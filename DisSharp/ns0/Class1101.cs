namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1101
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0);
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 200))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            int num = A_0.Count - 1;
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (class2.Type == Enum26.const_9)
                {
                    if (Class689.smethod_6(class2.QQSQ))
                    {
                        if (class2.arrayList_0 == null)
                        {
                            A_0.RemoveAt(i);
                            bool_0 = true;
                            return;
                        }
                        Class436 class3 = new Class436();
                        Class689.smethod_5(class2, class3);
                        A_0[i] = class3;
                    }
                    if (((i < num) && (class2.QQSQ != null)) && (class2.QQSQ.Count == 1))
                    {
                        Class417 class4 = class2.QQSQ[0] as Class417;
                        if ((class4 != null) && (class4.class398_0 == A_0[i + 1]))
                        {
                            class4.class398_0.method_1(class4);
                            A_0.RemoveAt(i);
                            bool_0 = true;
                            return;
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

