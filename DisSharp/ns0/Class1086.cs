namespace ns0
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Text;

    internal class Class1086
    {
        private static StringBuilder stringBuilder_0 = new StringBuilder(50);
        private static StringCollection stringCollection_0 = new StringCollection();

        internal static void smethod_0()
        {
            if (!Class645.Boolean_0)
            {
                Class397 class2 = new Class397();
                Class846.smethod_6(class2);
                class2.method_8();
                Class645.smethod_5(class2, Class519.class394_0.class395_0, Class537.string_924, Enum43.const_1);
            }
        }

        internal static void smethod_1()
        {
            if (!Class645.Boolean_0)
            {
                Class846.smethod_10();
            }
        }

        internal static void smethod_2()
        {
            if (!Class645.Boolean_0 && (Class519.class394_0.int_1 != 0))
            {
                Class547.Class528 class2 = Class546.class547_0.arrayList_0[Class519.class394_0.int_1] as Class547.Class528;
                if ((class2.class369_0 != null) && (class2.class369_0.class687_0 != null))
                {
                    Class698.class582_0.class686_0.class802_0.Focus();
                    Class698.class582_0.class686_0.class802_0.SelectedNode = class2.class369_0.class687_0;
                }
            }
        }

        internal static void smethod_3()
        {
            if (!Class645.Boolean_0)
            {
                Class705.class705_35.method_0();
                Class397 class2 = new Class397();
                Class1087.smethod_1(class2);
                class2.method_8();
                Class645.smethod_5(class2, Class519.class394_0.class395_2, Class537.string_436, Enum43.const_1);
            }
        }

        internal static void smethod_4()
        {
        }

        internal static void smethod_5()
        {
        }

        internal static void smethod_6()
        {
        }

        internal static void smethod_7()
        {
            if (!Class645.Boolean_0)
            {
                Class397 class2 = new Class397();
                stringCollection_0.Clear();
                stringCollection_0.Add(string.Empty);
                ArrayList list = Class546.class554_0.arrayList_0;
                for (int i = 1; i < list.Count; i++)
                {
                    Class554.Class532 class3 = list[i] as Class554.Class532;
                    stringCollection_0.Add(Class519.class581_0[class3.int_0]);
                }
                int length = 0;
                for (int j = 1; j < list.Count; j++)
                {
                    if (stringCollection_0[j].Length > length)
                    {
                        length = stringCollection_0[j].Length;
                    }
                }
                length++;
                for (int k = 1; k < list.Count; k++)
                {
                    Class554.Class532 class4 = list[k] as Class554.Class532;
                    stringBuilder_0.Length = 0;
                    stringBuilder_0.Append(stringCollection_0[k]);
                    for (int m = 0; m < (length - stringCollection_0[k].Length); m++)
                    {
                        stringBuilder_0.Append(' ');
                    }
                    stringBuilder_0.Append(class4.short_0);
                    stringBuilder_0.Append('.');
                    stringBuilder_0.Append(class4.short_1);
                    stringBuilder_0.Append('.');
                    stringBuilder_0.Append(class4.short_2);
                    stringBuilder_0.Append('.');
                    stringBuilder_0.Append(class4.short_3);
                    if (!class4.bool_0)
                    {
                        stringBuilder_0.Append(Class537.string_191);
                    }
                    class2.method_11(new Class336(stringBuilder_0.ToString()));
                }
                class2.method_8();
                Class645.smethod_5(class2, Class519.class394_0.class395_1, Class537.string_285, Enum43.const_1);
            }
        }

        internal static void smethod_8()
        {
            if (!Class645.Boolean_0)
            {
                Class1088.smethod_2();
            }
        }

        internal static void smethod_9()
        {
            if (!Class645.Boolean_0)
            {
                Class397 class2 = new Class397();
                ArrayList list = new ArrayList();
                ArrayList list2 = Class546.class579_0.arrayList_0;
                for (int i = 1; i < list2.Count; i++)
                {
                    Class579.Class535 class3 = list2[i] as Class579.Class535;
                    list.Add(new Class963(Class519.class581_0[class3.int_0], class3.byte_0.Length));
                }
                Class964.smethod_0(list);
                StringBuilder builder = new StringBuilder(150);
                for (int j = 0; j < list.Count; j++)
                {
                    Class963 class4 = list[j] as Class963;
                    builder.Length = 0;
                    builder.Append(class4.string_0);
                    builder.Append(" (");
                    builder.Append(class4.int_0);
                    builder.Append(')');
                    class2.method_11(new Class336(builder.ToString()));
                }
                class2.method_8();
                Class645.smethod_5(class2, Class519.class394_0.class395_3, Class537.string_268, Enum43.const_1);
            }
        }
    }
}

