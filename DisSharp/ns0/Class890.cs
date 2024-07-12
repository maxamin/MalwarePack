namespace ns0
{
    using System;

    internal class Class890
    {
        private static Class238 class238_0 = new Class238();
        private static Class397 class397_0 = new Class397();

        static Class890()
        {
            class397_0.method_8();
        }

        internal static string smethod_0(Enum11 A_0, int A_1)
        {
            return class238_0.method_131(A_0, A_1);
        }

        internal static string smethod_1(string A_0)
        {
            return class238_0.method_132(A_0);
        }

        internal static int smethod_2(uint A_0)
        {
            return class238_0.method_207(A_0);
        }

        internal static string smethod_3(Class550.Class514 A_0)
        {
            class397_0.Class367_1.method_5();
            class238_0.method_0(class397_0);
            class238_0.method_164(A_0);
            string str = class397_0.Class367_1.ToString();
            int index = str.IndexOf("(");
            if (index != -1)
            {
                str = str.Substring(0, index);
            }
            return str;
        }

        internal static string smethod_4(string A_0)
        {
            return class238_0.method_165(A_0);
        }
    }
}

