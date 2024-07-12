namespace ns0
{
    using System;
    using System.Collections;

    internal class Class866
    {
        private static ArrayList arrayList_0;

        private static int smethod_0(Class865 A_0, Class865 A_1)
        {
            if (A_0.int_0 == A_1.int_0)
            {
                if (A_0.int_1 == A_1.int_1)
                {
                    return 0;
                }
                if (A_0.int_1 >= A_1.int_1)
                {
                    return -1;
                }
                return 1;
            }
            if (A_0.int_0 >= A_1.int_0)
            {
                return 1;
            }
            return -1;
        }

        private static void smethod_1(int A_0, int A_1)
        {
        while (true)
    {
        int num;
        int num2;
        Class865 class2;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            class2 = arrayList_0[(A_0 + A_1) >> 1] as Class865;
            break;
        }
        while (true)
        {
            if (smethod_0(arrayList_0[num] as Class865, class2) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (smethod_0(arrayList_0[num2] as Class865, class2) > 0)
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
                        smethod_1(A_0, num2);
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

        internal static void smethod_2(ArrayList A_0)
        {
            if (A_0.Count > 1)
            {
                arrayList_0 = A_0;
                smethod_1(0, A_0.Count - 1);
            }
        }
    }
}

