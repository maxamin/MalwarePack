namespace ns0
{
    using System;
    using System.Runtime.InteropServices;

    internal class Class902
    {
        private static bool bool_0;
        private static Class901[] class901_0 = new Class901[40];
        private static Class901 class901_1;
        private static int int_0 = 40;
        private static int int_1;
        internal static int int_2;
        private static Struct6[] struct6_0 = new Struct6[40];

        internal static Class901 smethod_0(int A_0)
        {
            return (class901_0[A_0].arrayList_0[struct6_0[A_0].int_0] as Class901);
        }

        internal static int smethod_1(int A_0)
        {
            return struct6_0[A_0].int_0;
        }

        private static void smethod_2(Class901 A_0)
        {
            int_2++;
            int_1++;
            if (int_2 >= int_0)
            {
                int_0 *= 2;
                Class901[] classArray = class901_0;
                Struct6[] structArray = struct6_0;
                class901_0 = new Class901[int_0];
                struct6_0 = new Struct6[int_0];
                for (int i = 0; i < (int_2 - 1); i++)
                {
                    class901_0[i] = classArray[i];
                    struct6_0[i] = structArray[i];
                }
            }
            class901_0[int_1] = A_0;
            struct6_0[int_1].int_1 = A_0.arrayList_0.Count - 1;
            struct6_0[int_1].int_0 = 0;
        }

        internal static void smethod_3(Class901 A_0)
        {
            class901_1 = A_0;
            bool_0 = true;
            int_2 = 0;
            int_1 = -1;
        }

        internal static Class901 smethod_4()
        {
            if (int_2 != 0)
            {
                return smethod_6();
            }
            if (!bool_0)
            {
                return null;
            }
            bool_0 = false;
            if (class901_1.arrayList_0 == null)
            {
                return class901_1;
            }
            smethod_2(class901_1);
            return smethod_5();
        }

        private static Class901 smethod_5()
        {
            Class901 class2 = class901_0[int_1].arrayList_0[struct6_0[int_1].int_0] as Class901;
            if (class2.arrayList_0 == null)
            {
                return class2;
            }
            smethod_2(class2);
            return smethod_5();
        }

        private static Class901 smethod_6()
        {
            if (int_2 <= 0)
            {
                return null;
            }
            int num = ++struct6_0[int_1].int_0;
            if (num > struct6_0[int_1].int_1)
            {
                int_2--;
                int_1--;
                return smethod_6();
            }
            return smethod_5();
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Struct6
        {
            internal int int_0;
            internal int int_1;
        }
    }
}

