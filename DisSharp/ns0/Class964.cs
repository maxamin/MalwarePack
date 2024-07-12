namespace ns0
{
    using System;
    using System.Collections;

    internal class Class964
    {
        private static ArrayList arrayList_0;
        private static string string_0 = Class537.string_833;

        internal static void smethod_0(ArrayList A_0)
        {
            arrayList_0 = A_0;
            if (arrayList_0.Count > 1)
            {
                smethod_2(0, arrayList_0.Count - 1);
            }
        }

        private static int smethod_1(Class963 A_0, Class963 A_1)
        {
            if (A_0.string_1 == "")
            {
                if (A_1.string_1 == "")
                {
                    return string.Compare(A_0.string_0, A_1.string_0);
                }
                return -1;
            }
            if (A_1.string_1 == "")
            {
                return 1;
            }
            if (A_0.string_1 == A_1.string_1)
            {
                return string.Compare(A_0.string_0, A_1.string_0);
            }
            return string.Compare(A_0.string_1, A_1.string_1);
        }

        private static void smethod_2(int A_0, int A_1)
        {
        while (true)
    {
        int num;
        int num2;
        Class963 class2;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            class2 = arrayList_0[(A_0 + A_1) >> 1] as Class963;
            break;
        }
        while (true)
        {
            if (smethod_1(arrayList_0[num] as Class963, class2) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (smethod_1(arrayList_0[num2] as Class963, class2) > 0)
                {
                    num2--;
                    continue;
                }
                if (num <= num2)
                {
                    arrayList_0[num] = arrayList_0[num2];
                    arrayList_0[num2] = arrayList_0[num];
                    num++;
                    num2--;
                }
                if (num > num2)
                {
                    if (A_0 < num2)
                    {
                        smethod_2(A_0, num2);
                    }
                    A_0 = num;
                    if (num >= A_1)
                    {
                        return;
                    }
                }
                else
                {
                    continue;
                }
                break;
            }
            break;
        }
    }

        }
    }
}

