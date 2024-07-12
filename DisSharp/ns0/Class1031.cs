namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1031
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            Class974.smethod_0();
            try
            {
                int num = 0;
                bool flag = true;
            Label_0009:
                try
                {
                    bool_0 = false;
                    Class929.smethod_0();
                    smethod_1(Class536.arrayList_0);
                    if (!bool_0)
                    {
                        flag = false;
                    }
                    num++;
                }
                catch
                {
                    Class974.smethod_1();
                    num++;
                }
                while (flag)
                {
                    if (num < 250)
                    {
                        goto Label_0009;
                    }
                    goto Label_004B;
                }
            }
            catch
            {
            }
        Label_004B:
            Class988.smethod_1();
        }

        private static void smethod_1(ArrayList A_0)
        {
            Class973.arrayList_0 = A_0;
            for (ushort i = 0; i < A_0.Count; i = (ushort) (i + 1))
            {
                (A_0[i] as Class398).ushort_1 = i;
            }
            int num2 = 0;
            int num3 = A_0.Count - 1;
            while (num2 < num3)
            {
                Class398 class2 = A_0[num2] as Class398;
                if (class2.Type == Enum26.const_19)
                {
                    int num4 = Class972.smethod_0(num2, class2);
                    if (num4 == -1)
                    {
                        bool_0 = true;
                        return;
                    }
                    num2 += num4;
                    Class519.class528_0.uint_25 |= 0x20000;
                }
                num2++;
            }
            int count = A_0.Count;
            for (int j = 0; j < count; j++)
            {
                Class398 class3 = A_0[j] as Class398;
                ArrayList qQSQ = class3.QQSQ;
                if (qQSQ != null)
                {
                    Class929.smethod_1(A_0, class3, j);
                    smethod_1(qQSQ);
                    Class929.smethod_2();
                    if (A_0.Count != count)
                    {
                        return;
                    }
                }
            }
        }
    }
}

