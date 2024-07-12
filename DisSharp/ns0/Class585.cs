namespace ns0
{
    using System;
    using System.Collections;

    internal class Class585
    {
        private static Hashtable hashtable_0 = new Hashtable();
        private static Hashtable hashtable_1 = new Hashtable();

        internal static Class336 smethod_0(int A_0)
        {
            object key = A_0;
            if (hashtable_0.ContainsKey(key))
            {
                return (Class336) hashtable_0[key];
            }
            Class336 class2 = new Class336(A_0.ToString());
            hashtable_0.Add(key, class2);
            return class2;
        }

        internal static Class340 smethod_1(int A_0)
        {
            object key = A_0;
            if (hashtable_1.ContainsKey(key))
            {
                return (Class340) hashtable_1[key];
            }
            Class340 class2 = new Class340(A_0.ToString());
            hashtable_1.Add(key, class2);
            return class2;
        }
    }
}

