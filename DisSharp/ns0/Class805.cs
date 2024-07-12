namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal class Class805
    {
        private static string string_0 = Class537.string_85;
        private static string string_1 = Class537.string_914;
        private static string string_2 = Class537.string_844;
        private static string string_3 = Class537.string_588;

        internal static bool smethod_0(string A_0)
        {
            if (A_0.Length == 0)
            {
                return false;
            }
            if (!char.IsLetter(A_0[0]) && (A_0[0] != '_'))
            {
                return false;
            }
            for (int i = 1; i < A_0.Length; i++)
            {
                if (!char.IsLetterOrDigit(A_0[i]) && (A_0[i] != '_'))
                {
                    return false;
                }
            }
            return true;
        }

        internal static bool smethod_1(string A_0)
        {
            if (A_0.Length == 0)
            {
                return false;
            }
            if (!char.IsLetter(A_0[0]) && (A_0[0] != '_'))
            {
                return false;
            }
            for (int i = 1; i < A_0.Length; i++)
            {
                if ((!char.IsLetterOrDigit(A_0[i]) && (A_0[i] != '_')) && (A_0[i] != '.'))
                {
                    return false;
                }
            }
            return true;
        }

        internal static void smethod_2(string A_0)
        {
            MessageBox.Show("\"" + A_0 + string_0, string_1, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal static bool smethod_3(int A_0)
        {
            Class369 class2 = Class519.class528_0.class369_0.class369_0;
            if (class2.QQRR)
            {
                return ((A_0 == 1) && Class519.class581_0[Class519.class528_0.int_1].StartsWith(string_2));
            }
            if (class2.QQTV)
            {
                Class547.Class528 class3 = Class519.class528_0;
                return ((A_0 == class3.short_2) && (Class519.class581_0[class3.int_1] == string_3));
            }
            if (class2.QQQS != Enum10.const_21)
            {
                return false;
            }
            return (A_0 == 1);
        }

        internal static bool smethod_4(int A_0)
        {
            Class369 class2 = Class519.class528_0.class369_0.class369_0;
            if (class2.QQRR)
            {
                return ((A_0 == 0) && Class519.class581_0[Class519.class528_0.int_1].StartsWith(string_2));
            }
            if (class2.QQQS != Enum10.const_21)
            {
                return false;
            }
            return (A_0 == 0);
        }

        internal static void smethod_5(Class397 A_0)
        {
            Class335 class1 = A_0.Class367_1.Class335_0;
            if (A_0.Class367_1.Class335_0 == Class518.class337_16)
            {
                A_0.method_10(Class518.class337_19);
            }
        }
    }
}

