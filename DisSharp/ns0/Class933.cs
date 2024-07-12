namespace ns0
{
    using System;
    using System.Collections;

    internal class Class933
    {
        internal static void smethod_0()
        {
            ArrayList list = Class536.class901_0.arrayList_0;
            if (list != null)
            {
                Class536.arrayList_0 = new ArrayList();
                for (int i = 0; i < list.Count; i++)
                {
                    Class901 class2 = list[i] as Class901;
                    Class398 class3 = smethod_1(class2);
                    class2.class398_0 = class3;
                    Class536.arrayList_0.Add(class3);
                }
            }
        }

        private static Class398 smethod_1(Class901 A_0)
        {
            Class398 class2;
            switch (A_0.enum58_0)
            {
                case Enum58.const_0:
                    class2 = new Class405();
                    break;

                case Enum58.const_1:
                    class2 = new Class438();
                    break;

                case Enum58.const_2:
                {
                    Class404 class3 = new Class404 {
                        uint_0 = Class840.smethod_0(A_0.uint_0),
                        bool_1 = A_0.bool_0,
                        ushort_2 = A_0.ushort_0
                    };
                    class2 = class3;
                    break;
                }
                case Enum58.const_3:
                    class2 = new Class412();
                    break;

                case Enum58.const_4:
                {
                    Class441 class4 = new Class441();
                    smethod_2(A_0);
                    class4.class445_0 = smethod_6(A_0, A_0.ushort_1);
                    class2 = class4;
                    break;
                }
                case Enum58.const_5:
                case Enum58.const_6:
                case Enum58.const_8:
                case Enum58.const_9:
                case Enum58.const_11:
                case Enum58.const_13:
                case Enum58.const_14:
                case Enum58.const_16:
                    class2 = new Class405();
                    break;

                case Enum58.const_7:
                {
                    Class415 class5 = new Class415 {
                        class445_0 = smethod_4(A_0)
                    };
                    smethod_2(A_0);
                    class5.class445_1 = smethod_6(A_0, A_0.ushort_1);
                    class5.class445_2 = smethod_5(A_0, A_0.ushort_1);
                    class2 = class5;
                    break;
                }
                case Enum58.const_10:
                {
                    Class409 class6 = new Class409 {
                        class445_0 = smethod_6(A_0, A_0.ushort_1)
                    };
                    class2 = class6;
                    break;
                }
                case Enum58.const_12:
                    class2 = new Class442();
                    smethod_2(A_0);
                    smethod_3(A_0);
                    break;

                case Enum58.const_15:
                    class2 = new Class442();
                    smethod_3(A_0);
                    break;

                default:
                    throw new Exception9();
            }
            ArrayList list = A_0.arrayList_0;
            if (list == null)
            {
                if (!A_0.bool_1)
                {
                    for (int j = A_0.int_0; j <= A_0.int_1; j++)
                    {
                        if (j >= 0)
                        {
                            class2.QQSR(Class536.class398_0[j]);
                        }
                    }
                }
                return class2;
            }
            for (int i = 0; i < list.Count; i++)
            {
                Class901 class7 = list[i] as Class901;
                Class398 statement = smethod_1(class7);
                class7.class398_0 = statement;
                class2.QQSR(statement);
            }
            return class2;
        }

        private static void smethod_2(Class901 A_0)
        {
            if (A_0.arrayList_0 == null)
            {
                Class536.class398_0[A_0.int_0].bool_0 = true;
                A_0.int_0++;
            }
            else
            {
                smethod_2(A_0.arrayList_0[0] as Class901);
            }
        }

        private static void smethod_3(Class901 A_0)
        {
            if (A_0.arrayList_0 != null)
            {
                smethod_3(A_0.arrayList_0[A_0.arrayList_0.Count - 1] as Class901);
            }
            else
            {
                Class536.class398_0[A_0.int_1] = (Class536.class398_0[A_0.int_1] as Class417).method_7();
            }
        }

        private static Class445 smethod_4(Class901 A_0)
        {
            if (A_0.arrayList_0 != null)
            {
                return smethod_4(A_0.arrayList_0[0] as Class901);
            }
            Class445 class3 = (Class536.class398_0[A_0.int_0] as Class399).method_8();
            Class536.class398_0[A_0.int_0].bool_0 = true;
            A_0.int_0++;
            return class3;
        }

        private static Class445 smethod_5(Class901 A_0, int A_1)
        {
            if (A_0.arrayList_0 != null)
            {
                return smethod_5(A_0.arrayList_0[A_0.arrayList_0.Count - 1] as Class901, A_1);
            }
            Class399 class2 = Class536.class398_0[A_0.int_1 - 1] as Class399;
            Class445 class3 = class2.method_8();
            Class536.class398_0[A_0.int_1 - 1] = class2.method_7();
            return class3;
        }

        private static Class445 smethod_6(Class901 A_0, int A_1)
        {
            if (A_0.arrayList_0 != null)
            {
                return smethod_6(A_0.arrayList_0[A_0.arrayList_0.Count - 1] as Class901, A_1);
            }
            for (int i = 0; i < (A_1 - 1); i++)
            {
                Class398 class2 = Class536.class398_0[A_0.int_1 - i];
                class2.QQRX.method_1(class2);
                class2.bool_0 = true;
            }
            Class536.class398_0[(A_0.int_1 - A_1) + 1] = (Class536.class398_0[(A_0.int_1 - A_1) + 1] as Class419).method_7();
            A_0.int_1 -= A_1 - 1;
            return null;
        }
    }
}

