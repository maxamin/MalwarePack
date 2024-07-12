namespace ns0
{
    using System;
    using System.Collections;

    internal class Class904
    {
        internal static Enum4 enum4_0;
        private static Hashtable hashtable_0 = new Hashtable(0x36, 0.5f);
        private static string string_0 = Class537.string_657;

        static Class904()
        {
            smethod_0(Class537.string_350, Enum4.const_0);
            smethod_0(Class537.string_33, Enum4.const_1);
            smethod_0(Class537.string_886, Enum4.const_2);
            smethod_0(Class537.string_746, Enum4.const_3);
            smethod_0(Class537.string_559, Enum4.const_4);
            smethod_0(Class537.string_761, Enum4.const_5);
            smethod_0(Class537.string_501, Enum4.const_6);
            smethod_0(Class537.string_352, Enum4.const_7);
            smethod_0(Class537.string_661, Enum4.const_8);
            smethod_0(Class537.string_766, Enum4.const_9);
            smethod_0(Class537.string_368, Enum4.const_10);
            smethod_0(Class537.string_679, Enum4.const_11);
            smethod_0(Class537.string_295, Enum4.const_12);
            smethod_0(Class537.string_848, Enum4.const_13);
            smethod_0(Class537.string_460, Enum4.const_14);
            smethod_0(Class537.string_237, Enum4.const_15);
            smethod_0(Class537.string_934, Enum4.const_16);
            smethod_0(Class537.string_846, Enum4.const_17);
            smethod_0(Class537.string_97, Enum4.const_18);
            smethod_0(Class537.string_403, Enum4.const_19);
            smethod_0(Class537.string_463, Enum4.const_20);
            smethod_0(Class537.string_587, Enum4.const_21);
            smethod_0(Class537.string_281, Enum4.const_22);
            smethod_0(Class537.string_813, Enum4.const_23);
            smethod_0(Class537.string_649, Enum4.const_24);
            smethod_0(Class537.string_862, Enum4.const_25);
        }

        private static void smethod_0(string A_0, Enum4 A_1)
        {
            hashtable_0.Add(string_0 + A_0, A_1);
        }

        internal static bool smethod_1(string A_0)
        {
            object obj2 = hashtable_0[A_0];
            if (obj2 == null)
            {
                return false;
            }
            enum4_0 = (Enum4) obj2;
            return true;
        }
    }
}

