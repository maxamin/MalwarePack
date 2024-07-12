namespace ns0
{
    using System;

    internal class Class923
    {
        private static string string_0 = "";
        private static string string_1 = "";

        internal static string smethod_0(Enum41 A_0)
        {
            if (A_0 == Enum41.const_0)
            {
                return string_0;
            }
            return string_1;
        }

        internal static void smethod_1(Enum41 A_0, string A_1)
        {
            if (A_1 != "")
            {
                if (A_0 == Enum41.const_0)
                {
                    string_0 = A_1;
                }
                else
                {
                    string_1 = A_1;
                }
            }
        }

        internal static string String_0
        {
            get
            {
                return string_0;
            }
            set
            {
                if (value != "")
                {
                    string_0 = value;
                }
            }
        }

        internal static string String_1
        {
            get
            {
                return string_1;
            }
            set
            {
                if (value != "")
                {
                    string_1 = value;
                }
            }
        }
    }
}

