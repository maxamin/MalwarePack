namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1081
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
                if (!flag || (num >= 250))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0, bool A_1)
        {
            if (A_1 && (A_0.Count >= 2))
            {
                int index = A_0.Count - 1;
                int num2 = index - 1;
                Class418 class2 = A_0[num2] as Class418;
                if ((class2 != null) && Class689.smethod_6(class2.QQSQ))
                {
                    Class410 class3 = A_0[index] as Class410;
                    if (class3 != null)
                    {
                        if (class2.QQSQ != null)
                        {
                            class2.QQSQ.Clear();
                        }
                        class2.QQSR(new Class408());
                        class2.bool_1 = Class516.bool_10;
                        A_0.RemoveAt(index);
                        ArrayList qQSQ = class3.QQSQ;
                        if (qQSQ != null)
                        {
                            for (int j = qQSQ.Count - 1; j >= 0; j--)
                            {
                                A_0.Insert(index, qQSQ[j]);
                            }
                        }
                        bool_0 = true;
                        return;
                    }
                }
            }
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class4 = A_0[i] as Class398;
                ArrayList list2 = class4.QQSQ;
                if (list2 != null)
                {
                    switch (class4.Type)
                    {
                        case Enum26.const_42:
                        case Enum26.const_43:
                        case Enum26.const_8:
                        case Enum26.const_14:
                            goto Label_010B;
                    }
                    smethod_1(list2, false);
                }
                continue;
            Label_010B:
                smethod_1(list2, true);
            }
        }
    }
}

