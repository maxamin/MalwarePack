namespace ns0
{
    using System;

    internal class Class1050
    {
        internal static void smethod_0()
        {
            for (int i = 0; i < Class536.arrayList_0.Count; i++)
            {
                Class398 key = Class536.arrayList_0[i] as Class398;
                Class536.hashtable_3.Add(key, i);
            }
        }

        internal static void smethod_1()
        {
            for (int i = 0; i < Class536.arrayList_0.Count; i++)
            {
                Class398 statement = Class536.arrayList_0[i] as Class398;
                Class822 class3 = Class536.hashtable_0[statement] as Class822;
                if (class3 != null)
                {
                    class3.QQVZ(statement);
                }
            }
        }
    }
}

