namespace ns0
{
    using System;
    using System.Collections;
    using System.Text;

    internal class Class525
    {
        private static ArrayList arrayList_0 = new ArrayList();
        internal static bool[] bool_0;
        internal static bool[] bool_1;
        internal static byte[] byte_0;
        internal static Enum11[] enum11_0;
        internal static Hashtable hashtable_0 = new Hashtable();
        internal static int int_0;
        internal static int int_1;
        internal static int[] int_2;
        private static int int_3;
        private static int int_4;
        private static int int_5;
        private static int int_6;
        internal static string[] string_0;
        private static string[] string_1;
        private static string string_2 = Class537.string_454;
        private static string string_3 = Class537.string_588;
        private static string string_4 = Class617.String_2;
        private static StringBuilder stringBuilder_0 = new StringBuilder(100);

        internal static void smethod_0(Class547.Class528 A_0)
        {
            int_4 = 1;
            int_6 = 0;
            arrayList_0.Clear();
            hashtable_0.Clear();
            hashtable_0.Add(string_2, null);
            hashtable_0.Add(string_3, null);
            int_3 = A_0.short_2;
            string_1 = new string[int_3];
            ArrayList list = Class546.class568_0.arrayList_0;
            int index = A_0.int_6;
            for (int i = 0; i < int_3; i++)
            {
                string str = Class519.class581_0[(list[index + i] as Class568.Class623).int_0];
                string_1[i] = str;
                hashtable_0[str] = null;
            }
            int_1 = A_0.short_3;
            if (int_1 != 0)
            {
                string_0 = new string[int_1];
                enum11_0 = new Enum11[int_1];
                int_2 = new int[int_1];
                byte_0 = new byte[int_1];
                bool_0 = new bool[int_1];
                bool_1 = new bool[int_1];
                ArrayList list2 = Class546.class574_0.arrayList_0;
                int_0 = A_0.int_7;
                bool flag = false;
                for (int j = 0; j < int_1; j++)
                {
                    Class640 class3;
                    Class574.Class636 class2 = list2[int_0 + j] as Class574.Class636;
                    Enum11 enum2 = class2.enum11_0;
                    enum11_0[j] = enum2;
                    int num4 = class2.int_1;
                    int_2[j] = num4;
                    byte num5 = class2.byte_0;
                    byte_0[j] = num5;
                    bool_0[j] = class2.bool_0;
                    if (num5 > 0)
                    {
                        flag = true;
                    }
                    bool flag2 = false;
                    for (int n = 0; n < arrayList_0.Count; n++)
                    {
                        class3 = arrayList_0[n] as Class640;
                        if (((class3.enum11_0 == enum2) && (class3.int_0 == num4)) && (class3.byte_0 == num5))
                        {
                            goto Label_01F7;
                        }
                    }
                    goto Label_0209;
                Label_01F7:
                    class3.class641_0.method_1((short) j);
                    flag2 = true;
                Label_0209:
                    if (!flag2)
                    {
                        Class640 class4 = new Class640 {
                            enum11_0 = enum2,
                            int_0 = num4,
                            byte_0 = num5
                        };
                        class4.class641_0.method_1((short) j);
                        arrayList_0.Add(class4);
                    }
                }
                if (flag)
                {
                    A_0.uint_25 |= 0x400;
                }
                for (int k = 0; k < arrayList_0.Count; k++)
                {
                    Class640 class5 = arrayList_0[k] as Class640;
                    string str2 = Class890.smethod_0(class5.enum11_0, class5.int_0);
                    if (str2 == "")
                    {
                        str2 = Class537.string_645;
                    }
                    if (class5.byte_0 > 0)
                    {
                        str2 = str2 + Class537.string_712;
                    }
                    if (Class969.smethod_3(class5.enum11_0))
                    {
                        str2 = str2 + Class537.string_93;
                    }
                    class5.string_0 = str2;
                }
                Class1029.smethod_0(arrayList_0);
                bool flag3 = Class846.Boolean_0;
                for (int m = 0; m < arrayList_0.Count; m++)
                {
                    Class640 class6 = arrayList_0[m] as Class640;
                    string str3 = class6.string_0;
                    if ((class6.class641_0.short_1 == 1) && flag3)
                    {
                        index = class6.class641_0[0];
                        Class574.Class636 class7 = list2[int_0 + index] as Class574.Class636;
                        if (class7.int_0 > 0)
                        {
                            string str4 = Class519.class581_0[class7.int_0];
                            if (smethod_4(str4))
                            {
                                string_0[index] = str4;
                                hashtable_0[str4] = null;
                            }
                            else
                            {
                                smethod_1(str4, index, class7);
                            }
                        }
                        else if (smethod_4(str3))
                        {
                            class7.int_0 = Class519.class581_0.method_0(str3);
                            string_0[index] = str3;
                            hashtable_0[str3] = null;
                        }
                        else
                        {
                            smethod_1(str3, index, class7);
                        }
                    }
                    else
                    {
                        Class641 class8 = class6.class641_0;
                        int num9 = class8.short_1;
                        for (int num10 = 0; num10 < num9; num10++)
                        {
                            index = class8[num10];
                            Class574.Class636 class9 = list2[int_0 + index] as Class574.Class636;
                            if (class9.int_0 > 0)
                            {
                                string str5 = Class519.class581_0[class9.int_0];
                                if (smethod_4(str5))
                                {
                                    string_0[index] = str5;
                                    hashtable_0[str5] = null;
                                }
                                else
                                {
                                    smethod_1(str5, index, class9);
                                }
                            }
                            else
                            {
                                smethod_1(str3, index, class9);
                            }
                        }
                    }
                }
            }
        }

