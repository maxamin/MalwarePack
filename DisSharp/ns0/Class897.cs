namespace ns0
{
    using System;
    using System.Collections;

    internal class Class897
    {
        private static Class238 class238_0 = new Class238();

        internal static void smethod_0(Class370 A_0, Class397 A_1, Class548.Class529 A_2)
        {
            class238_0.method_0(A_1);
            class238_0.method_9(new Class336(A_0.Name));
            if (A_2.short_0 > 0)
            {
                class238_0.method_911(A_2);
            }
        }

        internal static void smethod_1(Class381 A_0, Class397 A_1)
        {
            class238_0.method_0(A_1);
            class238_0.method_9(new Class336(Class519.class581_0[A_0.int_0]));
            class238_0.method_9(Class518.class337_18);
            class238_0.method_91(A_0.enum0_0, A_0.int_1);
        }

        internal static void smethod_2(Class369 A_0, Class397 A_1, Class549.Class530 A_2)
        {
            class238_0.method_0(A_1);
            class238_0.method_9(new Class336(Class519.class581_0[A_2.int_1]));
            if (!(A_0.class369_0 is Class373))
            {
                class238_0.method_9(Class518.class337_18);
                class238_0.method_92(A_2.enum11_0, A_2.int_2, A_2.byte_0);
            }
        }

        internal static void smethod_3(Class382 A_0, Class397 A_1)
        {
            class238_0.method_0(A_1);
            class238_0.method_9(Class613.class339_121);
            class238_0.method_9(Class518.class337_18);
            class238_0.method_92(A_0.enum11_0, A_0.int_1, A_0.byte_0);
            class238_0.method_9(Class584.class342_0);
            class238_0.method_9(Class518.class337_7);
            class238_0.method_9(Class584.class342_0);
            Struct3[] structArray = A_0.struct3_0;
            for (int i = 0; i < structArray.Length; i++)
            {
                class238_0.method_92(structArray[i].enum11_0, structArray[i].int_0, structArray[i].byte_0);
                if (i < (structArray.Length - 1))
                {
                    class238_0.method_9(Class518.class337_14);
                    class238_0.method_9(Class584.class342_0);
                }
            }
            class238_0.method_9(Class518.class337_8);
        }

        internal static void smethod_4(Class369 A_0, Class397 A_1, Class547.Class528 A_2)
        {
            Class519.class528_1 = A_2;
            class238_0.method_0(A_1);
            class238_0.method_9(new Class336((A_0 is Class392) ? A_0.class369_0.Name : Class519.class581_0[A_2.int_1]));
            if (A_2.short_0 > 0)
            {
                class238_0.method_913(A_2);
            }
            class238_0.method_9(Class518.class337_18);
            if (!(A_0 is Class392))
            {
                class238_0.method_92(A_2.enum11_0, A_2.int_5, A_2.byte_1);
            }
            class238_0.method_9(Class518.class337_11);
            ArrayList list = Class546.class568_0.arrayList_0;
            int num = A_2.short_2 - 1;
            int num2 = A_2.int_6;
            for (int i = 0; i < A_2.short_2; i++)
            {
                Class568.Class623 class2 = list[num2 + i] as Class568.Class623;
                class238_0.method_92(class2.enum11_0, class2.int_1, class2.byte_4);
                if (i < num)
                {
                    class238_0.method_9(Class518.class337_15);
                }
            }
            class238_0.method_9(Class518.class337_12);
        }

        internal static void smethod_5(Class383 A_0, Class397 A_1, Class547.Class528 A_2)
        {
            Class519.class528_1 = A_2;
            class238_0.method_0(A_1);
            Enum4 enum2 = A_0.enum4_0;
            if (enum2 <= Enum4.const_1)
            {
                class238_0.method_92(A_2.enum11_0, A_2.int_5, A_2.byte_1);
                class238_0.method_9(Class518.class337_11);
                Class568.Class623 class2 = Class546.class568_0.arrayList_0[A_2.int_6] as Class568.Class623;
                class238_0.method_92(class2.enum11_0, class2.int_1, class2.byte_4);
                class238_0.method_9(Class518.class337_12);
            }
            else
            {
                class238_0.method_9(class238_0.QRYQ(enum2));
            }
        }

        internal static void smethod_6(Class384 A_0, Class397 A_1)
        {
            class238_0.method_0(A_1);
            class238_0.method_9(new Class336(Class519.class581_0[A_0.int_0]));
            class238_0.method_9(Class518.class337_18);
            class238_0.method_92(A_0.enum11_0, A_0.int_1, A_0.byte_0);
        }
    }
}

