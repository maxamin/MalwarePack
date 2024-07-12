namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1051
    {
        internal static void smethod_0()
        {
            ArrayList list = Class536.arrayList_0;
            Class536.class398_0 = new Class398[list.Count];
            for (ushort i = 0; i < list.Count; i = (ushort) (i + 1))
            {
                Class398 class2 = list[i] as Class398;
                class2.ushort_1 = i;
                Class536.class398_0[i] = class2;
            }
        }
    }
}

