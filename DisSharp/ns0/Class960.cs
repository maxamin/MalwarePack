namespace ns0
{
    using System;

    internal class Class960
    {
        private static Class959 class959_0 = new Class959();
        private static Class959 class959_1 = new Class959();

        internal static void smethod_0(Class470 A_0)
        {
            Class445 class2 = A_0.class445_0;
            Class445 class3 = A_0.class445_1;
            Class658 class4 = Class821.smethod_0(class2);
            Class658 class5 = Class821.smethod_0(class3);
            smethod_2(class4, class959_0);
            smethod_2(class5, class959_1);
            if (class959_0.bool_0)
            {
                Class447 class6 = class3 as Class447;
                if (class6 != null)
                {
                    A_0.class445_1 = new Class472(class959_0.enum0_0, class959_0.int_0, (long) class6.int_0, class959_0.bool_1);
                    return;
                }
            }
            if (class959_1.bool_0)
            {
                Class447 class7 = class2 as Class447;
                if (class7 != null)
                {
                    A_0.class445_0 = new Class472(class959_1.enum0_0, class959_1.int_0, (long) class7.int_0, class959_1.bool_1);
                    return;
                }
            }
            if (((!class959_0.bool_0 || !class959_1.bool_0) || (class959_0.enum0_0 != class959_1.enum0_0)) || (class959_0.int_0 != class959_1.int_0))
            {
                A_0.class445_0 = class2.QQUU(class5);
                A_0.class445_1 = class3.QQUU(class4);
            }
        }

        internal static void smethod_1(Class463 A_0)
        {
            Class445 class2 = A_0.class445_0;
            Class445 class3 = A_0.class445_1;
            Class658 class4 = Class821.smethod_0(class2);
            Class658 class5 = Class821.smethod_0(class3);
            smethod_2(class4, class959_0);
            smethod_2(class5, class959_1);
            if (class959_0.bool_0)
            {
                Class447 class6 = class3 as Class447;
                if (class6 != null)
                {
                    A_0.class445_1 = new Class472(class959_0.enum0_0, class959_0.int_0, (long) class6.int_0, class959_0.bool_1);
                    return;
                }
            }
            if (class959_1.bool_0)
            {
                Class447 class7 = class2 as Class447;
                if (class7 != null)
                {
                    A_0.class445_0 = new Class472(class959_1.enum0_0, class959_1.int_0, (long) class7.int_0, class959_1.bool_1);
                }
            }
        }

        private static void smethod_2(Class658 A_0, Class959 A_1)
        {
            A_1.bool_0 = false;
            switch (A_0.enum11_0)
            {
                case Enum11.const_36:
                case Enum11.const_37:
                    if (Class961.smethod_0(A_0.int_0))
                    {
                        A_1.bool_0 = true;
                        A_1.enum0_0 = Enum0.const_2;
                        A_1.int_0 = A_0.int_0;
                        A_1.bool_1 = Class961.bool_0;
                    }
                    return;

                case Enum11.const_38:
                case Enum11.const_39:
                    if (Class961.smethod_1(A_0.int_0))
                    {
                        A_1.bool_0 = true;
                        A_1.enum0_0 = Enum0.const_1;
                        A_1.int_0 = A_0.int_0;
                        A_1.bool_1 = Class961.bool_0;
                    }
                    break;

                case Enum11.const_40:
                    break;

                case Enum11.const_41:
                    switch (Class546.class558_0.method_1(A_0.int_0))
                    {
                        case Enum11.const_36:
                            if (Class961.smethod_0(A_0.int_0))
                            {
                                A_1.bool_0 = true;
                                A_1.enum0_0 = Enum0.const_2;
                                A_1.int_0 = Class546.class558_0.int_0;
                                A_1.bool_1 = Class961.bool_0;
                            }
                            return;

                        case Enum11.const_37:
                            return;

                        case Enum11.const_38:
                            if (Class961.smethod_1(A_0.int_0))
                            {
                                A_1.bool_0 = true;
                                A_1.enum0_0 = Enum0.const_1;
                                A_1.int_0 = Class546.class558_0.int_0;
                                A_1.bool_1 = Class961.bool_0;
                            }
                            return;
                    }
                    return;

                default:
                    return;
            }
        }
    }
}

