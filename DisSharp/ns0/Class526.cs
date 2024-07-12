namespace ns0
{
    using System;

    internal class Class526
    {
        internal static bool bool_0;
        internal static bool bool_1;

        internal static void smethod_0(Class522 A_0, Enum2 A_1)
        {
            Exception exception = null;
            bool flag;
            Class981.smethod_0();
            int num = 0;
            int count = Class1047.arrayList_0.Count;
            int num3 = 0;
            int num4 = 0;
            bool flag2 = true;
            bool_0 = false;
            bool_1 = false;
            Class979.bool_0 = true;
            do
            {
                num3 = count;
                flag = false;
                try
                {
                    Class536.smethod_0();
                    try
                    {
                        Class1048.smethod_0(A_0);
                        Class1049.smethod_10(A_0);
                        Class1050.smethod_0();
                        Class1050.smethod_1();
                        Class1022.smethod_0(A_0);
                        Class1051.smethod_0();
                        Class956.smethod_0();
                        Class933.smethod_0();
                        Class1003.smethod_0();
                        Class900.smethod_0();
                        if (A_1 == Enum2.const_1)
                        {
                            Class1052.smethod_0();
                            return;
                        }
                    }
                    catch
                    {
                        flag2 = false;
                        throw;
                    }
                    num4 = 0;
                    num = 0;
                    while (num < count)
                    {
                        num4++;
                        Class1046 class2 = Class1047.arrayList_0[num] as Class1046;
                        if ((class2.int_0 & (int)Class516.enum6_0) != 0)
                        {
                            class2.delegate3_0();
                        }
                        num++;
                    }
                }
                catch (Exception exception2)
                {
                    if (((num > 0) && (count > 0)) && flag2)
                    {
                        flag = true;
                    }
                    else
                    {
                        exception = exception2;
                    }
                }
                count = num;
            }
            while (flag);
            if (exception != null)
            {
                throw exception;
            }
            if (num3 < Class1047.arrayList_0.Count)
            {
                if (!bool_0)
                {
                    Class1053.smethod_0();
                }
                for (int i = 0; i < Class1047.arrayList_1.Count; i++)
                {
                    Class1046 class3 = Class1047.arrayList_1[i] as Class1046;
                    if ((class3.int_0 & (int)Class516.enum6_0) != 0)
                    {
                        class3.delegate3_0();
                    }
                }
            }
            else if (!bool_1)
            {
                Class519.class528_0.uint_25 |= 0x10000;
            }
        }
    }
}

