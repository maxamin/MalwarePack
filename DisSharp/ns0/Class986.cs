namespace ns0
{
    using System;
    using System.Collections;

    internal class Class986
    {
        internal static void smethod_0()
        {
            Class929.smethod_0();
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            int count = A_0.Count;
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                Class417 class3 = class2 as Class417;
                if ((class3 != null) && smethod_2(class3.class398_0))
                {
                    class3.class398_0.method_1(class3);
                    A_0[i] = new Class403();
                }
            }
            for (int j = 0; j < A_0.Count; j++)
            {
                Class398 class4 = A_0[j] as Class398;
                ArrayList qQSQ = class4.QQSQ;
                if (qQSQ != null)
                {
                    Class929.smethod_1(A_0, class4, j);
                    smethod_1(qQSQ);
                    Class929.smethod_2();
                }
            }
        }

        private static bool smethod_2(Class398 A_0)
        {
            int num = Class929.int_0 - 1;
            if (num >= 0)
            {
                bool flag = false;
                for (int i = num; i >= 0; i--)
                {
                    Struct8 struct2 = Class929.struct8_0[i];
                    Enum26 type = struct2.class398_0.Type;
                    if (!smethod_3(type))
                    {
                        return false;
                    }
                    flag |= smethod_4(type);
                    ArrayList list = struct2.arrayList_0;
                    int num3 = struct2.int_0;
                    if (num3 < (list.Count - 1))
                    {
                        Class398 class2 = list[num3 + 1] as Class398;
                        if (class2 == A_0)
                        {
                            return flag;
                        }
                    }
                }
            }
            return false;
        }

        private static bool smethod_3(Enum26 A_0)
        {
            switch (A_0)
            {
                case Enum26.const_8:
                case Enum26.const_9:
                case Enum26.const_10:
                case Enum26.const_14:
                case Enum26.const_17:
                case Enum26.const_42:
                case Enum26.const_43:
                    return true;
            }
            return false;
        }

        private static bool smethod_4(Enum26 A_0)
        {
            switch (A_0)
            {
                case Enum26.const_42:
                case Enum26.const_43:
                case Enum26.const_8:
                case Enum26.const_14:
                    return true;
            }
            return false;
        }
    }
}

