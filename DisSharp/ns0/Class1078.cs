namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1078
    {
        private static int int_0;

        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            int num = A_0.Count - 1;
            for (int i = 0; i < A_0.Count; i++)
            {
                Class418 class2 = A_0[i] as Class418;
                if (class2 != null)
                {
                    if (i == num)
                    {
                        class2.bool_1 = smethod_3(class2.QQSQ);
                    }
                    else
                    {
                        Class398 class3 = A_0[i + 1] as Class398;
                        if ((class3.Type != Enum26.const_9) && (class3.Type != Enum26.const_10))
                        {
                            class2.bool_1 = smethod_3(class2.QQSQ);
                        }
                        else
                        {
                            smethod_2(class2, A_0, i + 1);
                            i += int_0;
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

        private static void smethod_2(Class418 A_0, ArrayList A_1, int A_2)
        {
            bool flag = false;
            flag = smethod_3(A_0.QQSQ);
            int_0 = 0;
            for (int i = A_2; i < A_1.Count; i++)
            {
                Class398 class2 = A_1[i] as Class398;
                if ((class2.Type != Enum26.const_9) && (class2.Type != Enum26.const_10))
                {
                    break;
                }
                if (!flag)
                {
                    flag = smethod_3(class2.QQSQ);
                }
                int_0++;
            }
            if (Class689.smethod_6(A_0.QQSQ))
            {
                flag = true;
            }
            if (flag)
            {
                A_0.bool_1 = true;
                for (int j = A_2; j < (A_2 + int_0); j++)
                {
                    Class410 class3 = A_1[j] as Class410;
                    if (class3 != null)
                    {
                        class3.bool_1 = true;
                    }
                    else
                    {
                        Class411 class4 = A_1[j] as Class411;
                        class4.bool_1 = true;
                    }
                }
            }
            else
            {
                A_0.bool_1 = false;
                for (int k = A_2; k < (A_2 + int_0); k++)
                {
                    Class410 class5 = A_1[k] as Class410;
                    if (class5 != null)
                    {
                        class5.bool_1 = false;
                    }
                    else
                    {
                        Class411 class6 = A_1[k] as Class411;
                        class6.bool_1 = false;
                    }
                }
            }
        }

        private static bool smethod_3(ArrayList A_0)
        {
            if (Class516.bool_10)
            {
                return true;
            }
            if (A_0 == null)
            {
                return true;
            }
            int num = 0;
            int count = A_0.Count;
            for (int i = 0; i < count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (((i == 0) && (count == 1)) && smethod_4(class2))
                {
                    return true;
                }
                if (class2.QQRZ || (class2.arrayList_0 != null))
                {
                    return true;
                }
                if (!class2.bool_0 && (class2.Type != Enum26.const_36))
                {
                    num++;
                }
                if (num > 1)
                {
                    return true;
                }
            }
            return (num == 0);
        }

        private static bool smethod_4(Class398 A_0)
        {
            Class399 class2 = A_0 as Class399;
            return ((class2 != null) && (class2.class445_0 is Class492));
        }
    }
}

