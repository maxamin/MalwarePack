namespace ns0
{
    using System;

    internal class Class935
    {
        internal static void smethod_0()
        {
            switch (Class516.enum6_0)
            {
                case Enum6.flag_1:
                    smethod_4();
                    return;

                case (Enum6.flag_1 | Enum6.flag_0):
                case Enum6.flag_2:
                    return;

                case Enum6.flag_3:
                    smethod_5();
                    return;

                case Enum6.flag_4:
                    smethod_6();
                    break;

                case Enum6.flag_5:
                    smethod_1();
                    break;
            }
        }

        internal static void smethod_1()
        {
            Class516.enum6_0 = Enum6.flag_1;
            smethod_7();
        }

        internal static void smethod_2()
        {
            Class516.enum6_0 = Enum6.flag_6;
            smethod_7();
        }

        internal static void smethod_3()
        {
            Class516.enum6_0 = Enum6.flag_2;
            smethod_7();
        }

        internal static void smethod_4()
        {
            Class516.enum6_0 = Enum6.flag_3;
            smethod_7();
        }

        internal static void smethod_5()
        {
            Class516.enum6_0 = Enum6.flag_4;
            smethod_7();
        }

        internal static void smethod_6()
        {
            Class516.enum6_0 = Enum6.flag_5;
            smethod_7();
        }

        internal static void smethod_7()
        {
            string str;
            int num;
            Enum6 enum2 = Class516.enum6_0;
            if (enum2 <= Enum6.flag_3)
            {
                if (enum2 != Enum6.flag_1)
                {
                    if (enum2 != Enum6.flag_3)
                    {
                        goto Label_003A;
                    }
                    str = Class537.string_899;
                    num = Class868.int_76;
                }
                else
                {
                    str = Class537.string_538;
                    num = Class868.int_74;
                }
                goto Label_005E;
            }
            switch (enum2)
            {
                case Enum6.flag_4:
                    str = Class537.string_474;
                    num = Class868.int_75;
                    goto Label_005E;

                case Enum6.flag_5:
                    str = Class537.string_437;
                    num = Class868.int_73;
                    goto Label_005E;
            }
        Label_003A:
            str = "";
            num = 0;
        Label_005E:
            Class698.class582_0.class936_0.toolStripMenuItem_3.Text = str;
            Class698.class582_0.class936_0.toolStripMenuItem_4.Text = str;
            Class698.class582_0.class937_0.toolStripSplitButton_2.ImageIndex = num;
        }
    }
}

