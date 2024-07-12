namespace ns0
{
    using System;

    internal class Class860
    {
        private static bool bool_0;
        internal static bool bool_1;
        private static Enum0 enum0_0;
        private static int int_0;

        internal static Class445 smethod_0(Class445 A_0, Class658 A_1)
        {
            if (smethod_2(A_1))
            {
                Class658 class2 = Class821.smethod_0(A_0);
                if ((class2.enum11_0 == A_1.enum11_0) && (class2.int_0 == A_1.int_0))
                {
                    return A_0;
                }
                return smethod_4(A_0, class2, A_1, true);
            }
            Class658 class3 = Class821.smethod_0(A_0);
            if (bool_1)
            {
                return new Class497(A_0, (uint) A_1.int_0, new Class445[] { new Class496() });
            }
            if (smethod_3(class3))
            {
                return Class996.smethod_1(A_0, A_1.enum11_0);
            }
            return Class996.smethod_2(A_0, class3.enum11_0, A_1.enum11_0);
        }

        internal static Class445 smethod_1(Class463 A_0, Class658 A_1)
        {
            if (smethod_2(A_1))
            {
                return new Class467(A_0, Class689.smethod_0(enum0_0, int_0));
            }
            Class658 class2 = Class821.smethod_0(A_0.class445_0);
            if (smethod_3(class2))
            {
                A_0.class445_0 = Class996.smethod_1(A_0.class445_0, A_1.enum11_0);
            }
            else
            {
                A_0.class445_0 = Class996.smethod_2(A_0.class445_0, class2.enum11_0, A_1.enum11_0);
            }
            class2 = Class821.smethod_0(A_0.class445_1);
            if (smethod_3(class2))
            {
                A_0.class445_1 = Class996.smethod_1(A_0.class445_1, A_1.enum11_0);
                return A_0;
            }
            A_0.class445_1 = Class996.smethod_2(A_0.class445_1, class2.enum11_0, A_1.enum11_0);
            return A_0;
        }

        private static bool smethod_2(Class658 A_0)
        {
            int_0 = A_0.int_0;
            switch (A_0.enum11_0)
            {
                case Enum11.const_36:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[int_0] as Class548.Class529;
                    enum0_0 = Enum0.const_2;
                    bool_0 = class2.Boolean_15;
                    return class2.Boolean_13;
                }
                case Enum11.const_38:
                {
                    Class553.Class531 class3 = Class546.class553_0.arrayList_0[int_0] as Class553.Class531;
                    enum0_0 = Enum0.const_1;
                    bool_0 = class3.Boolean_2;
                    return class3.Boolean_0;
                }
            }
            return false;
        }

        private static bool smethod_3(Class658 A_0)
        {
            switch (A_0.enum11_0)
            {
                case Enum11.const_36:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[A_0.int_0] as Class548.Class529;
                    return class2.Boolean_13;
                }
                case Enum11.const_38:
                {
                    Class553.Class531 class3 = Class546.class553_0.arrayList_0[A_0.int_0] as Class553.Class531;
                    return class3.Boolean_0;
                }
            }
            return false;
        }

        private static Class445 smethod_4(Class445 A_0, Class658 A_1, Class658 A_2, bool A_3)
        {
            switch (A_0.Type)
            {
                case Enum17.const_22:
                    return new Class472(enum0_0, int_0, (long) (A_0 as Class447).int_0, bool_0);

                case Enum17.const_23:
                    return new Class472(enum0_0, int_0, (A_0 as Class448).long_0, bool_0);
            }
            if (((A_1.enum11_0 == A_2.enum11_0) && (A_1.int_0 == A_2.int_0)) && (A_1.byte_0 == A_2.byte_0))
            {
                return A_0;
            }
            if (A_3)
            {
                return new Class467(A_0, Class689.smethod_0(enum0_0, int_0));
            }
            return A_0.QQUU(A_2);
        }
    }
}

