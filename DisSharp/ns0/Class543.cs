namespace ns0
{
    using System;
    using System.Collections.Specialized;
    using System.Text;

    internal class Class543
    {
        private static StringBuilder stringBuilder_0 = new StringBuilder();

        internal static string smethod_0(string A_0)
        {
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append(A_0);
            for (int i = 0; i < stringBuilder_0.Length; i++)
            {
                if (stringBuilder_0[i] == ',')
                {
                    stringBuilder_0[i] = '.';
                }
            }
            return stringBuilder_0.ToString();
        }

        internal static string smethod_1(string A_0)
        {
            stringBuilder_0.Length = 0;
            for (int i = 0; i < A_0.Length; i++)
            {
                if (A_0[i] != '&')
                {
                    stringBuilder_0.Append(A_0[i]);
                }
            }
            return stringBuilder_0.ToString();
        }

        internal static StringCollection smethod_10(byte[] A_0)
        {
    StringCollection strings = new StringCollection();
    int index = 0;
    int num2 = 0;
    int num3 = 0;
    int num4 = A_0.Length - 1;
    bool flag = true;
    while (true)
    {
        if (!flag)
        {
            num3++;
            char ch = (char) A_0[index];
            stringBuilder_0.Append(ch);
            if (index == num4)
            {
                strings.Add(stringBuilder_0.ToString());
                break;
            }
            if (num3 == num2)
            {
                strings.Add(stringBuilder_0.ToString());
                flag = true;
            }
        }
        else
        {
            if (index == num4)
            {
                break;
            }
            stringBuilder_0.Length = 0;
            num2 = A_0[index];
            num3 = 0;
            if (num2 == 0)
            {
                strings.Add("");
            }
            else
            {
                flag = false;
            }
        }
        index++;
    }
    return strings;

        }

        internal static string smethod_11(string A_0)
        {
            if (A_0.Length > 0)
            {
                return (A_0.Substring(0, 1).ToUpper() + A_0.Substring(1, A_0.Length - 1));
            }
            return A_0;
        }

        internal static string smethod_2(float A_0)
        {
            bool flag = false;
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append(A_0);
            for (int i = 0; i < stringBuilder_0.Length; i++)
            {
                if (stringBuilder_0[i] == ',')
                {
                    stringBuilder_0[i] = '.';
                    flag = true;
                }
                if (stringBuilder_0[i] == '.')
                {
                    flag = true;
                }
                if (stringBuilder_0[i] == 'E')
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                stringBuilder_0.Append(".0");
            }
            return stringBuilder_0.ToString();
        }

        internal static string smethod_3(double A_0)
        {
            bool flag = false;
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append(A_0);
            for (int i = 0; i < stringBuilder_0.Length; i++)
            {
                if (stringBuilder_0[i] == ',')
                {
                    stringBuilder_0[i] = '.';
                    flag = true;
                }
                if (stringBuilder_0[i] == '.')
                {
                    flag = true;
                }
                if (stringBuilder_0[i] == 'E')
                {
                    flag = true;
                }
            }
            if (!flag)
            {
                stringBuilder_0.Append(".0");
            }
            return stringBuilder_0.ToString();
        }

        internal static Class335 smethod_4(int A_0)
        {
            if (((A_0 < 0) || (A_0 > 9)) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static Class335 smethod_5(uint A_0)
        {
            if ((A_0 > 9) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static Class335 smethod_6(long A_0)
        {
            if (((A_0 < 0L) || (A_0 > 9L)) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static Class335 smethod_7(ulong A_0)
        {
            if ((A_0 > 9L) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static string smethod_8(string A_0)
        {
            stringBuilder_0.Length = 0;
            for (int i = 0; i < A_0.Length; i++)
            {
                int num2 = A_0[i];
                if ((num2 >= 0x20) && (num2 <= 0x7e))
                {
                    stringBuilder_0.Append(A_0[i]);
                }
                else
                {
                    stringBuilder_0.Append(@"\u");
                    stringBuilder_0.Append(num2.ToString("X").PadLeft(4, '0'));
                }
            }
            return stringBuilder_0.ToString();
        }

        internal static Class397 smethod_9(byte[] A_0)
        {
            StringCollection strings = smethod_10(A_0);
            Class397 class2 = new Class397();
            for (int i = 0; i < strings.Count; i++)
            {
                class2.method_11(new Class336(strings[i]));
            }
            class2.method_8();
            return class2;
        }
    }
}

