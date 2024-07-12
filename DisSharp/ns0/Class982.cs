namespace ns0
{
    using System;

    internal class Class982
    {
        internal static void smethod_0()
        {
            if (Class519.class528_0.Boolean_18 && !Class519.class528_0.Boolean_8)
            {
                for (int i = 0; i < Class536.arrayList_0.Count; i++)
                {
                    Class399 class2 = Class536.arrayList_0[i] as Class399;
                    if (class2 != null)
                    {
                        Class456 class3 = class2.class445_0 as Class456;
                        if ((class3 != null) && (class3.ushort_0 == 0))
                        {
                            Class446 class4 = class2.class445_1 as Class446;
                            if (class4 != null)
                            {
                                uint num2 = class4.uint_0;
                                Enum0 enum2 = (Enum0) ((byte) ((num2 & -16777216) >> 0x18));
                                int num3 = ((int) num2) & 0xffffff;
                                bool flag = false;
                                if (enum2 == Enum0.const_6)
                                {
                                    Class547.Class528 class5 = Class546.class547_0.arrayList_0[num3] as Class547.Class528;
                                    if (Class519.class528_0.class369_0.class369_0 == class5.class369_0.class369_0)
                                    {
                                        flag = true;
                                    }
                                }
                                if (flag)
                                {
                                    Class519.class528_0.enum33_0 = Enum33.const_2;
                                }
                                else
                                {
                                    Class519.class528_0.enum33_0 = Enum33.const_1;
                                }
                                Class519.class528_0.int_5 = i;
                                class2.bool_0 = true;
                                if (enum2 == Enum0.const_10)
                                {
                                    Class551.Class544 class6 = Class546.class551_0.arrayList_0[num3] as Class551.Class544;
                                    if (class6.enum9_0 == Enum9.const_2)
                                    {
                                        Class552.Class545 class7 = Class546.class552_0.arrayList_0[class6.int_0] as Class552.Class545;
                                        if (class7.int_0 == Class519.class604_0.int_1)
                                        {
                                            Class519.class528_0.enum11_0 = Enum11.const_15;
                                        }
                                    }
                                }
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}

