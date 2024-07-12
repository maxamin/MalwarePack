namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1109
    {
        private static bool bool_0;
        private static Class417 class417_0;

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
                if (!flag || (num >= 250))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            int num = A_0.Count - 2;
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (i < num)
                {
                    Class418 class3 = class2 as Class418;
                    if ((class3 != null) && smethod_2(class3, A_0[i + 2]))
                    {
                        Class410 class4 = A_0[i + 1] as Class410;
                        if (class4 != null)
                        {
                            ArrayList list = class4.QQSQ;
                            if (list != null)
                            {
                                ArrayList list2 = class3.QQSQ;
                                if (list2 != null)
                                {
                                    list2.Clear();
                                }
                                for (int j = 0; j < list.Count; j++)
                                {
                                    class3.QQSR(list[j] as Class398);
                                }
                                A_0.Remove(class4);
                                class3.class445_0 = Class1023.smethod_0(class3.class445_0);
                                class417_0.class398_0.method_1(class417_0);
                                bool_0 = true;
                                return;
                            }
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

        private static bool smethod_2(Class418 A_0, object A_1)
        {
            ArrayList qQSQ = A_0.QQSQ;
            if (qQSQ == null)
            {
                return false;
            }
            if (qQSQ.Count != 1)
            {
                return false;
            }
            class417_0 = qQSQ[0] as Class417;
            if (class417_0 == null)
            {
                return false;
            }
            return (class417_0.class398_0 == A_1);
        }
    }
}

