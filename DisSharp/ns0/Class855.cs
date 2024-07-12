namespace ns0
{
    using System;
    using System.Collections;

    internal class Class855
    {
        private static Class418 class418_0;

        internal static void smethod_0(Class445 A_0)
        {
            Class858.smethod_8();
            class418_0 = new Class418(A_0);
            Class419 class2 = Class853.struct5_0[Class853.int_1 - 1].class419_0;
            if (Class858.smethod_7(class2.class398_0))
            {
                int num = class2.class398_0.ushort_1;
                Class417 class3 = Class973.arrayList_0[num - 1] as Class417;
                if (class3 == null)
                {
                    smethod_1(num);
                }
                else if (Class858.smethod_7(class3.class398_0))
                {
                    smethod_2(num, class3);
                }
                else
                {
                    smethod_3(num, class3);
                }
            }
            else
            {
                smethod_6();
            }
        }

        private static void smethod_1(int A_0)
        {
            ArrayList list = Class973.arrayList_0;
            for (int i = Class973.int_0 + Class853.int_1; i < A_0; i++)
            {
                class418_0.QQSR(list[i] as Class398);
            }
            Class689.smethod_5(Class853.struct5_0[0].class419_0, class418_0);
            Class689.smethod_2(list, Class973.int_0, A_0 - Class973.int_0);
            Class973.arrayList_0.Insert(Class973.int_0, class418_0);
        }

        private static int smethod_10(ArrayList A_0, int A_1)
        {
            int num = 1;
            for (int i = A_1 + 1; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (!smethod_12(class2.Type))
                {
                    return num;
                }
                num++;
            }
            return num;
        }

        private static bool smethod_11(Enum26 A_0)
        {
            switch (A_0)
            {
                case Enum26.const_8:
                case Enum26.const_9:
                case Enum26.const_10:
                case Enum26.const_14:
                case Enum26.const_17:
                case Enum26.const_33:
                case Enum26.const_35:
                case Enum26.const_42:
                case Enum26.const_43:
                    return true;
            }
            return false;
        }

        private static bool smethod_12(Enum26 A_0)
        {
            switch (A_0)
            {
                case Enum26.const_9:
                case Enum26.const_10:
                    return true;
            }
            return false;
        }

        private static void smethod_2(int A_0, Class417 A_1)
        {
            ArrayList list = Class973.arrayList_0;
            for (int i = Class973.int_0 + Class853.int_1; i < (A_0 - 1); i++)
            {
                class418_0.QQSR(list[i] as Class398);
            }
            A_1.class398_0.method_1(A_1);
            if (A_1.arrayList_0 != null)
            {
                class418_0.QQSR(A_1.method_7());
            }
            int num2 = A_1.class398_0.ushort_1;
            Class410 class2 = new Class410();
            for (int j = A_0; j < num2; j++)
            {
                class2.QQSR(list[j] as Class398);
            }
            Class689.smethod_5(Class853.struct5_0[0].class419_0, class418_0);
            Class689.smethod_2(list, Class973.int_0, num2 - Class973.int_0);
            Class973.arrayList_0.Insert(Class973.int_0, class2);
            Class973.arrayList_0.Insert(Class973.int_0, class418_0);
        }

        private static void smethod_3(int A_0, Class417 A_1)
        {
            if (smethod_9(A_1.class398_0))
            {
                smethod_4(A_0, A_1);
            }
            else
            {
                smethod_5(A_0);
            }
        }

        private static void smethod_4(int A_0, Class417 A_1)
        {
            ArrayList list = Class973.arrayList_0;
            int count = list.Count;
            for (int i = Class973.int_0 + Class853.int_1; i < (A_0 - 1); i++)
            {
                class418_0.QQSR(list[i] as Class398);
            }
            A_1.class398_0.method_1(A_1);
            if (A_1.arrayList_0 != null)
            {
                class418_0.QQSR(A_1.method_7());
            }
            Class410 class2 = new Class410();
            for (int j = A_0; j < count; j++)
            {
                class2.QQSR(list[j] as Class398);
            }
            Class689.smethod_5(Class853.struct5_0[0].class419_0, class418_0);
            Class689.smethod_2(list, Class973.int_0, count - Class973.int_0);
            Class973.arrayList_0.Insert(Class973.int_0, class2);
            Class973.arrayList_0.Insert(Class973.int_0, class418_0);
        }

        private static void smethod_5(int A_0)
        {
            ArrayList list = Class973.arrayList_0;
            for (int i = Class973.int_0 + Class853.int_1; i < A_0; i++)
            {
                class418_0.QQSR(list[i] as Class398);
            }
            Class689.smethod_5(Class853.struct5_0[0].class419_0, class418_0);
            Class689.smethod_2(list, Class973.int_0, A_0 - Class973.int_0);
            Class973.arrayList_0.Insert(Class973.int_0, class418_0);
        }

        private static void smethod_6()
        {
            if (smethod_9(Class853.struct5_0[Class853.int_1 - 1].class419_0.class398_0))
            {
                smethod_7();
            }
            else
            {
                smethod_8();
            }
        }

        private static void smethod_7()
        {
            ArrayList list = Class973.arrayList_0;
            int count = list.Count;
            int num2 = Class973.int_0 + Class853.int_1;
            if ((num2 == (count - 1)) && (list[num2] is Class436))
            {
                class418_0.QQSR(new Class417(Class853.struct5_0[Class853.int_1 - 1].class419_0.class398_0));
            }
            while (num2 < count)
            {
                class418_0.QQSR(list[num2] as Class398);
                num2++;
            }
            Class689.smethod_5(Class853.struct5_0[0].class419_0, class418_0);
            Class689.smethod_2(list, Class973.int_0, count - Class973.int_0);
            Class973.arrayList_0.Insert(Class973.int_0, class418_0);
        }

        private static void smethod_8()
        {
            Class419 class2 = Class853.struct5_0[Class853.int_1 - 1].class419_0;
            Class417 statement = new Class417(class2.class398_0);
            class418_0.QQSR(statement);
            class2.class398_0.method_0(statement);
            Class1023.smethod_0(class418_0.class445_0);
            Class689.smethod_5(Class853.struct5_0[0].class419_0, class418_0);
            Class689.smethod_2(Class973.arrayList_0, Class973.int_0, Class853.int_1);
            Class973.arrayList_0.Insert(Class973.int_0, class418_0);
        }

        private static bool smethod_9(Class398 A_0)
        {
            int num = Class929.int_0 - 1;
            if (num >= 0)
            {
                for (int i = num; i >= 0; i--)
                {
                    Struct8 struct2 = Class929.struct8_0[i];
                    if (!smethod_11(struct2.class398_0.Type))
                    {
                        return false;
                    }
                    ArrayList list = struct2.arrayList_0;
                    int num3 = struct2.int_0;
                    if (num3 < (list.Count - 1))
                    {
                        int num4 = smethod_10(list, num3);
                        if ((num3 + num4) < list.Count)
                        {
                            Class398 class2 = list[num3 + num4] as Class398;
                            if (class2 == A_0)
                            {
                                return true;
                            }
                            if (num4 != ((list.Count - 1) - num3))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}

