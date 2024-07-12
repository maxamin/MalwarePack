namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1048
    {
        private static ArrayList arrayList_0;

        internal static void smethod_0(Class522 A_0)
        {
            if (A_0.class867_0 != null)
            {
                arrayList_0 = A_0.arrayList_0;
                smethod_1(A_0.class867_0);
            }
        }

        private static void smethod_1(Class867 A_0)
        {
            if (A_0.arrayList_0 != null)
            {
                ArrayList list = A_0.arrayList_0;
                for (int i = 0; i < list.Count; i++)
                {
                    Class867 class2 = list[i] as Class867;
                    if (class2.enum68_0 == Enum68.const_2)
                    {
                        smethod_3(class2, class2);
                    }
                    smethod_1(class2);
                }
            }
        }

        private static void smethod_2(Class867 A_0)
        {
            if (A_0.bool_2)
            {
                Class822 class2 = arrayList_0[A_0.int_0] as Class822;
                if (class2.enum45_0 == Enum45.const_39)
                {
                    class2.enum45_0 = Enum45.const_1;
                }
            }
        }

        private static void smethod_3(Class867 A_0, Class867 A_1)
        {
            if (A_0.arrayList_0 == null)
            {
                smethod_4(A_0, A_1);
            }
            else
            {
                smethod_3(A_0.arrayList_0[0] as Class867, A_1);
            }
        }

        private static void smethod_4(Class867 A_0, Class867 A_1)
        {
            A_0.bool_1 = true;
            Class822 class2 = arrayList_0[A_0.int_0] as Class822;
            if ((class2.enum45_0 == Enum45.const_39) || (class2.enum45_0 == Enum45.const_1))
            {
                A_1.bool_0 = false;
            }
            else
            {
                if (class2.enum45_0 == Enum45.const_38)
                {
                    if (!smethod_5(A_0, class2, A_1))
                    {
                        throw new Exception13();
                    }
                    return;
                }
                A_1.bool_0 = true;
                switch (class2.enum45_0)
                {
                    case Enum45.const_12:
                        A_1.ushort_0 = 0;
                        break;

                    case Enum45.const_13:
                        A_1.ushort_0 = 1;
                        break;

                    case Enum45.const_14:
                        A_1.ushort_0 = 2;
                        break;

                    case Enum45.const_15:
                        A_1.ushort_0 = 3;
                        break;

                    case Enum45.const_21:
                    case Enum45.const_203:
                        A_1.ushort_0 = (class2 as Class835).ushort_0;
                        break;

                    default:
                        throw new Exception13();
                }
                Class525.smethod_2(A_1.ushort_0);
            }
            class2.enum45_0 = Enum45.const_1;
        }

        private static bool smethod_5(Class867 A_0, Class822 A_1, Class867 A_2)
        {
            int num;
            if (A_0.int_1 < (A_0.int_0 + 2))
            {
                return false;
            }
            Class822 class2 = arrayList_0[A_0.int_0 + 2] as Class822;
            switch (class2.enum45_0)
            {
                case Enum45.const_12:
                    num = 0;
                    break;

                case Enum45.const_13:
                    num = 1;
                    break;

                case Enum45.const_14:
                    num = 2;
                    break;

                case Enum45.const_15:
                    num = 3;
                    break;

                case Enum45.const_21:
                case Enum45.const_203:
                    num = (class2 as Class835).ushort_0;
                    break;

                default:
                    throw new Exception13();
            }
            A_2.bool_0 = true;
            A_2.ushort_0 = (ushort) num;
            Class525.smethod_2(num);
            A_0.bool_1 = false;
            arrayList_0[A_0.int_0] = new Class835(A_1.int_0, Enum45.const_201, (ushort) num);
            class2.enum45_0 = Enum45.const_1;
            return true;
        }
    }
}

