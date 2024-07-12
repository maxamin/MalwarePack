namespace ns0
{
    using System;

    internal class Class853
    {
        internal static Class398 class398_0;
        internal static int int_0;
        internal static int int_1;
        private static int int_2 = 50;
        internal static Struct5[] struct5_0 = new Struct5[50];

        internal static void smethod_0()
        {
            int_1 = 0;
        }

        internal static void smethod_1(Class419 A_0)
        {
            int_1++;
            if (int_1 >= int_2)
            {
                int_2 *= 2;
                Struct5[] structArray = struct5_0;
                struct5_0 = new Struct5[int_2];
                for (int i = 0; i < (int_1 - 1); i++)
                {
                    struct5_0[i] = structArray[i];
                }
            }
            int index = int_1 - 1;
            struct5_0[index].class419_0 = A_0;
            struct5_0[index].class398_0 = A_0.class398_0;
        }

        internal static void smethod_2(Class419 A_0, Enum47 A_1, int A_2)
        {
            smethod_1(A_0);
            int index = int_1 - 1;
            struct5_0[index].enum47_0 = A_1;
            struct5_0[index].int_0 = A_2;
        }

        internal static void smethod_3()
        {
            class398_0 = struct5_0[0].class419_0;
            int_0 = int_1;
        }
    }
}

