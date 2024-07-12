namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1053
    {
        internal static void smethod_0()
        {
            bool flag = false;
            if (Class979.bool_0)
            {
                Class979.smethod_0();
            }
            Class526.bool_0 = true;
            int num = 0;
            bool flag2 = true;
            while (true)
            {
                Class1021.bool_0 = false;
                smethod_1(Class536.arrayList_0);
                if (Class979.bool_0)
                {
                    flag = true;
                    Class979.bool_0 = false;
                }
                if (!Class1021.bool_0)
                {
                    flag2 = false;
                }
                num++;
                if (!flag2 || (num >= 0x19))
                {
                    Class1021.bool_0 = false;
                    Class526.bool_0 = false;
                    if (flag)
                    {
                        Class979.smethod_11();
                    }
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            if (Class979.bool_0)
            {
                Class979.smethod_1();
            }
            if (A_0 != null)
            {
                Class1021.arrayList_0 = A_0;
                Class1021.arrayList_1.Clear();
                for (int i = 0; i < A_0.Count; i++)
                {
                    Class1021.int_0 = i;
                    if (Class979.bool_0)
                    {
                        Class979.smethod_3(i);
                    }
                    Class658.smethod_0();
                    Class398 class2 = A_0[i] as Class398;
                    Class398 class3 = class2.QQUS();
                    if (class3 != class2)
                    {
                        class2.method_6(class3);
                        A_0[i] = class3;
                    }
                }
                if (Class1021.arrayList_1.Count > 0)
                {
                    for (int k = 0; k < Class1021.arrayList_1.Count; k++)
                    {
                        A_0.Remove(Class1021.arrayList_1[k]);
                    }
                }
                for (int j = 0; j < A_0.Count; j++)
                {
                    ArrayList qQSQ = (A_0[j] as Class398).QQSQ;
                    if (Class979.bool_0)
                    {
                        Class979.smethod_3(j);
                    }
                    smethod_1(qQSQ);
                }
            }
            if (Class979.bool_0)
            {
                Class979.smethod_2();
            }
        }
    }
}

