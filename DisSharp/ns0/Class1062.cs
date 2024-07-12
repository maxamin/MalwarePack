namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1062
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
                if (!flag || (num >= 0x19))
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
                Class433 class3 = class2 as Class433;
                if (class3 != null)
                {
                    ArrayList list = class3.QQSQ;
                    if (smethod_2(list))
                    {
                        Class434 class4 = list[list.Count - 1] as Class434;
                        list.Remove(class4);
                        for (int j = 0; j < list.Count; j++)
                        {
                            Class434 class5 = list[j] as Class434;
                            class5.enum29_0 = Enum29.const_2;
                        }
                        ArrayList list2 = class4.QQSQ;
                        if (class4.enum29_0 == Enum29.const_3)
                        {
                            if (i < (A_0.Count - 1))
                            {
                                Class398 class6 = A_0[i + 1] as Class398;
                                if (class6.Type != Enum26.const_28)
                                {
                                    list2.Add(new Class428());
                                }
                            }
                            else
                            {
                                list2.Add(new Class428());
                            }
                        }
                        for (int k = list2.Count - 1; k >= 0; k--)
                        {
                            A_0.Insert(i + 1, list2[k]);
                        }
                        bool_0 = true;
                        return;
                    }
                }
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static bool smethod_2(ArrayList A_0)
        {
            Class434 class2;
            for (int i = 0; i < (A_0.Count - 1); i++)
            {
                class2 = A_0[i] as Class434;
                if ((class2.enum27_0 != Enum27.const_0) || (class2.enum29_0 != Enum29.const_1))
                {
                    return false;
                }
            }
            class2 = A_0[A_0.Count - 1] as Class434;
            return ((class2.enum27_0 == Enum27.const_1) || ((class2.enum29_0 != Enum29.const_0) && (class2.enum29_0 != Enum29.const_1)));
        }
    }
}

