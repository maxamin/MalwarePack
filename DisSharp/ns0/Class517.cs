namespace ns0
{
    using System;
    using System.Collections;

    internal class Class517
    {
        private static Hashtable hashtable_0 = new Hashtable();

        internal static Class336 smethod_0(int A_0)
        {
            object key = A_0;
            if (hashtable_0.ContainsKey(key))
            {
                return (Class336) hashtable_0[key];
            }
            Class336 class2 = new Class336(new string(' ', A_0));
            hashtable_0.Add(key, class2);
            return class2;
        }
    }
}

