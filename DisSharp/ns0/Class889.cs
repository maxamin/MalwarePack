namespace ns0
{
    using System;
    using System.Collections;
    using System.Collections.Specialized;
    using System.Windows.Forms;

    internal class Class889
    {
        private static string string_0;
        private static StringCollection stringCollection_0 = new StringCollection();

        internal static void smethod_0()
        {
            smethod_12(Enum53.const_0, "");
            smethod_16(Class537.string_316, Class537.string_631);
        }

        internal static void smethod_1()
        {
            smethod_11(Enum53.const_1, "");
            smethod_16("ComImport", Class537.string_756);
        }

        internal static void smethod_10()
        {
            AttributeForm form = new AttributeForm(Enum53.const_10);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string text = form.TextBox.Text;
                if (text != "")
                {
                    string str2 = Class890.smethod_4(text);
                    smethod_13(Enum53.const_10, str2);
                    smethod_16(text, smethod_15(text, Enum53.const_10));
                }
            }
        }

        private static void smethod_11(Enum53 A_0, string A_1)
        {
            stringCollection_0.Clear();
            bool flag = Class516.Boolean_0;
            Class516.Boolean_0 = true;
            try
            {
                ArrayList list = Class546.class548_0.arrayList_0;
                ArrayList list2 = Class546.class550_0.arrayList_0;
                for (int i = 1; i < list.Count; i++)
                {
                    Class548.Class529 class2 = list[i] as Class548.Class529;
                    int num2 = class2.short_3;
                    if (num2 > 0)
                    {
                        int num3 = class2.int_6;
                        for (int j = 0; j < num2; j++)
                        {
                            Class550.Class514 class3 = list2[num3 + j] as Class550.Class514;
                            if (((A_0 == Enum53.const_1) && (class3.enum7_0 == Enum7.const_3)) && (class3.enum8_0 == Enum8.const_0))
                            {
                                goto Label_00E2;
                            }
                            if (((A_0 == Enum53.const_2) && (class3.enum7_0 == Enum7.const_2)) && ((class3.enum8_0 == Enum8.const_0) && smethod_14(class3, A_0)))
                            {
                                goto Label_00F6;
                            }
                            if (((A_0 == Enum53.const_6) && (class3.enum7_0 == Enum7.const_8)) && (class3.enum8_0 == Enum8.const_0))
                            {
                                goto Label_010A;
                            }
                            if ((A_0 == Enum53.const_8) && Class890.smethod_3(class3).EndsWith(A_1))
                            {
                                goto Label_011E;
                            }
                        }
                    }
                    continue;
                Label_00E2:
                    stringCollection_0.Add(Class612.smethod_2(class2));
                    continue;
                Label_00F6:
                    stringCollection_0.Add(Class612.smethod_2(class2));
                    continue;
                Label_010A:
                    stringCollection_0.Add(Class612.smethod_2(class2));
                    continue;
                Label_011E:
                    stringCollection_0.Add(Class612.smethod_2(class2));
                }
            }
            catch
            {
            }
            finally
            {
                Class516.Boolean_0 = flag;
            }
            Class809.smethod_1(stringCollection_0, false);
        }

        private static void smethod_12(Enum53 A_0, string A_1)
        {
            stringCollection_0.Clear();
            bool flag = Class516.Boolean_0;
            Class516.Boolean_0 = true;
            try
            {
                ArrayList list = Class546.class547_0.arrayList_0;
                ArrayList list2 = Class546.class550_0.arrayList_0;
                for (int i = 1; i < list.Count; i++)
                {
                    string str;
                    Class547.Class528 class2 = list[i] as Class547.Class528;
                    int num2 = class2.short_1;
                    if (num2 > 0)
                    {
                        int num3 = class2.int_3;
                        for (int j = 0; j < num2; j++)
                        {
                            Class550.Class514 class3 = list2[num3 + j] as Class550.Class514;
                            if (((A_0 == Enum53.const_0) && (class3.enum7_0 == Enum7.const_2)) && ((class3.enum8_0 == Enum8.const_0) && smethod_14(class3, A_0)))
                            {
                                goto Label_00CB;
                            }
                            if (((A_0 == Enum53.const_4) && (class3.enum7_0 == Enum7.const_7)) && (class3.enum8_0 == Enum8.const_0))
                            {
                                goto Label_00FB;
                            }
                            if ((A_0 == Enum53.const_9) && Class890.smethod_3(class3).EndsWith(A_1))
                            {
                                goto Label_010F;
                            }
                        }
                    }
                    continue;
                Label_00CB:
                    str = Class612.smethod_16(class2) + "     (" + string_0 + ")";
                    stringCollection_0.Add(str);
                    continue;
                Label_00FB:
                    stringCollection_0.Add(Class612.smethod_16(class2));
                    continue;
                Label_010F:
                    stringCollection_0.Add(Class612.smethod_16(class2));
                }
            }
            catch
            {
            }
            finally
            {
                Class516.Boolean_0 = flag;
            }
            Class809.smethod_1(stringCollection_0, false);
        }

        private static void smethod_13(Enum53 A_0, string A_1)
        {
            stringCollection_0.Clear();
            bool flag = Class516.Boolean_0;
            Class516.Boolean_0 = true;
            try
            {
                ArrayList list = Class546.class549_0.arrayList_0;
                ArrayList list2 = Class546.class550_0.arrayList_0;
                for (int i = 1; i < list.Count; i++)
                {
                    Class549.Class530 class2 = list[i] as Class549.Class530;
                    int num2 = class2.short_0;
                    if (num2 > 0)
                    {
                        int num3 = class2.int_3;
                        for (int j = 0; j < num2; j++)
                        {
                            Class550.Class514 class3 = list2[num3 + j] as Class550.Class514;
                            if (((A_0 == Enum53.const_3) && (class3.enum7_0 == Enum7.const_2)) && ((class3.enum8_0 == Enum8.const_0) && smethod_14(class3, A_0)))
                            {
                                goto Label_00F4;
                            }
                            if (((A_0 == Enum53.const_5) && (class3.enum7_0 == Enum7.const_2)) && ((class3.enum8_0 == Enum8.const_0) && smethod_14(class3, A_0)))
                            {
                                goto Label_0108;
                            }
                            if (((A_0 == Enum53.const_7) && (class3.enum7_0 == Enum7.const_9)) && (class3.enum8_0 == Enum8.const_0))
                            {
                                goto Label_011C;
                            }
                            if ((A_0 == Enum53.const_10) && Class890.smethod_3(class3).EndsWith(A_1))
                            {
                                goto Label_0130;
                            }
                        }
                    }
                    continue;
                Label_00F4:
                    stringCollection_0.Add(Class612.smethod_10(class2));
                    continue;
                Label_0108:
                    stringCollection_0.Add(Class612.smethod_10(class2));
                    continue;
                Label_011C:
                    stringCollection_0.Add(Class612.smethod_10(class2));
                    continue;
                Label_0130:
                    stringCollection_0.Add(Class612.smethod_10(class2));
                }
            }
            catch
            {
            }
            finally
            {
                Class516.Boolean_0 = flag;
            }
            Class809.smethod_1(stringCollection_0, false);
        }

        private static bool smethod_14(Class550.Class514 A_0, Enum53 A_1)
        {
            Class570.Class625 class2 = Class546.class570_0.arrayList_0[A_0.int_0] as Class570.Class625;
            switch (A_1)
            {
                case Enum53.const_0:
                    if (class2.enum12_0 != Enum12.const_3)
                    {
                        break;
                    }
                    string_0 = Class519.class581_0[class2.int_0];
                    return true;

                case Enum53.const_2:
                    if (class2.enum12_0 != Enum12.const_0)
                    {
                        break;
                    }
                    return true;

                case Enum53.const_3:
                    if (class2.enum12_0 != Enum12.const_1)
                    {
                        break;
                    }
                    return true;

                case Enum53.const_5:
                    if (class2.enum12_0 == Enum12.const_2)
                    {
                        return true;
                    }
                    break;

                default:
                    return false;
            }
            return false;
        }

        private static string smethod_15(string A_0, Enum53 A_1)
        {
            string str = "";
            switch (A_1)
            {
                case Enum53.const_8:
                    str = Class537.string_84;
                    break;

                case Enum53.const_9:
                    str = Class537.string_548;
                    break;

                case Enum53.const_10:
                    str = Class537.string_173;
                    break;

                case Enum53.const_11:
                    str = Class537.string_241;
                    break;

                case Enum53.const_12:
                    str = Class537.string_620;
                    break;

                case Enum53.const_13:
                    str = Class537.string_547;
                    break;
            }
            return (str + A_0 + Class537.string_824);
        }

        private static void smethod_16(string A_0, string A_1)
        {
            Class397 class2 = new Class397();
            class2.method_11(new Class336(A_1));
            class2.method_8();
            for (int i = 0; i < stringCollection_0.Count; i++)
            {
                class2.method_11(new Class336(stringCollection_0[i]));
            }
            class2.method_8();
            Class645.smethod_5(class2, Class519.class394_0.class395_6, A_0, Enum43.const_1);
        }

        internal static void smethod_17()
        {
            AttributeForm form = new AttributeForm(Enum53.const_11);
            if (form.ShowDialog() == DialogResult.OK)
            {
                smethod_20(Enum53.const_11, form);
            }
        }

        internal static void smethod_18()
        {
            AttributeForm form = new AttributeForm(Enum53.const_12);
            if (form.ShowDialog() == DialogResult.OK)
            {
                smethod_20(Enum53.const_12, form);
            }
        }

        internal static void smethod_19()
        {
            AttributeForm form = new AttributeForm(Enum53.const_13);
            if (form.ShowDialog() == DialogResult.OK)
            {
                smethod_20(Enum53.const_13, form);
            }
        }

        internal static void smethod_2()
        {
            smethod_11(Enum53.const_2, "");
            smethod_16(Class537.string_820, Class537.string_419);
        }

        private static void smethod_20(Enum53 A_0, AttributeForm A_1)
        {
            stringCollection_0.Clear();
            bool flag = Class516.Boolean_0;
            Class516.Boolean_0 = true;
            try
            {
                string text = A_1.TextBox.Text;
                if (text != "")
                {
                    string str2 = Class890.smethod_4(text);
                    smethod_21(A_0, Class519.class394_0, str2);
                    Class809.smethod_1(stringCollection_0, false);
                    smethod_16(text, smethod_15(text, A_0));
                }
            }
            catch
            {
            }
            finally
            {
                Class516.Boolean_0 = flag;
            }
        }

        private static void smethod_21(Enum53 A_0, Class369 A_1, string A_2)
        {
            Class619 class2 = A_1.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                Class369 class3 = class2[i];
                switch (class3.QQQS)
                {
                    case Enum10.const_18:
                        if (A_0 == Enum53.const_11)
                        {
                            Class384 class4 = class3 as Class384;
                            if (smethod_22(class4.short_0, class4.int_2, A_2))
                            {
                                smethod_23(class3);
                            }
                        }
                        break;

                    case Enum10.const_19:
                        if (A_0 == Enum53.const_12)
                        {
                            Class382 class5 = class3 as Class382;
                            if (smethod_22(class5.short_0, class5.int_2, A_2))
                            {
                                smethod_23(class3);
                            }
                        }
                        break;

                    case Enum10.const_21:
                        if (A_0 == Enum53.const_13)
                        {
                            Class381 class6 = class3 as Class381;
                            if (smethod_22(class6.short_0, class6.int_2, A_2))
                            {
                                smethod_23(class3);
                            }
                        }
                        break;
                }
                smethod_21(A_0, class3, A_2);
            }
        }

        private static bool smethod_22(short A_0, int A_1, string A_2)
        {
            for (int i = 0; i < A_0; i++)
            {
                Class550.Class514 class2 = Class546.class550_0.arrayList_0[A_1 + i] as Class550.Class514;
                if (Class890.smethod_3(class2).EndsWith(A_2))
                {
                    return true;
                }
            }
            return false;
        }

        private static void smethod_23(Class369 A_0)
        {
            Class370 class2 = A_0.class369_0 as Class370;
            if (class2 != null)
            {
                stringCollection_0.Add(Class612.smethod_2(class2.class529_0) + Class537.string_857 + A_0.Name);
            }
        }

        internal static void smethod_3()
        {
            smethod_13(Enum53.const_3, "");
            smethod_16(Class537.string_311, Class537.string_252);
        }

        internal static void smethod_4()
        {
            smethod_12(Enum53.const_4, "");
            smethod_16(Class537.string_651, Class537.string_165);
        }

        internal static void smethod_5()
        {
            smethod_13(Enum53.const_5, "");
            smethod_16(Class537.string_390, Class537.string_253);
        }

        internal static void smethod_6()
        {
            smethod_11(Enum53.const_6, "");
            smethod_16(Class537.string_696, Class537.string_520);
        }

        internal static void smethod_7()
        {
            smethod_13(Enum53.const_7, "");
            smethod_16(Class537.string_737, Class537.string_210);
        }

        internal static void smethod_8()
        {
            AttributeForm form = new AttributeForm(Enum53.const_8);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string text = form.TextBox.Text;
                if (text != "")
                {
                    string str2 = Class890.smethod_4(text);
                    smethod_11(Enum53.const_8, str2);
                    smethod_16(text, smethod_15(text, Enum53.const_8));
                }
            }
        }

        internal static void smethod_9()
        {
            AttributeForm form = new AttributeForm(Enum53.const_9);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string text = form.TextBox.Text;
                if (text != "")
                {
                    string str2 = Class890.smethod_4(text);
                    smethod_12(Enum53.const_9, str2);
                    smethod_16(text, smethod_15(text, Enum53.const_9));
                }
            }
        }
    }
}

