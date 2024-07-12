namespace ns0
{
    using System;

    internal class Class974
    {
        internal static int int_0;
        private static int int_1 = 20;
        internal static Struct17[] struct17_0 = new Struct17[20];

        internal static void smethod_0()
        {
            int_0 = 0;
        }

        internal static void smethod_1()
        {
            smethod_2(Class853.struct5_0[0].class419_0, Class853.int_1);
        }

        internal static void smethod_2(Class398 A_0, int A_1)
        {
            for (int i = 0; i < int_0; i++)
            {
                if ((struct17_0[i].class398_0 == A_0) && (struct17_0[i].int_0 == A_1))
                {
                    return;
                }
            }
            int_0++;
            if (int_0 >= int_1)
            {
                int_1 *= 2;
                Struct17[] structArray = struct17_0;
                struct17_0 = new Struct17[int_1];
                for (int j = 0; j < (int_0 - 1); j++)
                {
                    struct17_0[j] = structArray[j];
                }
            }
            int index = int_0 - 1;
            struct17_0[index].class398_0 = A_0;
            struct17_0[index].int_0 = A_1;
        }

        internal static bool smethod_3()
        {
            if (int_0 != 0)
            {
                Class398 class2 = Class853.struct5_0[0].class419_0;
                int num = Class853.int_1;
                for (int i = 0; i < int_0; i++)
                {
                    if ((struct17_0[i].class398_0 == class2) && (struct17_0[i].int_0 == num))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

