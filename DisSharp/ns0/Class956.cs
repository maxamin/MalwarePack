namespace ns0
{
    using System;
    using System.Collections;

    internal class Class956
    {
        internal static void smethod_0()
        {
            ArrayList list = Class536.class901_0.arrayList_0;
            if (list != null)
            {
                smethod_1(list);
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class901 class2 = A_0[i] as Class901;
                if (class2.int_0 == -1)
                {
                    class2.int_0 = smethod_2(class2);
                    class2.int_1 = smethod_4(class2);
                }
                class2.int_2 = class2.int_0;
                class2.int_3 = class2.int_1;
                if (class2.arrayList_0 != null)
                {
                    smethod_1(class2.arrayList_0);
                }
            }
        }

        private static int smethod_2(Class901 A_0)
        {
            ArrayList list = A_0.arrayList_0;
            if (list == null)
            {
                return -1;
            }
            Class901 class2 = smethod_3(list);
            if (class2 == null)
            {
                return -1;
            }
            if (class2.int_0 == -1)
            {
                return smethod_2(class2);
            }
            return class2.int_0;
        }

        private static Class901 smethod_3(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class901 class2 = A_0[i] as Class901;
                if (!class2.bool_1)
                {
                    return class2;
                }
            }
            return null;
        }

        private static int smethod_4(Class901 A_0)
        {
            ArrayList list = A_0.arrayList_0;
            if (list == null)
            {
                return -1;
            }
            Class901 class2 = smethod_5(list);
            if (class2 == null)
            {
                return -1;
            }
            if (class2.int_1 == -1)
            {
                return smethod_4(class2);
            }
            return class2.int_1;
        }

        private static Class901 smethod_5(ArrayList A_0)
        {
            for (int i = A_0.Count - 1; i >= 0; i--)
            {
                Class901 class2 = A_0[i] as Class901;
                if (!class2.bool_1)
                {
                    return class2;
                }
            }
            return null;
        }
    }
}

