namespace ns0
{
    using System;
    using System.Collections;
    using System.IO;

    internal class Class989
    {
        internal static void smethod_0(Class394 A_0)
        {
            if (!smethod_1(A_0))
            {
                bool flag = Class521.Boolean_0;
                bool flag2 = (Class698.class582_0.class990_0.enum65_0 != Enum65.const_0) && (Class519.class394_0.int_0 > 0xdb7cf);
                bool flag3 = Class698.class582_0.class990_0.enum65_0 == Enum65.const_0;
                ArrayList list = A_0.class684_0.class547_0.arrayList_0;
                bool flag4 = true;
                for (int i = 1; i < list.Count; i++)
                {
                    Class547.Class528 class2 = list[i] as Class547.Class528;
                    class2.uint_25 |= 0x100000;
                    if (flag)
                    {
                        if (flag2)
                        {
                            class2.uint_25 &= 0xffefffff;
                        }
                        if (flag3)
                        {
                            Class369 class3 = class2.class369_0;
                            if ((class3 != null) && (class3.QQQS == Enum10.const_16))
                            {
                                Class369 class4 = class3.class369_0;
                                if ((class4 != null) && (class4 is Class370))
                                {
                                    if (flag4)
                                    {
                                        class2.uint_25 &= 0xffefffff;
                                    }
                                    flag4 = !flag4;
                                }
                                else
                                {
                                    class2.uint_25 &= 0xffefffff;
                                }
                            }
                            else
                            {
                                class2.uint_25 &= 0xffefffff;
                            }
                        }
                    }
                }
            }
        }

        private static bool smethod_1(Class394 A_0)
        {
            bool flag = Path.GetFileName(A_0.string_2) == Class537.string_847;
            int count = A_0.class684_0.class547_0.arrayList_0.Count;
            return (flag && (count < 100));
        }
    }
}