        private static void smethod_1(string A_0, int A_1, Class574.Class636 A_2)
        {
            int num = 1;
            bool flag = true;
            while (true)
            {
                string str = smethod_5(A_0, num);
                if (smethod_4(str))
                {
                    flag = false;
                }
                num++;
                if (!flag)
                {
                    A_2.int_0 = Class519.class581_0.method_0(str);
                    string_0[A_1] = str;
                    hashtable_0[str] = null;
                    return;
                }
            }
        }

        internal static void smethod_2(int A_0)
        {
            bool flag = true;
            while (true)
            {
                string str = string_4 + int_4.ToString();
                if (smethod_4(str))
                {
                    flag = false;
                }
                int_4++;
                if (!flag)
                {
                    int_6++;
                    int_5 = A_0;
                    Class574.Class636 class2 = Class546.class574_0.arrayList_0[int_0 + A_0] as Class574.Class636;
                    Class519.class581_0[class2.int_0] = str;
                    string_0[A_0] = str;
                    bool_1[A_0] = true;
                    return;
                }
            }
        }

        internal static void smethod_3()
        {
            if (int_6 == 1)
            {
                string str = string_4;
                if (smethod_4(str))
                {
                    Class574.Class636 class2 = Class546.class574_0.arrayList_0[int_0 + int_5] as Class574.Class636;
                    Class519.class581_0[class2.int_0] = str;
                    string_0[int_5] = str;
                }
            }
        }

        internal static bool smethod_4(string A_0)
        {
            if (int_3 > 0)
            {
                for (int j = 0; j < int_3; j++)
                {
                    if (string_1[j] == A_0)
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < int_1; i++)
            {
                if ((string_0[i] != null) && (string_0[i] == A_0))
                {
                    return false;
                }
            }
            return true;
        }

        internal static string smethod_5(string A_0, int A_1)
        {
            stringBuilder_0.Length = 0;
            if (char.IsDigit(A_0, A_0.Length - 1))
            {
                stringBuilder_0.Append(A_0);
                stringBuilder_0.Append('_');
                stringBuilder_0.Append(A_1);
            }
            else
            {
                stringBuilder_0.Append(A_0);
                stringBuilder_0.Append(A_1);
            }
            return stringBuilder_0.ToString();
        }

        internal static void smethod_6(Class524 A_0)
        {
            A_0.Write((short) int_1);
            for (int i = 0; i < int_1; i++)
            {
                if (bool_1[i])
                {
                    A_0.Write((byte) 1);
                }
                else
                {
                    A_0.Write((byte) 0);
                }
            }
            A_0.Write((short) arrayList_0.Count);
            for (int j = 0; j < arrayList_0.Count; j++)
            {
                Class640 class2 = arrayList_0[j] as Class640;
                A_0.Write(class2.class641_0.short_1);
                for (int k = 0; k < class2.class641_0.short_1; k++)
                {
                    A_0.Write(class2.class641_0[k]);
                }
            }
        }

        internal static ArrayList ArrayList_0
        {
            get
            {
                return arrayList_0;
            }
            set
            {
                arrayList_0 = value;
            }
        }
    }
}

