namespace ns0
{
    using System;
    using System.Collections;
    using System.ComponentModel;

    internal class Class1115
    {
        private static ArrayList arrayList_0 = new ArrayList();

        internal static byte[] smethod_0(string A_0)
        {
            arrayList_0.Clear();
            try
            {
                using (null)
                {
                    new Class1011(A_0, Class1012.ulong_0).method_1(Class1012.intptr_1, new Delegate2(Class1115.smethod_1), IntPtr.Zero);
                }
            }
            catch
            {
            }
            byte[] buffer = null;
            if (arrayList_0.Count > 0)
            {
                buffer = (arrayList_0[0] as Class1116).method_1();
            }
            return buffer;
        }

        private static bool smethod_1(IntPtr A_0, IntPtr A_1, IntPtr A_2, IntPtr A_3)
        {
            try
            {
                Class1011 class2 = new Class1011(A_0, false);
                Class1116 class3 = new Class1116(class2, A_2);
                arrayList_0.Add(class3);
            }
            catch (Win32Exception)
            {
            }
            return true;
        }
    }
}

