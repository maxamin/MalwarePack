namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Windows.Forms;

    internal class Class1093
    {
        private static ArrayList arrayList_0 = new ArrayList();
        internal static bool bool_0;
        internal static bool bool_1;
        private static Hashtable hashtable_0 = new Hashtable();
        private static int int_0;
        private static int int_1;
        private static int int_2;
        private static int int_3;
        private static int int_4;
        private static int int_5;
        private static int int_6;
        private static int int_7;
        private static int int_8;
        private static int int_9;
        private static string string_0 = Class537.string_692;
        private static string string_1 = Class537.string_508;
        private static string string_10 = Class537.string_844;
        private static string string_11 = Class617.String_6;
        private static string string_12 = Class537.string_195;
        private static string string_13 = Class537.string_69;
        private static string string_2 = Class537.string_144;
        private static string string_3 = Class537.string_152;
        private static string string_4 = Class537.string_161;
        private static string string_5 = Class537.string_839;
        private static string string_6 = Class537.string_435;
        private static string string_7 = Class537.string_526;
        private static string string_8 = Class537.string_805;
        private static string string_9 = Class537.string_856;

        internal static void smethod_0()
        {
            if (!Class645.Boolean_0)
            {
                bool_0 = Class521.Boolean_0;
                bool_1 = true;
                Class394 class2 = Class519.class394_0;
                ArrayList list = Class546.class547_0.arrayList_0;
                for (int i = 1; i < list.Count; i++)
                {
                    Class547.Class528 class3 = list[i] as Class547.Class528;
                    class3.method_0();
                    class3.method_3();
                }
                try
                {
                    smethod_2(Class519.class394_0);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, Class537.string_713, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                smethod_1();
                Class1088.smethod_2();
                Class519.class394_0.class803_0.bool_0 = true;
                Class519.class394_0.class627_0.method_0();
                bool flag = Class516.bool_5;
                Class516.bool_5 = false;
                Class397 class4 = smethod_7();
                if (class4.Int32_0 > 0)
                {
                    Class645.smethod_3(class2);
                    Class645.smethod_5(class4, Class519.class394_0.class395_4, Class537.string_133, Enum43.const_1);
                }
                Class516.bool_5 = flag;
            }
        }

        private static void smethod_1()
        {
            Class619 class2 = Class519.class394_0.class619_0;
            for (int i = 0; i < class2.Int32_0; i++)
            {
                class2[i].class619_0.method_7();
            }
        }

        private static Class549.Class530 smethod_10(ArrayList A_0, bool A_1)
        {
            if (A_0.Count == 1)
            {
                uint num;
                Class401 class2 = A_0[0] as Class401;
                if (class2 == null)
                {
                    return null;
                }
                Class456 class3 = class2.class445_1 as Class456;
                if (class3 == null)
                {
                    return null;
                }
                if (A_1)
                {
                    if (class3.ushort_0 != 0)
                    {
                        return null;
                    }
                    Class501 class4 = class2.class445_0 as Class501;
                    if (class4 == null)
                    {
                        return null;
                    }
                    num = class4.uint_0;
                }
                else
                {
                    if (class3.ushort_0 != 1)
                    {
                        return null;
                    }
                    Class484 class5 = class2.class445_0 as Class484;
                    if (class5 == null)
                    {
                        return null;
                    }
                    num = class5.uint_0;
                }
                Enum0 enum2 = (Enum0) ((byte) ((num & -16777216) >> 0x18));
                int num2 = ((int) num) & 0xffffff;
                switch (enum2)
                {
                    case Enum0.const_4:
                        return (Class546.class549_0.arrayList_0[num2] as Class549.Class530);
                }
            }
            return null;
        }

        internal static void smethod_2(Class394 A_0)
        {
            string name;
            A_0.class803_0.bool_0 = true;
            arrayList_0.Clear();
            int_0 = 1;
            int_1 = 1;
            int_2 = 1;
            int_3 = 1;
            int_4 = 1;
            int_5 = 1;
            hashtable_0.Clear();
            int_6 = 1;
            smethod_8(A_0);
            for (int i = 0; i < A_0.class619_0.Int32_0; i++)
            {
                Class390 class2 = A_0.class619_0[i] as Class390;
                name = class2.Name;
                if ((name != "") && smethod_4(name, true))
                {
                    if (!bool_0 || bool_1)
                    {
                        class2.Name = smethod_5(string_0 + int_5.ToString(), name);
                        int_5++;
                    }
                    bool_1 = !bool_1;
                }
            }
            DateTime time = DateTime.Now.AddMilliseconds(500.0);
            ProgressForm form = null;
            ArrayList list = Class546.class548_0.arrayList_0;
            for (int j = 1; j < list.Count; j++)
            {
                if (time < DateTime.Now)
                {
                    if (form == null)
                    {
                        form = new ProgressForm(Class537.string_304, true);
                        form.method_0(1, list.Count);
                        form.Show();
                    }
                    time = DateTime.Now.AddMilliseconds(200.0);
                    form.method_1(j);
                    Class582.smethod_0();
                    if (form.bool_0)
                    {
                        break;
                    }
                }
                Class548.Class529 class3 = list[j] as Class548.Class529;
                bool flag = false;
                name = Class519.class581_0[class3.int_1];
                if (smethod_4(name, true))
                {
                    if (class3.Boolean_13)
                    {
                        if (!bool_0 || bool_1)
                        {
                            Class519.class581_0[class3.int_1] = smethod_5(string_1 + int_2.ToString(), name);
                            int_2++;
                        }
                        bool_1 = !bool_1;
                    }
                    else if (class3.Boolean_5)
                    {
                        if (!bool_0 || bool_1)
                        {
                            Class519.class581_0[class3.int_1] = smethod_5(string_2 + int_3.ToString(), name);
                            int_3++;
                        }
                        bool_1 = !bool_1;
                    }
                    else if (class3.Boolean_14)
                    {
                        if (!bool_0 || bool_1)
                        {
                            Class519.class581_0[class3.int_1] = smethod_5(string_3 + int_4.ToString(), name);
                            int_4++;
                        }
                        bool_1 = !bool_1;
                    }
                    else if ((class3.enum0_0 == Enum0.const_1) && (class3.int_4 == Class519.class604_0.int_6))
                    {
                        if (!bool_0 || bool_1)
                        {
                            Class519.class581_0[class3.int_1] = smethod_5(string_4 + int_1.ToString(), name);
                            int_1++;
                        }
                        bool_1 = !bool_1;
                    }
                    else
                    {
                        if (!bool_0 || bool_1)
                        {
                            Class519.class581_0[class3.int_1] = smethod_5(string_5 + int_0.ToString(), name);
                            int_0++;
                            flag = true;
                        }
                        bool_1 = !bool_1;
                    }
                }
                smethod_3(class3, flag);
            }
            if (form != null)
            {
                form.Hide();
                form = null;
                Class582.smethod_0();
            }
        }

        private static void smethod_3(Class548.Class529 A_0, bool A_1)
        {
            if (A_0.class369_0 != null)
            {
                string str;
                int_7 = 1;
                int_8 = 1;
                int_9 = 1;
                int num = 1;
                if (A_1)
                {
                    if (hashtable_0.ContainsKey(A_0))
                    {
                        num = (int) hashtable_0[A_0];
                    }
                    else
                    {
                        num = int_6;
                        hashtable_0.Add(A_0, int_6);
                        int_6++;
                    }
                }
                if (A_1)
                {
                    str = num.ToString() + "_";
                }
                else
                {
                    str = "_";
                }
                Class619 class2 = A_0.class369_0.class619_0;
                for (int i = 0; i < class2.Int32_0; i++)
                {
                    Class369 class3 = class2[i];
                    switch (class3.QQQS)
                    {
                        case Enum10.const_12:
                        case Enum10.const_13:
                        case Enum10.const_14:
                        case Enum10.const_15:
                        {
                            Class385 class4 = class3 as Class385;
                            Class549.Class530 class5 = class4.class530_0;
                            if (smethod_4(Class519.class581_0[class5.int_1], true))
                            {
                                if (!bool_0 || bool_1)
                                {
                                    Class519.class581_0[class5.int_1] = string_6 + str + int_7.ToString();
                                    int_7++;
                                }
                                bool_1 = !bool_1;
                            }
                            continue;
                        }
                        case Enum10.const_16:
                        case Enum10.const_17:
                        {
                            Class391 class7 = class3 as Class391;
                            Class547.Class528 class8 = class7.class528_0;
                            if (!class8.Boolean_11)
                            {
                                if (smethod_4(Class519.class581_0[class8.int_1], true))
                                {
                                    if (!bool_0 || bool_1)
                                    {
                                        Class519.class581_0[class8.int_1] = string_8 + str + int_8.ToString();
                                        int_8++;
                                    }
                                    bool_1 = !bool_1;
                                }
                                int num3 = 1;
                                for (int j = 0; j < class8.short_2; j++)
                                {
                                    Class568.Class623 class9 = Class546.class568_0.arrayList_0[class8.int_6 + j] as Class568.Class623;
                                    if (smethod_4(Class519.class581_0[class9.int_0], false))
                                    {
                                        if (!bool_0 || bool_1)
                                        {
                                            Class519.class581_0[class9.int_0] = string_11 + num3.ToString();
                                            num3++;
                                        }
                                        bool_1 = !bool_1;
                                    }
                                }
                            }
                            continue;
                        }
                        case Enum10.const_18:
                            break;

                        default:
                        {
                            continue;
                        }
                    }
                    Class384 class6 = class3 as Class384;
                    if (smethod_4(class6.Name, true))
                    {
                        if (!bool_0 || bool_1)
                        {
                            string str2 = string_7 + str + int_9.ToString();
                            class6.Name = str2;
                            switch (class6.enum34_0)
                            {
                                case Enum34.const_0:
                                    Class519.class581_0[(class6.class619_0[0] as Class391).class528_0.int_1] = string_9 + str2;
                                    break;

                                case Enum34.const_1:
                                    Class519.class581_0[(class6.class619_0[0] as Class391).class528_0.int_1] = string_10 + str2;
                                    break;

                                case Enum34.const_2:
                                    Class519.class581_0[(class6.class619_0[0] as Class391).class528_0.int_1] = string_9 + str2;
                                    Class519.class581_0[(class6.class619_0[1] as Class391).class528_0.int_1] = string_10 + str2;
                                    break;
                            }
                            int_9++;
                        }
                        bool_1 = !bool_1;
                    }
                }
            }
        }

        internal static bool smethod_4(string A_0, bool A_1)
        {
            if ((A_0 == null) || (A_0 == ""))
            {
                return true;
            }
            if (A_0 != string_12)
            {
                int length = A_0.Length;
                for (int i = 0; i < length; i++)
                {
                    if (A_0[i] > '~')
                    {
                        return true;
                    }
                }
                if (A_0 == string_13)
                {
                    return true;
                }
                for (int j = 0; j < length; j++)
                {
                    char ch = A_0[j];
                    if (((((ch != '_') && (ch != '.')) && ((ch < 'a') || (ch > 'z'))) && ((ch < 'A') || (ch > 'Z'))) && (((j <= 0) || (ch < '0')) || (ch > '9')))
                    {
                        return true;
                    }
                }
                if (A_0[0] == '_')
                {
                    bool flag = true;
                    for (int k = 1; k < length; k++)
                    {
                        char ch2 = A_0[k];
                        if ((ch2 < '0') && (ch2 > '9'))
                        {
                            flag = false;
                        }
                    }
                    if (flag)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static string smethod_5(string A_0, string A_1)
        {
            Class1094 class2 = new Class1094 {
                string_0 = A_0,
                string_1 = A_1
            };
            arrayList_0.Add(class2);
            return A_0;
        }

        internal static void smethod_6(string A_0)
        {
            using (StreamWriter writer = File.CreateText(A_0))
            {
                int totalWidth = 0;
                for (int i = 0; i < arrayList_0.Count; i++)
                {
                    Class1094 class2 = arrayList_0[i] as Class1094;
                    if (class2.string_0.Length > totalWidth)
                    {
                        totalWidth = class2.string_0.Length;
                    }
                }
                totalWidth++;
                for (int j = 0; j < arrayList_0.Count; j++)
                {
                    Class1094 class3 = arrayList_0[j] as Class1094;
                    writer.Write(class3.string_0.PadRight(totalWidth));
                    writer.Write(' ');
                    writer.WriteLine(class3.string_1);
                }
            }
        }

        internal static Class397 smethod_7()
        {
            Class397 class2 = new Class397();
            int totalWidth = 0;
            for (int i = 0; i < arrayList_0.Count; i++)
            {
                Class1094 class3 = arrayList_0[i] as Class1094;
                if (class3.string_0.Length > totalWidth)
                {
                    totalWidth = class3.string_0.Length;
                }
            }
            totalWidth++;
            for (int j = 0; j < arrayList_0.Count; j++)
            {
                Class1094 class4 = arrayList_0[j] as Class1094;
                class2.method_11(new Class336(Class543.smethod_8(class4.string_0.PadRight(totalWidth) + " " + class4.string_1)));
            }
            return class2;
        }

        private static void smethod_8(Class394 A_0)
        {
            int num = 0;
        Label_0002:
            if (num >= A_0.class619_0.Int32_0)
            {
                return;
            }
            Class619 class2 = A_0.class619_0[num].class619_0;
            int num2 = 0;
            while (true)
            {
                if (num2 >= class2.Int32_0)
                {
                    num++;
                    goto Label_0002;
                }
                Class369 class3 = class2[num2];
                if (class3.QQTY)
                {
                    for (int i = 0; i < class3.class619_0.Int32_0; i++)
                    {
                        if (class3.class619_0[i].QQQS == Enum10.const_21)
                        {
                            try
                            {
                                smethod_9(class3, class3.class619_0[i] as Class381);
                            }
                            catch
                            {
                            }
                        }
                    }
                }
                num2++;
            }
        }

        private static void smethod_9(Class369 A_0, Class381 A_1)
        {
            Class391 class2 = A_1.class619_0[0] as Class391;
            Class385 class4 = smethod_10(Class846.smethod_9(class2.class528_0), class2.class528_0.Boolean_8).class369_0 as Class385;
            if (class4 != null)
            {
                class4.Name = A_1.Name;
                int num = A_0.class619_0[class4];
                if (num != -1)
                {
                    A_0.class619_0[num] = new Class389(class4);
                }
            }
        }

        private class Class1094
        {
            internal string string_0;
            internal string string_1;
        }
    }
}

