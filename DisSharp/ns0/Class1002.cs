namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1002
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
                if (!flag || (num >= 250))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            if (A_0.Count >= 2)
            {
                for (int i = A_0.Count - 1; i >= 0; i--)
                {
                    Class398 class2 = A_0[i] as Class398;
                    if ((i >= 1) && (class2.Type == Enum26.const_28))
                    {
                        Class428 class3 = class2 as Class428;
                        Class445 class4 = class3.class445_0;
                        if ((class4 != null) && (class4.Type == Enum17.const_44))
                        {
                            Class452 class5 = class4 as Class452;
                            int num2 = i - 1;
                            Class398 class6 = A_0[num2] as Class398;
                            if ((i >= 2) && class6.bool_0)
                            {
                                num2 = i - 2;
                                class6 = A_0[num2] as Class398;
                            }
                            Class399 class7 = class6 as Class399;
                            if (class7 != null)
                            {
                                Class445 class8 = class7.class445_0;
                                if (class8.Type == Enum17.const_44)
                                {
                                    if ((class8 as Class452).ushort_0 == class5.ushort_0)
                                    {
                                        smethod_2(A_0, num2, class3, class7.class445_1);
                                        bool_0 = true;
                                        return;
                                    }
                                }
                                else if ((class8.Type == Enum17.const_46) && ((class8 as Class492).ushort_0 == class5.ushort_0))
                                {
                                    smethod_2(A_0, num2, class3, class7.class445_1);
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
        }

        private static void smethod_2(ArrayList A_0, int A_1, Class428 A_2, Class445 A_3)
        {
            Class689.smethod_2(A_0, A_1, 1);
            A_2.class445_0 = A_3;
        }
    }
}

