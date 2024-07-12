namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1100
    {
        private static ArrayList arrayList_0;
        private static string string_0 = Class537.string_833;

        internal static void smethod_0(ArrayList A_0, short[] A_1, Class581 A_2)
        {
            if (A_0.Count > 1)
            {
                int length = A_1.Length;
                arrayList_0 = new ArrayList();
                for (int i = 0; i < length; i++)
                {
                    Class562.Class533 class2 = A_0[A_1[i]] as Class562.Class533;
                    string str = A_2[class2.int_1];
                    Class1099 class3 = new Class1099 {
                        string_0 = str,
                        short_0 = A_1[i]
                    };
                    if ((str.Length >= 6) && str.StartsWith(string_0))
                    {
                        class3.bool_0 = true;
                    }
                    arrayList_0.Add(class3);
                }
                smethod_2(0, length - 1);
                for (int j = 0; j < length; j++)
                {
                    A_1[j] = (arrayList_0[j] as Class1099).short_0;
                }
            }
        }

        private static int smethod_1(Class1099 A_0, Class1099 A_1)
        {
            if (A_0.bool_0)
            {
                if (A_1.bool_0)
                {
                    return string.Compare(A_0.string_0, A_1.string_0);
                }
                return -1;
            }
            if (A_1.bool_0)
            {
                return 1;
            }
            return string.Compare(A_0.string_0, A_1.string_0);
        }

        private static void smethod_2(int A_0, int A_1)
        {
        while (true)
    {
        int num;
        int num2;
        Class1099 class2;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            class2 = arrayList_0[(A_0 + A_1) >> 1] as Class1099;
            break;
        }
        while (true)
        {
            if (smethod_1(arrayList_0[num] as Class1099, class2) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (smethod_1(arrayList_0[num2] as Class1099, class2) > 0)
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

