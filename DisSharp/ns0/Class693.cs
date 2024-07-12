namespace ns0
{
    using System;
    using System.Reflection;

    internal class Class693
    {
        internal static void smethod_0()
        {
            AssemblyName target = Assembly.GetExecutingAssembly().GetName();
            byte[] buffer = (byte[]) target.GetType().InvokeMember(Class924.String_1, BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly, null, target, null);
            byte[] buffer2 = Class542.Byte_80;
            byte[] buffer3 = Class542.Byte_19;
            byte[] buffer4 = new byte[buffer2.Length + buffer3.Length];
            for (int i = 0; i < buffer2.Length; i++)
            {
                buffer4[i] = buffer2[i];
            }
            for (int j = 0; j < buffer3.Length; j++)
            {
                buffer4[buffer2.Length + j] = buffer3[j];
            }
            bool flag = true;
            if (buffer == null)
            {
                flag = false;
            }
            if (buffer.Length != buffer4.Length)
            {
                flag = false;
            }
            for (int k = 0; k < buffer.Length; k++)
            {
                if (buffer[k] != buffer4[k])
                {
                    flag = false;
                }
            }
            /*if (!flag)
            {
                throw new Exception();
            }*/
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
                if (!char.IsLetterOrDigit(A_0[i]) && (A_0[i] != '_'))
                {
                    return false;
                }
            }
            return true;
        }

        internal static bool smethod_2(string A_0)
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

        internal static string smethod_3(string A_0)
        {
            if (A_0.Length > 0)
            {
                return (A_0.Substring(0, 1).ToUpper() + A_0.Substring(1, A_0.Length - 1));
            }
            return A_0;
        }
    }
}

