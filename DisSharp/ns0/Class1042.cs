namespace ns0
{
    using Microsoft.Win32;
    using System;

    internal class Class1042
    {
        internal static bool bool_0 = true;
        private const byte byte_0 = 8;
        internal static int int_0;
        internal static string string_0;
        internal static string string_1;

        internal static void smethod_0(RegistryKey A_0)
        {
            string_0 = (string) A_0.GetValue(Class537.string_543, "");
            string_1 = (string) A_0.GetValue(Class537.string_360, "");
            int_0 = (int) A_0.GetValue(Class537.string_288, 0);
        }

        internal static void smethod_1(RegistryKey A_0)
        {
            A_0.SetValue(Class537.string_543, string_0);
            A_0.SetValue(Class537.string_360, string_1);
            A_0.SetValue(Class537.string_288, int_0);
        }

        internal static void smethod_2()
        {
            if (smethod_4(int_0.ToString()))
            {
                bool_0 = false;
                Class698.class582_0.class936_0.toolStripMenuItem_0.Visible = false;
            }
            else
            {
                bool_0 = true;
            }
            Class705.smethod_1();
            Class645.class704_0.method_11();
        }

        internal static bool smethod_3(string A_0, string A_1, string A_2)
        {
            if (!smethod_4(A_2))
            {
                return false;
            }
            try
            {
                int_0 = int.Parse(A_2);
                string_0 = A_0;
                string_1 = A_1;
                bool_0 = false;
                Class698.class582_0.class936_0.toolStripMenuItem_0.Visible = false;
                Class705.smethod_1();
                return true;
            }
            catch
            {
                return false;
            }
        }

        internal static bool smethod_4(string A_0)
        {
            if (A_0.Length != 8)
            {
                return false;
            }
            byte[] buffer = new byte[8];
            int num = 0x30;
            for (int i = 0; i < 8; i++)
            {
                char c = A_0[i];
                if (!char.IsDigit(c))
                {
                    return false;
                }
                buffer[i] = (byte) (c - num);
            }
            if ((((buffer[1] + buffer[3]) + buffer[5]) + buffer[7]) != 0x15)
            {
                return false;
            }
            return true;
        }
    }
}

