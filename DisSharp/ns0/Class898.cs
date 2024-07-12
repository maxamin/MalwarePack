namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;

    internal class Class898
    {
        private static Class238 class238_0 = new Class238();
        private static Class593 class593_0 = new Class594();
        private static Hashtable hashtable_0;
        private static StringBuilder stringBuilder_0 = new StringBuilder(250);

        static Class898()
        {
            class238_0.method_7();
            hashtable_0 = new Hashtable();
            hashtable_0[Class613.class339_6] = Class537.string_595;
            hashtable_0[Class613.class339_15] = Class537.string_82;
            hashtable_0[Class613.class339_103] = Class537.string_44;
            hashtable_0[Class613.class339_9] = Class537.string_79;
            hashtable_0[Class613.class339_108] = Class537.string_236;
            hashtable_0[Class613.class339_134] = Class537.string_527;
            hashtable_0[Class613.class339_61] = Class537.string_468;
            hashtable_0[Class613.class339_127] = Class537.string_955;
            hashtable_0[Class613.class339_71] = Class537.string_879;
            hashtable_0[Class613.class339_129] = Class537.string_872;
            hashtable_0[Class613.class339_45] = Class537.string_53;
            hashtable_0[Class613.class339_29] = Class537.string_572;
            hashtable_0[Class613.class339_115] = Class537.string_743;
            hashtable_0[Class613.class339_78] = Class537.string_744;
        }

        private static bool smethod_0()
        {
            return (Class521.Boolean_0 && !Class519.class394_0.bool_4);
        }

        internal static void smethod_1()
        {
            if (smethod_0())
            {
                MessageBox.Show(Class537.string_41, Class537.string_869, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Class699 class2 = new Class699(Enum40.const_2);
                if (class2.method_0(Enum41.const_1) == DialogResult.OK)
                {
                    try
                    {
                        smethod_3(class2.String_0);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, Class537.string_776, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        internal static void smethod_10(Class369 A_0, Class896 A_1)
        {
            Class370 class2 = A_0.class369_0 as Class370;
            if (class2 != null)
            {
                class593_0.method_0();
                class2.class529_0.method_1(class593_0, true);
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(Class537.string_160);
                stringBuilder_0.Append(class593_0.ToString());
                stringBuilder_0.Append(Class537.string_873);
                A_1.method_0(stringBuilder_0.ToString(), A_0);
            }
        }

        internal static void smethod_11(Class382 A_0, Class896 A_1)
        {
            Class370 class2 = A_0.class369_0 as Class370;
            if (class2 != null)
            {
                class593_0.method_0();
                class2.class529_0.method_1(class593_0, true);
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(Class537.string_186);
                stringBuilder_0.Append(class593_0.ToString());
                stringBuilder_0.Append(Class537.string_857);
                Class369 class3 = A_0.class619_0[0];
                stringBuilder_0.Append(class3.Name.Substring(4));
                Struct3[] structArray = A_0.struct3_0;
                if ((structArray != null) && (structArray.Length > 0))
                {
                    stringBuilder_0.Append(Class537.string_898);
                    smethod_13(structArray);
                    stringBuilder_0.Append(Class537.string_49);
                }
                A_1.method_0(stringBuilder_0.ToString(), A_0);
            }
        }

        private static void smethod_12(Class547.Class528 A_0)
        {
            int num = A_0.short_2;
            ArrayList list = Class546.class568_0.arrayList_0;
            int num2 = A_0.int_6;
            for (int i = 0; i < num; i++)
            {
                if (i > 0)
                {
                    stringBuilder_0.Append(Class537.string_98);
                }
                Class568.Class623 class2 = list[num2 + i] as Class568.Class623;
                smethod_14(class2.enum11_0, class2.int_1, class2.byte_4);
            }
        }

        private static void smethod_13(Struct3[] A_0)
        {
            int length = A_0.Length;
            for (int i = 0; i < length; i++)
            {
                if (i > 0)
                {
                    stringBuilder_0.Append(Class537.string_98);
                }
                Struct3 struct2 = A_0[i];
                smethod_14(struct2.enum11_0, struct2.int_0, struct2.byte_0);
            }
        }

        private static void smethod_14(Enum11 A_0, int A_1, byte A_2)
        {
            class238_0.Class367_0.method_5();
            class238_0.method_93(A_0, A_1, 0);
            Class367 class2 = class238_0.Class367_0;
            if (class2.Int32_0 > 0)
            {
                Class335 class3 = class2[0];
                object obj2 = hashtable_0[class3];
                if (obj2 != null)
                {
                    stringBuilder_0.Append((string) obj2);
                }
                else
                {
                    stringBuilder_0.Append(class3.ToString());
                }
                if (class2.Int32_0 > 1)
                {
                    int num = smethod_15(class2);
                    if (num == -1)
                    {
                        for (int j = 1; j < class2.Int32_0; j++)
                        {
                            stringBuilder_0.Append(class2[j].ToString());
                        }
                    }
                    else
                    {
                        int num3 = class2.Int32_0;
                        for (int k = 1; k < num3; k++)
                        {
                            if ((k > num) && (k < num3))
                            {
                                stringBuilder_0.Append(Class537.string_59);
                            }
                            stringBuilder_0.Append(class2[k].ToString());
                        }
                    }
                }
                for (int i = 0; i < A_2; i++)
                {
                    stringBuilder_0.Append(Class537.string_80);
                }
            }
        }

        private static int smethod_15(Class367 A_0)
        {
            for (int i = 1; i < A_0.Int32_0; i++)
            {
                if (A_0[i] == Class518.class337_7)
                {
                    return i;
                }
            }
            return -1;
        }

        internal static void smethod_2()
        {
            if (!smethod_0())
            {
                string path = Path.ChangeExtension(Class519.class394_0.string_2, Class537.string_446);
                if (File.Exists(path))
                {
                    try
                    {
                        smethod_3(path);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private static void smethod_3(string A_0)
        {
            bool flag = Class516.Boolean_0;
            Class516.Boolean_0 = true;
            Enum6 enum2 = Class516.enum6_0;
            Class516.enum6_0 = Enum6.flag_1;
            Class896 class2 = new Class896();
            Class519.class394_0.method_7(class2);
            Class516.Boolean_0 = flag;
            Class516.enum6_0 = enum2;
            XmlDocument document = new XmlDocument();
            document.Load(A_0);
            XmlNodeList elementsByTagName = document.GetElementsByTagName(Class537.string_445);
            if (elementsByTagName.Count == 1)
            {
                XmlNodeList childNodes = elementsByTagName[0].ChildNodes;
                ProgressForm form = new ProgressForm(Class537.string_457, true);
                form.method_0(0, childNodes.Count);
                form.Show();
                DateTime time = DateTime.Now.AddMilliseconds(200.0);
                for (int i = 0; i < childNodes.Count; i++)
                {
                    XmlNode node = childNodes[i];
                    string str = node.Attributes.GetNamedItem(Class537.string_673).Value;
                    string innerXml = node.InnerXml;
                    class2.method_1(str, innerXml);
                    if (time < DateTime.Now)
                    {
                        time = DateTime.Now.AddMilliseconds(200.0);
                        form.method_1(i);
                    }
                    Class582.smethod_0();
                    if (form.bool_0)
                    {
                        break;
                    }
                }
                form.Hide();
                form = null;
                Class582.smethod_0();
            }
        }

        internal static void smethod_4(Class369 A_0, Class548.Class529 A_1, Class896 A_2)
        {
            class593_0.method_0();
            A_1.method_1(class593_0, true);
            A_2.method_0(Class537.string_262 + class593_0.ToString(), A_0);
        }

        internal static void smethod_5(Class369 A_0, Class549.Class530 A_1, Class896 A_2)
        {
            class593_0.method_0();
            A_1.method_1(class593_0, true);
            A_2.method_0(Class537.string_60 + class593_0.ToString(), A_0);
        }

        internal static void smethod_6(Class369 A_0, Class896 A_1)
        {
            Class370 class2 = A_0.class369_0 as Class370;
            if (class2 != null)
            {
                class593_0.method_0();
                class2.class529_0.method_1(class593_0, true);
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(Class537.string_25);
                stringBuilder_0.Append(class593_0.ToString());
                stringBuilder_0.Append(Class537.string_857);
                stringBuilder_0.Append(A_0.Name);
                A_1.method_0(stringBuilder_0.ToString(), A_0);
            }
        }

        internal static void smethod_7(Class369 A_0, Class896 A_1)
        {
            Class370 class2 = A_0.class369_0 as Class370;
            if (class2 != null)
            {
                class593_0.method_0();
                class2.class529_0.method_1(class593_0, true);
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(Class537.string_186);
                stringBuilder_0.Append(class593_0.ToString());
                stringBuilder_0.Append(Class537.string_857);
                stringBuilder_0.Append(A_0.Name);
                A_1.method_0(stringBuilder_0.ToString(), A_0);
            }
        }

        internal static void smethod_8(Class369 A_0, Class547.Class528 A_1, Class896 A_2)
        {
            class593_0.method_0();
            A_1.method_6(class593_0, true);
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append(Class537.string_160);
            stringBuilder_0.Append(class593_0.ToString());
            if (A_1.short_2 > 0)
            {
                stringBuilder_0.Append(Class537.string_898);
                smethod_12(A_1);
                stringBuilder_0.Append(Class537.string_49);
            }
            A_2.method_0(stringBuilder_0.ToString(), A_0);
        }

        internal static void smethod_9(Class369 A_0, Class547.Class528 A_1, Class896 A_2)
        {
            Class370 class2 = A_0.class369_0 as Class370;
            if (class2 != null)
            {
                class593_0.method_0();
                class2.class529_0.method_1(class593_0, true);
                stringBuilder_0.Length = 0;
                stringBuilder_0.Append(Class537.string_160);
                stringBuilder_0.Append(class593_0.ToString());
                stringBuilder_0.Append(Class537.string_40);
                if (A_1.short_2 > 0)
                {
                    stringBuilder_0.Append(Class537.string_898);
                    smethod_12(A_1);
                    stringBuilder_0.Append(Class537.string_49);
                }
                A_2.method_0(stringBuilder_0.ToString(), A_0);
            }
        }
    }
}

