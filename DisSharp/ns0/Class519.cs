namespace ns0
{
    using System;

    internal class Class519
    {
        internal static Class367 class367_0;
        internal static Class369 class369_0;
        internal static Class394 class394_0;
        internal static Class547.Class528 class528_0;
        internal static Class547.Class528 class528_1;
        internal static Class548.Class529 class529_0;
        internal static Class548.Class529 class529_1;
        internal static Class581 class581_0;
        internal static Class604 class604_0;
        internal static Class803 class803_0;

        internal static void smethod_0(Class394 A_0)
        {
            if (A_0 != null)
            {
                class394_0 = A_0;
                class581_0 = A_0.class581_0;
                class604_0 = A_0.class604_0;
                class803_0 = A_0.class803_0;
                Class546.smethod_0(A_0.class684_0);
                Class645.smethod_3(A_0);
            }
        }

        internal static void smethod_1(Class369 A_0)
        {
            class369_0 = A_0;
            smethod_0(A_0.QQTW);
            Class804.smethod_1(A_0);
            Class705.smethod_1();
        }

        internal static void smethod_2(Class547.Class528 A_0)
        {
            class528_0 = A_0;
            class529_0 = Class520.smethod_1(A_0);
        }

        internal static void smethod_3(Class369 A_0)
        {
            Class369 class2 = A_0;
            while (!(class2 is Class370))
            {
                class2 = class2.class369_0;
            }
            class529_1 = (class2 as Class370).class529_0;
        }
    }
}

