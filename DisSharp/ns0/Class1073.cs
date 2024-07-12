namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1073
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0, false);
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 0x7d))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0, bool A_1)
        {
            if (A_1)
            {
                for (int j = 0; j < (A_0.Count - 2); j++)
                {
                    Class418 class2 = A_0[j] as Class418;
                    if (class2 != null)
                    {
                        Class398 class3 = A_0[j + 1] as Class398;
                        if (((class3.arrayList_0 == null) && (class3.Type != Enum26.const_9)) && (class3.Type != Enum26.const_10))
                        {
                            ArrayList qQSQ = class2.QQSQ;
                            if (qQSQ != null)
                            {
                                Class408 class4 = qQSQ[qQSQ.Count - 1] as Class408;
                                if (class4 != null)
                                {
                                    Class410 class5 = new Class410();
                                    for (int k = j + 1; k < A_0.Count; k++)
                                    {
                                        class5.QQSR(A_0[k] as Class398);
                                    }
                                    qQSQ.Remove(class4);
                                    Class689.smethod_3(A_0, j + 1);
                                    A_0.Add(class5);
                                }
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class6 = A_0[i] as Class398;
                ArrayList list2 = class6.QQSQ;
                if (list2 != null)
                {
                    smethod_1(list2, class6.QQRY);
                }
            }
        }
    }
}

