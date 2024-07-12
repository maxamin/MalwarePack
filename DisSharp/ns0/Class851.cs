namespace ns0
{
    using System;
    using System.Collections;

    internal class Class851
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
                if (!flag || (num >= 0x7d))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < (A_0.Count - 1); i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (class2.Type == Enum26.const_0)
                {
                    Class399 class3 = A_0[i] as Class399;
                    Class452 class4 = class3.class445_0 as Class452;
                    if (class4 != null)
                    {
                        int index = class4.ushort_0;
                        if (Class525.bool_0[index])
                        {
                            int num3 = smethod_2(A_0, i, index);
                            if (num3 != -1)
                            {
                                Class525.bool_1[index] = true;
                                Class413 class5 = new Class413(class4, class3.class445_1);
                                for (int k = i + 1; k < num3; k++)
                                {
                                    class5.QQSR(A_0[k] as Class398);
                                }
                                Class689.smethod_5(class3, class5);
                                Class689.smethod_2(A_0, i, (num3 - i) + 1);
                                A_0.Insert(i, class5);
                            }
                        }
                    }
                }
            }
            for (int j = 0; j < A_0.Count; j++)
            {
                ArrayList qQSQ = (A_0[j] as Class398).QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static int smethod_2(ArrayList A_0, int A_1, int A_2)
        {
            for (int i = A_0.Count - 1; i > A_1; i--)
            {
                Class398 class2 = A_0[i] as Class398;
                if (class2.Type == Enum26.const_0)
                {
                    Class399 class3 = A_0[i] as Class399;
                    Class452 class4 = class3.class445_0 as Class452;
                    if ((class4 != null) && (class4.ushort_0 == A_2))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}

