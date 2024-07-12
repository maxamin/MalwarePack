namespace ns0
{
    using System;
    using System.Collections;

    internal class Class609
    {
        private static Hashtable hashtable_0 = new Hashtable();

        internal static Class336 smethod_0(int A_0)
        {
            if (A_0 == 1)
            {
                return Class518.class337_56;
            }
            object key = A_0;
            if (hashtable_0.ContainsKey(key))
            {
                return (Class336) hashtable_0[key];
            }
            Class336 class2 = new Class336("".PadRight(A_0, '*'));
            hashtable_0.Add(key, class2);
            return class2;
        }
    }
}

