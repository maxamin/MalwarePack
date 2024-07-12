namespace ns0
{
    using System;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    internal class Class1067
    {
        private static Class515 class515_0;

        internal static void smethod_0()
        {
            if (!Class645.Boolean_0)
            {
                Class703 class2 = new Class703(Enum42.const_2);
                if (class2.method_0(Enum41.const_0) == DialogResult.OK)
                {
                    string str = class2.String_1;
                    if (Class1014.smethod_1(class2.String_2, str))
                    {
                        MessageBox.Show(Class537.string_774 + str + Class537.string_447, Class537.string_707, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        Class582.smethod_0();
                        Class705.class705_35.method_0();
                        Class582.smethod_0();
                        bool flag = Class516.Boolean_0;
                        try
                        {
                            Class1066.smethod_0();
                            string str2 = Class1014.smethod_2(class2.String_2, str);
                            if (Class516.bool_14)
                            {
                                class515_0 = new Class515();
                                Class516.Boolean_0 = true;
                                string str3 = Class1014.smethod_2(str2, Class537.string_206);
                                smethod_3(str3);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_0, str3);
                                Class1066.smethod_1(class515_0, str3);
                                Class519.class394_0.class1068_0.method_1(class515_0, str3);
                                Class846.smethod_7(str3, class515_0);
                                class515_0 = null;
                                Class582.smethod_0();
                            }
                            if (Class516.bool_15)
                            {
                                class515_0 = new Class515();
                                Class516.Boolean_0 = false;
                                string str4 = Class1014.smethod_2(str2, Class537.string_238);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_0, str4);
                                smethod_3(str4);
                                Class1066.smethod_1(class515_0, str4);
                                Class519.class394_0.class1068_0.method_1(class515_0, str4);
                                Class846.smethod_7(str4, class515_0);
                                class515_0 = null;
                                Class582.smethod_0();
                            }
                            if (Class516.bool_16)
                            {
                                Class516.Boolean_0 = false;
                                string str5 = Class1014.smethod_2(str2, Class537.string_201);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_1, str5);
                                smethod_3(str5);
                                Class582.smethod_0();
                            }
                            if (Class516.bool_17)
                            {
                                Class516.Boolean_0 = false;
                                string str6 = Class1014.smethod_2(str2, Class537.string_265);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_2, str6);
                                smethod_3(str6);
                                Class582.smethod_0();
                            }
                            if (Class516.bool_18)
                            {
                                Class516.Boolean_0 = false;
                                string str7 = Class1014.smethod_2(str2, Class537.string_275);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_3, str7);
                                smethod_3(str7);
                                Class582.smethod_0();
                            }
                            if (Class516.bool_19)
                            {
                                Class516.Boolean_0 = false;
                                string str8 = Class1014.smethod_2(str2, Class537.string_765);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_4, str8);
                                smethod_3(str8);
                                Class582.smethod_0();
                            }
                            if (Class516.bool_20)
                            {
                                Class516.Boolean_0 = false;
                                string str9 = Class1014.smethod_2(str2, Class537.string_73);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_5, str9);
                                smethod_3(str9);
                                Class582.smethod_0();
                            }
                            if (Class516.bool_21)
                            {
                                Class516.Boolean_0 = false;
                                string str10 = Class1014.smethod_2(str2, Class537.string_298);
                                smethod_1(Class519.class394_0.class619_0, Enum2.const_6, str10);
                                Class582.smethod_0();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, Class537.string_707, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        finally
                        {
                            Class516.Boolean_0 = flag;
                        }
                    }
                }
            }
        }

        private static void smethod_1(Class619 A_0, Enum2 A_1, string A_2)
        {
            for (int i = 0; i < A_0.Int32_0; i++)
            {
                Class369 class2 = A_0[i];
                switch (class2.QQTT)
                {
                    case Enum57.const_2:
                        smethod_1(class2.class619_0, A_1, Class1014.smethod_2(A_2, class2.Name));
                        break;

                    case Enum57.const_3:
                        smethod_2(class2, A_1, A_2);
                        break;
                }
            }
        }

        private static void smethod_2(Class369 A_0, Enum2 A_1, string A_2)
        {
            string str = null;
            try
            {
                str = A_2 + A_0.Name + Class537.string_857 + Class846.String_0;
                if (class515_0 != null)
                {
                    str = class515_0.method_0(str, Enum64.const_0);
                }
                using (Stream0 stream = new Stream0(str, FileMode.Create, FileAccess.Write, FileShare.None, 0x8fff))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.Default))
                    {
                        Class846.smethod_1(A_0, A_1, false).class397_0.method_13(writer);
                    }
                }
            }
            catch
            {
            }
        }

        private static void smethod_3(string A_0)
        {
            string str = A_0 + Class537.string_924 + Class537.string_857 + Class846.String_0;
            if (class515_0 != null)
            {
                class515_0.method_0(str, Enum64.const_3);
            }
            Class846.smethod_5(str);
        }
    }
}

