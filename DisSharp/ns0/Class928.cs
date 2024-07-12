namespace ns0
{
    using System;
    using System.Collections;

    internal class Class928
    {
        private static ArrayList arrayList_0;

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
            num3 = (arrayList_0[(A_0 + A_1) >> 1] as Class927).int_0;
            break;
        }
        while (true)
        {
            if ((arrayList_0[num] as Class927).int_0 < num3)
            {
                num++;
                continue;
            }
            while (true)
            {
                if ((arrayList_0[num2] as Class927).int_0 > num3)
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

        internal static void smethod_1(ArrayList A_0)
        {
            if (A_0.Count > 1)
            {
                arrayList_0 = A_0;
                smethod_0(0, A_0.Count - 1);
            }
        }
    }
}

