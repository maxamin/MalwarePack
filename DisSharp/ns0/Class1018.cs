namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1018
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private static bool bool_0;
        private static Class398 class398_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0, false, null, 0);
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

        private static void smethod_1(ArrayList A_0, bool A_1, ArrayList A_2, int A_3)
        {
            if ((A_1 && (A_0.Count >= 2)) && (smethod_2(A_0) && smethod_4(A_2, A_3)))
            {
                bool_0 = true;
            }
            else
            {
                for (int i = 0; i < A_0.Count; i++)
                {
                    Class398 class2 = A_0[i] as Class398;
                    ArrayList qQSQ = class2.QQSQ;
                    if (qQSQ != null)
                    {
                        if (class2.Type == Enum26.const_17)
                        {
                            smethod_1(qQSQ, true, A_0, i);
                        }
                        else
                        {
                            smethod_1(qQSQ, false, null, 0);
                        }
                    }
                    if (bool_0)
                    {
                        return;
                    }
                }
            }
        }

        private static bool smethod_2(ArrayList A_0)
        {
            arrayList_0.Clear();
            int num = A_0.Count - 1;
            Class404 class2 = A_0[num] as Class404;
            if (class2 == null)
            {
                return false;
            }
            if (!smethod_3(class2, true))
            {
                return false;
            }
            int num2 = num - 1;
            while (num2 > 0)
            {
                class2 = A_0[num2] as Class404;
                if (class2 == null)
                {
                    break;
                }
                if (!smethod_3(class2, false))
                {
                    return false;
                }
                num2--;
            }
            Class438 class3 = A_0[num2] as Class438;
            if (class3 == null)
            {
                return false;
            }
            if (!smethod_3(class3, false))
            {
                return false;
            }
            return true;
        }

        private static bool smethod_3(Class398 A_0, bool A_1)
        {
            ArrayList qQSQ = A_0.QQSQ;
            if ((qQSQ != null) && (qQSQ.Count != 0))
            {
                Class425 class2 = qQSQ[qQSQ.Count - 1] as Class425;
                if (class2 == null)
                {
                    return false;
                }
                if (A_1)
                {
                    arrayList_0.Add(qQSQ);
                    class398_0 = class2.class398_0;
                    return true;
                }
                if (class2.class398_0 == class398_0)
                {
                    arrayList_0.Add(qQSQ);
                    return true;
                }
            }
            return false;
        }

        private static bool smethod_4(ArrayList A_0, int A_1)
        {
            int count = A_0.Count;
            int num2 = A_1 + 1;
            bool flag = false;
            while (num2 < count)
            {
                if (A_0[num2] == class398_0)
                {
                    flag = true;
                    break;
                }
                num2++;
            }
            if (!flag)
            {
                return false;
            }
            int num3 = A_1 + 1;
            int num4 = num2 - num3;
            Class410 class2 = new Class410();
            for (int i = num3; i < num2; i++)
            {
                class2.QQSR(A_0[i] as Class398);
            }
            Class689.smethod_2(A_0, num3, num4);
            A_0.Insert(num3, class2);
            for (int j = 0; j < arrayList_0.Count; j++)
            {
                ArrayList list = arrayList_0[j] as ArrayList;
                int index = list.Count - 1;
                Class425 class3 = list[index] as Class425;
                class3.class398_0.method_1(class3);
                if (class3.arrayList_0 != null)
                {
                    list[index] = class3.method_7();
                }
                else
                {
                    list.RemoveAt(index);
                }
            }
            return true;
        }
    }
}

