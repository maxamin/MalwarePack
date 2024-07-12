namespace ns0
{
    using System;

    internal class Class854
    {
        internal static Class398 class398_0;
        internal static int int_0;
        private static int int_1 = 10;
        internal static Struct18[] struct18_0 = new Struct18[10];

        internal static void smethod_0()
        {
            int_0 = 0;
        }

        internal static void smethod_1(Class398 A_0)
        {
            for (int i = 0; i < int_0; i++)
            {
                if (struct18_0[i].class398_0 == A_0)
                {
                    return;
                }
            }
            int_0++;
            if (int_0 >= int_1)
            {
                int_1 *= 2;
                Struct18[] structArray = struct18_0;
                struct18_0 = new Struct18[int_1];
                for (int j = 0; j < (int_0 - 1); j++)
                {
                    struct18_0[j] = structArray[j];
                }
            }
            int index = int_0 - 1;
            struct18_0[index].class398_0 = A_0;
            struct18_0[index].int_0 = A_0.ushort_1;
        }

        private static int smethod_2(int A_0, int A_1)
        {
            Class398 class2 = struct18_0[A_0].class398_0;
            Class398 class3 = struct18_0[A_1].class398_0;
            if (class2 != class3)
            {
                if (Class858.smethod_7(class2))
                {
                    if (Class858.smethod_7(class3) && (struct18_0[A_0].int_0 < struct18_0[A_1].int_0))
                    {
                        return -1;
                    }
                    return 1;
                }
                if (Class858.smethod_7(class3))
                {
                    return -1;
                }
            }
            return 0;
        }

        private static void smethod_3(int A_0, int A_1)
        {
    while (true)
    {
        int num;
        int num2;
        int num3;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            num3 = (A_0 + A_1) >> 1;
            break;
        }
        while (true)
        {
            if (smethod_2(num, num3) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (smethod_2(num2, num3) > 0)
                {
                    num2--;
                    continue;
                }
                if (num <= num2)
                {
                    struct18_0[num] = struct18_0[num2];
                    struct18_0[num2] = struct18_0[num];
                    num++;
                    num2--;
                }
                if (num > num2)
                {
                    if (A_0 < num2)
                    {
                        smethod_3(A_0, num2);
                    }
                    A_0 = num;
                    if (num >= A_1)
                    {
                        return;
                    }
                }
                else
                {
                    continue;
                }
                break;
            }
            break;
        }
    }

        }

        internal static void smethod_4()
        {
            if (int_0 > 1)
            {
                smethod_3(0, int_0 - 1);
            }
        }

        internal static void smethod_5()
        {
            smethod_0();
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class398 class2 = Class853.struct5_0[i].class398_0;
                bool flag = true;
                int index = i + 1;
                while (index < Class853.int_1)
                {
                    if (class2 == Class853.struct5_0[index].class419_0)
                    {
                        goto Label_0045;
                    }
                    index++;
                }
                goto Label_0069;
            Label_0045:
                Class853.struct5_0[i].int_0 = index;
                Class853.struct5_0[i].enum47_0 = Enum47.const_0;
                flag = false;
            Label_0069:
                if (flag)
                {
                    smethod_1(class2);
                    Class853.struct5_0[i].enum47_0 = Enum47.const_3;
                }
            }
            Class853.struct5_0[Class853.int_1 - 1].enum47_0 = Enum47.const_2;
            smethod_1(Class973.class398_0);
            class398_0 = struct18_0[0].class398_0;
            smethod_4();
        }

        internal static void smethod_6()
        {
            Class398 class2 = struct18_0[0].class398_0;
            for (int i = 0; i < (Class853.int_1 - 1); i++)
            {
                if (Class853.struct5_0[i].enum47_0 == Enum47.const_3)
                {
                    if (Class853.struct5_0[i].class398_0 == class2)
                    {
                        Class853.struct5_0[i].enum47_0 = Enum47.const_1;
                    }
                    else
                    {
                        Class853.struct5_0[i].enum47_0 = Enum47.const_2;
                    }
                }
            }
        }

        internal static void smethod_7()
        {
            smethod_0();
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class398 class2 = Class853.struct5_0[i].class398_0;
                bool flag = true;
                int index = i + 1;
                while (index < Class853.int_1)
                {
                    if (class2 == Class853.struct5_0[index].class419_0)
                    {
                        goto Label_0045;
                    }
                    index++;
                }
                goto Label_0069;
            Label_0045:
                Class853.struct5_0[i].int_0 = index;
                Class853.struct5_0[i].enum47_0 = Enum47.const_0;
                flag = false;
            Label_0069:
                if (flag)
                {
                    smethod_1(class2);
                    Class853.struct5_0[i].enum47_0 = Enum47.const_3;
                }
            }
            smethod_1(Class973.class398_0);
            smethod_4();
            Class398 class3 = struct18_0[0].class398_0;
            for (int j = 0; j < (Class853.int_1 - 1); j++)
            {
                if (Class853.struct5_0[j].enum47_0 == Enum47.const_3)
                {
                    if (Class853.struct5_0[j].class398_0 == class3)
                    {
                        Class853.struct5_0[j].enum47_0 = Enum47.const_1;
                    }
                    else
                    {
                        Class853.struct5_0[j].enum47_0 = Enum47.const_2;
                    }
                }
            }
            Class853.struct5_0[Class853.int_1 - 1].enum47_0 = Enum47.const_2;
        }
    }
}

