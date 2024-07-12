namespace ns0
{
    using System;

    internal class Class892
    {
        private static Class893 class893_0;

        private static void smethod_0(int A_0, int A_1)
        {
        while (true)
    {
        int num;
        int num2;
        int num3;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            num3 = class893_0[(A_0 + A_1) >> 1];
            break;
        }
        while (true)
        {
            if (class893_0[num] < num3)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (class893_0[num2] > num3)
                {
                    num2--;
                    continue;
                }
                if (num <= num2)
                {
                    class893_0[num] = class893_0[num2];
                    class893_0[num2] = class893_0[num];
                    num++;
                    num2--;
                }
                if (num > num2)
                {
                    if (A_0 < num2)
                    {
                        smethod_0(A_0, num2);
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

        internal static void smethod_1(Class893 A_0)
        {
            if (A_0.int_1 > 1)
            {
                class893_0 = A_0;
                smethod_0(0, class893_0.int_1 - 1);
            }
        }
    }
}

