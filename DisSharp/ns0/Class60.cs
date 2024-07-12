namespace ns0
{
    using System;
    using System.Windows.Forms;

    internal abstract class Class60 : Class59
    {
        protected Class60()
        {
        }

        internal bool method_40(string A_1)
        {
            if (A_1.Length == 0)
            {
                return false;
            }
            if (!char.IsLetter(A_1[0]) && (A_1[0] != '_'))
            {
                return false;
            }
            for (int i = 1; i < A_1.Length; i++)
            {
                if (!char.IsLetterOrDigit(A_1[i]) && (A_1[i] != '_'))
                {
                    return false;
                }
            }
            return true;
        }

        internal bool method_41(string A_1)
        {
            if (A_1.Length == 0)
            {
                return false;
            }
            if (!char.IsLetter(A_1[0]) && (A_1[0] != '_'))
            {
                return false;
            }
            for (int i = 1; i < A_1.Length; i++)
            {
                if ((!char.IsLetterOrDigit(A_1[i]) && (A_1[i] != '_')) && (A_1[i] != '.'))
                {
                    return false;
                }
            }
            return true;
        }

        internal void method_42(string A_1)
        {
            MessageBox.Show("\"" + A_1 + Class537.string_85, Class537.string_914, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal bool method_43(int A_1)
        {
            Class369 class2 = Class519.class528_0.class369_0.class369_0;
            if (class2.QQRR)
            {
                return ((A_1 == 1) && Class519.class581_0[Class519.class528_0.int_1].StartsWith(Class537.string_844));
            }
            if (class2.QQTV)
            {
                Class547.Class528 class3 = Class519.class528_0;
                return ((A_1 == class3.short_2) && (Class519.class581_0[class3.int_1] == Class537.string_588));
            }
            if (class2.QQQS != Enum10.const_21)
            {
                return false;
            }
            return (A_1 == 1);
        }

        internal bool method_44(int A_1)
        {
            Class369 class2 = Class519.class528_0.class369_0.class369_0;
            if (class2.QQRR)
            {
                return ((A_1 == 0) && Class519.class581_0[Class519.class528_0.int_1].StartsWith(Class537.string_844));
            }
            if (class2.QQQS != Enum10.const_21)
            {
                return false;
            }
            return (A_1 == 0);
        }
    }
}

