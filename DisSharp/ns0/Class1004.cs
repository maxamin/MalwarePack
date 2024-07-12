namespace ns0
{
    using System;
    using System.Collections;
    using System.Text;

    internal class Class1004
    {
        private static Hashtable hashtable_0 = new Hashtable();
        private static Hashtable hashtable_1 = new Hashtable();
        private static string string_0 = Class537.string_96;
        private static string string_1 = (Class537.string_396 + " ");
        private static StringBuilder stringBuilder_0 = new StringBuilder(20);

        internal static Class336 smethod_0(int A_0)
        {
            object key = A_0;
            if (hashtable_0.ContainsKey(key))
            {
                return (Class336) hashtable_0[key];
            }
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append("V_");
            stringBuilder_0.Append(A_0);
            Class336 class2 = new Class336(stringBuilder_0.ToString());
            hashtable_0.Add(key, class2);
            return class2;
        }

        internal static Class336 smethod_1(int A_0)
        {
            object key = A_0;
            if (hashtable_1.ContainsKey(key))
            {
                return (Class336) hashtable_1[key];
            }
            stringBuilder_0.Length = 0;
            stringBuilder_0.Append(string_0);
            stringBuilder_0.Append(A_0);
            stringBuilder_0.Append(string_1);
            Class336 class2 = new Class336(stringBuilder_0.ToString());
            hashtable_1.Add(key, class2);
            return class2;
        }
    }
}

