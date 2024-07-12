namespace ns0
{
    using System;
    using System.Collections;

    internal class Class900
    {
        internal static void smethod_0()
        {
            if (Class536.class901_0.arrayList_0 != null)
            {
                Class902.smethod_3(Class536.class901_0);
                bool flag = true;
                while (true)
                {
                    Class901 class2 = Class902.smethod_4();
                    if (class2 != null)
                    {
                        if (!class2.bool_1 && (class2.int_2 >= 0))
                        {
                            Class398 class3 = Class536.class398_0[class2.int_2];
                            if (class3.arrayList_0 != null)
                            {
                                bool flag2;
                                do
                                {
                                    flag2 = false;
                                    ArrayList list = class3.arrayList_0;
                                    int count = list.Count;
                                    for (int i = 0; i < count; i++)
                                    {
                                        Class398 class4 = list[i] as Class398;
                                        switch (class2.enum58_0)
                                        {
                                            case Enum58.const_0:
                                                smethod_3(class4, class3);
                                                break;

                                            case Enum58.const_1:
                                            case Enum58.const_4:
                                            case Enum58.const_7:
                                            case Enum58.const_10:
                                            case Enum58.const_12:
                                            case Enum58.const_15:
                                                smethod_1(class2, class4, class3);
                                                break;

                                            case Enum58.const_5:
                                            case Enum58.const_8:
                                            case Enum58.const_13:
                                                smethod_2(class4, class3);
                                                break;
                                        }
                                        if ((count != list.Count) && (list.Count > 0))
                                        {
                                            flag2 = true;
                                            break;
                                        }
                                    }
                                }
                                while (flag2);
                            }
                        }
                    }
                    else
                    {
                        flag = false;
                    }
                    if (!flag)
                    {
                        return;
                    }
                }
            }
        }

        private static void smethod_1(Class901 A_0, Class398 A_1, Class398 A_2)
        {
            int num = A_1.ushort_1;
            if ((A_0.int_2 > num) || (num > A_0.int_3))
            {
                smethod_4(A_1, A_2, Class902.int_2 - 1, A_0);
            }
        }

        private static void smethod_2(Class398 A_0, Class398 A_1)
        {
            if (Class902.int_2 > 1)
            {
                Class901 class2 = Class902.smethod_0(Class902.int_2 - 2);
                int num = A_0.ushort_1;
                if ((class2.int_2 > num) || (num > class2.int_3))
                {
                    smethod_4(A_0, A_1, Class902.int_2 - 2, class2);
                }
            }
        }

        private static void smethod_3(Class398 A_0, Class398 A_1)
        {
            if (Class902.int_2 > 1)
            {
                Class901 class2 = Class902.smethod_0(Class902.int_2 - 2);
                if (class2.int_2 == A_1.ushort_1)
                {
                    switch (class2.enum58_0)
                    {
                        case Enum58.const_1:
                        case Enum58.const_10:
                        case Enum58.const_15:
                        {
                            int num = A_0.ushort_1;
                            if ((class2.int_2 > num) || (num > class2.int_3))
                            {
                                smethod_4(A_0, A_1, Class902.int_2 - 2, class2);
                            }
                            break;
                        }
                    }
                }
            }
        }

        private static void smethod_4(Class398 A_0, Class398 A_1, int A_2, Class901 A_3)
        {
            if (A_2 == 0)
            {
                Class689.smethod_4(A_0, A_1, A_3.class398_0);
            }
            else if (Class902.smethod_1(A_2) > 0)
            {
                Class689.smethod_4(A_0, A_1, A_3.class398_0);
            }
            else
            {
                Class901 class2 = Class902.smethod_0(A_2 - 1);
                int num = A_0.ushort_1;
                if (((class2.int_3 != -1) && (num >= class2.int_2)) && (num <= class2.int_3))
                {
                    Class689.smethod_4(A_0, A_1, class2.class398_0);
                }
                else
                {
                    smethod_4(A_0, A_1, A_2 - 1, class2);
                }
            }
        }
    }
}

