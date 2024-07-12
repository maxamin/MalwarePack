namespace ns0
{
    using System;
    using System.Collections;

    internal class Class667 : Class666
    {
        private Class619 class619_10 = new Class619();
        private Class619 class619_11 = new Class619();
        private Class619 class619_12 = new Class619();
        private Class619 class619_13 = new Class619();
        private Class619 class619_14 = new Class619();
        private Class619 class619_9 = new Class619();
        private static string string_44 = Class537.string_630;
        private static string string_45 = Class537.string_115;
        private static string string_46 = Class537.string_362;
        private static string string_47 = Class537.string_856;
        private static string string_48 = Class537.string_116;
        private static string string_49 = Class537.string_837;
        private static string string_50 = Class537.string_601;
        private static string string_51 = Class537.string_205;
        private static string string_52 = Class537.string_597;
        private static string string_53 = Class537.string_380;
        private static string string_54 = Class537.string_804;

        internal void method_56()
        {
            this.method_57();
            if (base.class394_0.bool_2)
            {
                this.method_58();
            }
        }

        private void method_57()
        {
            Class548.Class529 class2 = null;
            Class548.Class529 class3 = null;
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            ArrayList list2 = base.class684_0.class547_0.arrayList_0;
            int num = list.Count - 1;
            for (int i = 1; i < list.Count; i++)
            {
                int num4;
                if (i == 1)
                {
                    class2 = list[i] as Class548.Class529;
                }
                int num3 = class2.int_8;
                if (i < num)
                {
                    class3 = list[i + 1] as Class548.Class529;
                    num4 = class3.int_8 - num3;
                }
                else
                {
                    num4 = list2.Count - num3;
                }
                if (num4 > 0)
                {
                    Class369 class4 = class2.class369_0;
                    Class619 class5 = class4.class619_0;
                    for (int j = 0; j < num4; j++)
                    {
                        if (!base.bool_0[num3 + j])
                        {
                            Class547.Class528 class6 = list2[num3 + j] as Class547.Class528;
                            string str = base.class581_0[class6.int_1];
                            if ((class6.Boolean_6 && (class6.short_2 == 0)) && (str == string_46))
                            {
                                class6.uint_25 |= 0x200000;
                            }
                            if (Class904.smethod_1(str))
                            {
                                Class383 class7 = new Class383 {
                                    enum4_0 = Class904.enum4_0,
                                    class528_0 = class6,
                                    class369_0 = class4
                                };
                                class6.class369_0 = class7;
                                if (Class904.enum4_0 == Enum4.const_0)
                                {
                                    this.class619_12.method_0(class7);
                                }
                                else if (Class904.enum4_0 == Enum4.const_1)
                                {
                                    this.class619_13.method_0(class7);
                                }
                                else
                                {
                                    this.class619_11.method_0(class7);
                                }
                            }
                            else
                            {
                                Class391 class8;
                                if ((str != string_44) && (str != string_45))
                                {
                                    if (class6.Boolean_13)
                                    {
                                        class8 = new Class391();
                                        this.class619_14.method_0(class8);
                                    }
                                    else if (class6.Boolean_8)
                                    {
                                        class8 = new Class391();
                                        base.class619_2.method_0(class8);
                                    }
                                    else if (class6.Boolean_11)
                                    {
                                        class8 = new Class391();
                                        this.class619_10.method_0(class8);
                                    }
                                    else
                                    {
                                        class8 = new Class391();
                                        base.class619_3.method_0(class8);
                                    }
                                }
                                else
                                {
                                    class8 = new Class392();
                                    this.class619_9.method_0(class8);
                                }
                                class8.class528_0 = class6;
                                class8.class369_0 = class4;
                                class6.class369_0 = class8;
                            }
                        }
                    }
                    if (this.class619_11.Int32_0 > 0)
                    {
                        class5.method_1(this.class619_11);
                        this.class619_11.method_6();
                    }
                    if (this.class619_12.Int32_0 > 0)
                    {
                        class5.method_1(this.class619_12);
                        this.class619_12.method_6();
                    }
                    if (this.class619_13.Int32_0 > 0)
                    {
                        class5.method_1(this.class619_13);
                        this.class619_13.method_6();
                    }
                    if (this.class619_9.Int32_0 > 0)
                    {
                        class5.method_1(this.class619_9);
                        this.class619_9.method_6();
                    }
                    if (base.class619_3.Int32_0 > 0)
                    {
                        base.class619_3.method_7();
                        class5.method_1(base.class619_3);
                        base.class619_3.method_6();
                    }
                    if (this.class619_10.Int32_0 > 0)
                    {
                        this.class619_10.method_7();
                        class5.method_1(this.class619_10);
                        this.class619_10.method_6();
                    }
                    if (base.class619_2.Int32_0 > 0)
                    {
                        base.class619_2.method_7();
                        class5.method_1(base.class619_2);
                        base.class619_2.method_6();
                    }
                    if (this.class619_14.Int32_0 > 0)
                    {
                        this.class619_14.method_7();
                        class5.method_1(this.class619_14);
                        this.class619_14.method_6();
                    }
                }
                class2.short_5 = (short) num4;
                class2 = class3;
            }
        }

        private void method_58()
        {
            ArrayList list = base.class684_0.class548_0.arrayList_0;
            ArrayList list2 = base.class684_0.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                if (((i == base.class604_0.int_4) || (i == base.class604_0.int_11)) || ((i == base.class604_0.int_10) || (i == base.class604_0.int_13)))
                {
                    Class548.Class529 class2 = list[i] as Class548.Class529;
                    int num2 = class2.int_8;
                    for (int j = 0; j < class2.short_5; j++)
                    {
                        int num4 = num2 + j;
                        Class547.Class528 class3 = list2[num4] as Class547.Class528;
                        string str = base.class581_0[class3.int_1];
                        char ch = str[0];
                        switch (ch)
                        {
                            case 'C':
                            {
                                if ((i == base.class604_0.int_11) && (str == string_49))
                                {
                                    base.class604_0.uint_5 = Class689.smethod_1(6, num4);
                                }
                                continue;
                            }
                            case 'D':
                            case 'F':
                            case 'H':
                            {
                                continue;
                            }
                            case 'E':
                            {
                                if (i == base.class604_0.int_10)
                                {
                                    if (str != string_51)
                                    {
                                        break;
                                    }
                                    base.class604_0.uint_4 = Class689.smethod_1(6, num4);
                                }
                                continue;
                            }
                            case 'G':
                            {
                                if ((i == base.class604_0.int_4) && (str == string_54))
                                {
                                    base.class604_0.uint_8 = Class689.smethod_1(6, num4);
                                }
                                continue;
                            }
                            case 'I':
                            {
                                if ((i == base.class604_0.int_13) && (str == string_53))
                                {
                                    base.class604_0.uint_7 = Class689.smethod_1(6, num4);
                                }
                                continue;
                            }
                            case 'R':
                            {
                                if ((i == base.class604_0.int_11) && (str == string_50))
                                {
                                    base.class604_0.uint_6 = Class689.smethod_1(6, num4);
                                }
                                continue;
                            }
                            default:
                            {
                                if ((((ch == 'g') && (str.Length > 4)) && (str.StartsWith(string_47) && (i == base.class604_0.int_3))) && (str == string_48))
                                {
                                    base.class604_0.uint_9 = Class689.smethod_1(6, num4);
                                }
                                continue;
                            }
                        }
                        if (str == string_52)
                        {
                            base.class604_0.uint_3 = Class689.smethod_1(6, num4);
                        }
                    }
                }
            }
        }
    }
}

