namespace ns0
{
    using System;

    internal class Class631
    {
        internal static bool bool_0;
        private static bool bool_1;
        private static Class367 class367_0;
        private static int int_0;

        internal static void smethod_0(Class397 A_0, Class547.Class528 A_1)
        {
            if (A_1.Boolean_14)
            {
                bool_1 = false;
            }
            else
            {
                bool_1 = true;
                bool_0 = false;
                class367_0 = A_0.Class367_1;
                int_0 = class367_0.Int32_0;
            }
        }

        internal static void smethod_1()
        {
            if (bool_1 && (Class519.class528_0.Boolean_14 || bool_0))
            {
                class367_0.method_2(int_0, Class613.class339_133);
            }
        }
    }
}

