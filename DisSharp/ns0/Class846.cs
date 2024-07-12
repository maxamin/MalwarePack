namespace ns0
{
    using System;
    using System.Collections;

    internal class Class846
    {
        private static Class215 class215_0 = new Class215();
        private static Class238 class238_0 = new Class238();
        private static Class263 class263_0 = new Class263();
        private static Class288 class288_0 = new Class288();
        private static Class311 class311_0 = new Class311();
        private static Class334 class334_0 = new Class334();

        internal static Class368 smethod_0(Class369 A_0, Enum2 A_1, bool A_2)
        {
            smethod_11(Class50_0, A_0);
            return smethod_1(A_0, A_1, A_2);
        }

        internal static Class368 smethod_1(Class369 A_0, Enum2 A_1, bool A_2)
        {
            return Class50_0.Create(A_0, A_1, A_2);
        }

        internal static void smethod_10()
        {
            Class50_0.QRYU();
        }

        private static void smethod_11(Class50 A_0, Class369 A_1)
        {
            A_0.QRYT();
            smethod_12(A_0, A_1);
            A_0.QRYV();
        }

        private static void smethod_12(Class50 A_0, Class369 A_1)
        {
            Class619 class2 = A_1.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class369 class3 = class2[i];
                if (class3.QQQS == Enum10.const_16)
                {
                    A_0.QRYS((class3 as Class391).class528_0);
                }
                if (class3.QQQS == Enum10.const_23)
                {
                    A_0.QRYS((class3 as Class383).class528_0);
                }
                if (class3.QQQS == Enum10.const_17)
                {
                    A_0.QRYS((class3 as Class392).class528_0);
                }
                smethod_12(A_0, class3);
            }
        }

        internal static string smethod_13(string A_0)
        {
            return Class50_0.QRUX(A_0);
        }

        internal static Class397 smethod_2(Class397 A_0, Class369 A_1, Enum2 A_2)
        {
            if ((A_0 != null) && (A_0.arrayList_0 != null))
            {
                Class645.smethod_4(A_1, A_0);
            }
            return Class50_0.QRVW(A_0, A_1, A_2);
        }

        internal static void smethod_3(Class397 A_0, Class547.Class528 A_1)
        {
            Class50_0.QRZU(A_0, A_1);
        }

        internal static void smethod_4(Class397 A_0, Class398 A_1)
        {
            Class50_0.QRVX(A_0, A_1);
        }

        internal static void smethod_5(string A_0)
        {
            Class50_0.QRYW(A_0);
        }

        internal static void smethod_6(Class397 A_0)
        {
            Class50_0.QRYX(A_0);
        }

        internal static void smethod_7(string A_0, Class515 A_1)
        {
            Class50_0.QRZS(A_0, A_1);
        }

        internal static void smethod_8(Class547.Class528 A_0)
        {
            Class50_0.QRYR(A_0);
        }

        internal static ArrayList smethod_9(Class547.Class528 A_0)
        {
            Enum6 enum2 = Class516.enum6_0;
            Class516.enum6_0 = Enum6.flag_1;
            ArrayList list = class238_0.method_17(A_0);
            Class516.enum6_0 = enum2;
            return list;
        }

        internal static bool Boolean_0
        {
            get
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        return true;

                    case Enum6.flag_2:
                        return true;

                    case Enum6.flag_3:
                        return false;

                    case Enum6.flag_4:
                        return false;

                    case Enum6.flag_5:
                        return false;

                    case Enum6.flag_6:
                        return true;
                }
                throw new Exception1();
            }
        }

        internal static Class50 Class50_0
        {
            get
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        return class238_0;

                    case Enum6.flag_2:
                        return class215_0;

                    case Enum6.flag_3:
                        return class311_0;

                    case Enum6.flag_4:
                        return class263_0;

                    case Enum6.flag_5:
                        return class288_0;

                    case Enum6.flag_6:
                        return class334_0;
                }
                throw new Exception1();
            }
        }

        internal static string String_0
        {
            get
            {
                switch (Class516.enum6_0)
                {
                    case Enum6.flag_1:
                        return Class537.string_878;

                    case Enum6.flag_2:
                        return Class537.string_503;

                    case Enum6.flag_3:
                        return Class537.string_264;

                    case Enum6.flag_4:
                        return Class537.string_905;

                    case Enum6.flag_5:
                        return Class537.string_905;

                    case Enum6.flag_6:
                        return Class537.string_81;
                }
                throw new Exception1();
            }
        }

        internal static string String_1
        {
            get
            {
                if (Class516.enum6_0 == Enum6.flag_5)
                {
                    return Class537.string_823;
                }
                return String_0;
            }
        }
    }
}

