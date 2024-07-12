namespace ns0
{
    using System;
    using System.Collections;
    using System.Windows.Forms;

    internal class Class645
    {
        internal static Class704 class704_0 = new Class704();
        internal static Class841 class841_0 = new Class841();
        private static Class842 class842_0;

        internal static void smethod_0()
        {
            class704_0.method_0();
        }

        internal static void smethod_1(Class394 A_0)
        {
            class841_0.method_1(A_0);
        }

        internal static bool smethod_10()
        {
            return class841_0.method_3();
        }

        internal static bool smethod_11(Class394 A_0)
        {
            return class841_0.method_4(A_0);
        }

        internal static void smethod_2(Class394 A_0)
        {
            class841_0.method_2(A_0);
        }

        internal static void smethod_3(Class394 A_0)
        {
            class842_0 = class841_0.method_0(A_0);
        }

        internal static void smethod_4(Class369 A_0, Class397 A_1)
        {
            Class844 class2 = class842_0.method_0(A_0);
            Class646 class3 = new Class646(A_1.Int32_0, A_0, class2);
            A_1.arrayList_0.Add(class3);
            class2.method_0(class3);
        }

        internal static void smethod_5(Class397 A_0, Class369 A_1, string A_2, Enum43 A_3)
        {
            Class844 class2 = class842_0.method_0(A_1);
            Class845 class3 = class704_0.method_1(A_0, A_1, A_2, Enum54.const_2, A_3);
            Class646 class4 = new Class646(0, A_1, class2, class3);
            if (A_0.arrayList_0 != null)
            {
                A_0.arrayList_0.Add(class4);
            }
            class2.method_0(class4);
            class3.method_0(class4);
        }

        internal static void smethod_6(Class397 A_0, Class369 A_1, string A_2, Enum54 A_3, Enum43 A_4)
        {
            Class845 class2 = class704_0.method_1(A_0, A_1, A_2, A_3, A_4);
            if (Class516.bool_5 || Class516.bool_6)
            {
                class2.method_1();
            }
            if (A_0.arrayList_0 != null)
            {
                ArrayList list = A_0.arrayList_0;
                for (int i = 0; i < list.Count; i++)
                {
                    Class646 class3 = list[i] as Class646;
                    class3.class845_0 = class2;
                    class2.method_0(class3);
                }
            }
        }

        internal static void smethod_7(Class397 A_0, string A_1, Enum43 A_2)
        {
            class704_0.method_1(A_0, null, A_1, Enum54.const_2, A_2);
        }

        internal static void smethod_8(Control A_0, string A_1)
        {
            Class844 class2 = class842_0.method_0(Class519.class394_0);
            Class845 class3 = class704_0.method_2(A_0, Class519.class394_0, A_1, Enum54.const_4);
            Class646 class4 = new Class646(0, Class519.class394_0, class2, class3);
            class2.method_0(class4);
            class3.method_0(class4);
        }

        internal static void smethod_9()
        {
            if (!Boolean_0 && !class842_0.class843_0.method_3(Class519.class369_0, false))
            {
                Class925.smethod_0(Class705.class705_45);
                class842_0.class843_0.method_3(Class519.class369_0, true);
            }
        }

        internal static bool Boolean_0
        {
            get
            {
                return (Class698.class582_0.class686_0.class802_0.Nodes.Count == 0);
            }
        }
    }
}

