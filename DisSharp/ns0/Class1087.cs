namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Text;

    internal class Class1087
    {
        private static string string_0 = Class537.string_749;
        private static string string_1 = Class537.string_565;
        private static string string_2 = Class537.string_139;
        private static string string_3 = Class537.string_187;

        internal static void smethod_0(string A_0)
        {
            using (Stream0 stream = new Stream0(A_0, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.Unicode))
                {
                    Class397 class2 = new Class397();
                    smethod_1(class2);
                    class2.method_13(writer);
                }
            }
        }

        internal static void smethod_1(Class397 A_0)
        {
            Class516.Boolean_0 = true;
            int num = 0;
            ArrayList list = Class546.class547_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class547.Class528 class2 = list[i] as Class547.Class528;
                if ((!class2.Boolean_2 && !class2.Boolean_13) || class2.Boolean_3)
                {
                    Class369 class3 = class2.class369_0.class369_0;
                    switch (class3.QQQS)
                    {
                        case Enum10.const_18:
                        case Enum10.const_19:
                        case Enum10.const_20:
                        case Enum10.const_21:
                            class3 = class3.class369_0;
                            break;
                    }
                    Class370 class4 = class3 as Class370;
                    if (class4 != null)
                    {
                        string str = Class612.smethod_2(class4.class529_0) + "." + Class519.class581_0[class2.int_1];
                        if (class2.Boolean_1)
                        {
                            string str2;
                            switch (class2.enum5_0)
                            {
                                case Enum5.const_6:
                                    str2 = "ASM ";
                                    break;

                                case Enum5.const_7:
                                    str2 = "DEC ";
                                    break;

                                case Enum5.const_0:
                                {
                                    continue;
                                }
                                default:
                                    str2 = "   ";
                                    break;
                            }
                            A_0.method_11(new Class336(str2 + str));
                            num++;
                            continue;
                        }
                        if (!class2.Boolean_2)
                        {
                            A_0.method_11(new Class336("PAR " + str));
                            num++;
                        }
                    }
                }
            }
            if (num > 0)
            {
                A_0.method_8();
            }
            int num3 = list.Count - 1;
            A_0.method_11(new Class336(num.ToString() + string_2 + num3.ToString() + string_3));
            Class516.smethod_0();
        }
    }
}

