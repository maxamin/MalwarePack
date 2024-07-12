namespace ns0
{
    using System;
    using System.Collections;

    internal class Class929
    {
        internal static int int_0 = 0;
        private static int int_1 = 20;
        internal static Struct8[] struct8_0 = new Struct8[20];

        internal static void smethod_0()
        {
            int_0 = 0;
        }

        internal static void smethod_1(ArrayList A_0, Class398 A_1, int A_2)
        {
            int_0++;
            if (int_0 >= int_1)
            {
                int_1 *= 2;
                Struct8[] structArray = struct8_0;
                struct8_0 = new Struct8[int_1];
                for (int i = 0; i < (int_0 - 1); i++)
                {
                    struct8_0[i] = structArray[i];
                }
            }
            int index = int_0 - 1;
            struct8_0[index].arrayList_0 = A_0;
            struct8_0[index].class398_0 = A_1;
            struct8_0[index].int_0 = A_2;
        }

        internal static void smethod_2()
        {
            int_0--;
        }
    }
}

