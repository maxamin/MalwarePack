namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.Globalization;

    internal class Class809
    {
        private static bool bool_0;
        private static CultureInfo cultureInfo_0;
        private static StringCollection stringCollection_0;

        private static void smethod_0(int A_0, int A_1)
        {
        while (true)
    {
        int num;
        int num2;
        string str;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            str = stringCollection_0[(A_0 + A_1) >> 1];
            break;
        }
        while (true)
        {
            if (string.Compare(stringCollection_0[num], str, bool_0, cultureInfo_0) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (string.Compare(stringCollection_0[num2], str, bool_0, cultureInfo_0) > 0)
                {
                    num2--;
                    continue;
                }
                if (num <= num2)
                {
                    stringCollection_0[num] = stringCollection_0[num2];
                    stringCollection_0[num2] = stringCollection_0[num];
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

        internal static void smethod_1(StringCollection A_0, bool A_1)
        {
            if (A_0.Count > 1)
            {
                stringCollection_0 = A_0;
                bool_0 = A_1;
                cultureInfo_0 = CultureInfo.CurrentCulture;
                smethod_0(0, A_0.Count - 1);
            }
        }
    }
}

