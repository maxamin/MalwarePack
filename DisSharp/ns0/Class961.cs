namespace ns0
{
    using System;

    internal class Class961
    {
        internal static bool bool_0;
        internal static Class445 class445_0;

        internal static bool smethod_0(int A_0)
        {
            Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_0] as Class548.Class529;
            if (!class2.Boolean_13)
            {
                return false;
            }
            Class370 class3 = class2.class369_0 as Class370;
            if ((class3.byte_0 & 1) != 0)
            {
                bool_0 = true;
            }
            else
            {
                bool_0 = false;
            }
            return true;
        }

        internal static bool smethod_1(int A_0)
        {
            Class553.Class531 class2 = Class546.class553_0.arrayList_0[A_0] as Class553.Class531;
            if (class2.Boolean_0)
            {
                bool_0 = class2.Boolean_2;
                return true;
            }
            return false;
        }

        internal static bool smethod_2(Enum11 A_0, int A_1)
        {
            switch (A_0)
            {
                case Enum11.const_36:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_1] as Class548.Class529;
                    if (!class2.Boolean_13)
                    {
                        return false;
                    }
                    class445_0 = new Class472(Enum0.const_2, A_1, 0L, ((class2.class369_0 as Class370).byte_0 & 1) != 0);
                    return true;
                }
                case Enum11.const_38:
                {
                    Class553.Class531 class3 = Class546.class553_0.arrayList_0[A_1] as Class553.Class531;
                    if (class3.Boolean_0)
                    {
                        class445_0 = new Class472(Enum0.const_1, A_1, 0L, class3.Boolean_2);
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
    }
}

