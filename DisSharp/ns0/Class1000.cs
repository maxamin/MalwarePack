namespace ns0
{
    using System;
    using System.Reflection;

    internal class Class1000
    {
        internal static void smethod_0()
        {
            byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
            byte[] buffer2 = Class542.Byte_14;
            bool flag = true;
            if (publicKey == null)
            {
                flag = false;
            }
            if (publicKey.Length != buffer2.Length)
            {
                flag = false;
            }
            for (int i = 0; i < publicKey.Length; i++)
            {
                if (publicKey[i] != buffer2[i])
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                throw new Exception();
            }
        }

        internal static string smethod_1(string A_0)
        {
            if (A_0.Length > 0)
            {
                return (A_0.Substring(0, 1).ToUpper() + A_0.Substring(1, A_0.Length - 1));
            }
            return A_0;
        }

        internal static Class335 smethod_2(int A_0)
        {
            if (((A_0 < 0) || (A_0 > 9)) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static Class335 smethod_3(uint A_0)
        {
            if ((A_0 > 9) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static Class335 smethod_4(long A_0)
        {
            if (((A_0 < 0L) || (A_0 > 9L)) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }

        internal static Class335 smethod_5(ulong A_0)
        {
            if ((A_0 > 9L) && Class516.bool_4)
            {
                return new Class336(Class537.string_430 + A_0.ToString("X"));
            }
            return new Class336(A_0.ToString());
        }
    }
}

