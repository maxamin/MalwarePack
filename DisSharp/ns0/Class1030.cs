namespace ns0
{
    using System;

    internal class Class1030
    {
        private static string string_0 = Class537.string_454;
        private static string string_1 = Class537.string_588;

        internal static bool smethod_0(uint A_0, uint A_1)
        {
            string str;
            string str2;
            Class547.Class528 class7;
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            Enum69 enum3 = Enum69.const_0;
            Enum0 enum4 = enum2;
            if (enum4 != Enum0.const_6)
            {
                if (enum4 != Enum0.const_10)
                {
                    return false;
                }
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    str = Class519.class581_0[class3.int_1];
                    if (str.Length < 5)
                    {
                        return false;
                    }
                    enum3 = Enum69.const_2;
                    goto Label_00D1;
                }
                if (class2.enum9_0 == Enum9.const_3)
                {
                    num = class2.int_0;
                }
                else
                {
                    return false;
                }
            }
            Class547.Class528 class4 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            str = Class519.class581_0[class4.int_1];
            if (str.Length < 5)
            {
                return false;
            }
            enum3 = Enum69.const_1;
        Label_00D1:
            enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            num = ((int) A_1) & 0xffffff;
            Enum0 enum5 = enum2;
            if (enum5 != Enum0.const_6)
            {
                if (enum5 == Enum0.const_10)
                {
                    Class551.Class544 class5 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class5.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class6 = Class546.class552_0.arrayList_0[class5.int_0] as Class552.Class545;
                        str2 = Class519.class581_0[class6.int_1];
                        if (str2.Length < 5)
                        {
                            return false;
                        }
                        if (enum3 != Enum69.const_2)
                        {
                            return false;
                        }
                        if (str.Substring(4) == str2.Substring(4))
                        {
                            return true;
                        }
                    }
                    else if (class5.enum9_0 == Enum9.const_3)
                    {
                        num = class5.int_0;
                        goto Label_018C;
                    }
                }
                return false;
            }
        Label_018C:
            class7 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            str2 = Class519.class581_0[class7.int_1];
            if (str2.Length < 5)
            {
                return false;
            }
            if (enum3 != Enum69.const_1)
            {
                return false;
            }
            return (str.Substring(4) == str2.Substring(4));
        }

        internal static bool smethod_1(uint A_0, uint A_1)
        {
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            Enum69 enum3 = Enum69.const_0;
            Enum0 enum4 = enum2;
            if (enum4 != Enum0.const_6)
            {
                if (enum4 != Enum0.const_10)
                {
                    return false;
                }
                Class551.Class544 class2 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class2.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class3 = Class546.class552_0.arrayList_0[class2.int_0] as Class552.Class545;
                    if (Class519.class581_0[class3.int_1] != string_0)
                    {
                        return false;
                    }
                    enum3 = Enum69.const_2;
                    goto Label_00D0;
                }
                if (class2.enum9_0 == Enum9.const_3)
                {
                    num = class2.int_0;
                }
                else
                {
                    return false;
                }
            }
            Class547.Class528 class4 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            if (Class519.class581_0[class4.int_1] != string_0)
            {
                return false;
            }
            enum3 = Enum69.const_1;
        Label_00D0:
            enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            num = ((int) A_1) & 0xffffff;
            Enum0 enum5 = enum2;
            if (enum5 != Enum0.const_6)
            {
                if (enum5 != Enum0.const_10)
                {
                    return false;
                }
                Class551.Class544 class5 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                if (class5.enum9_0 == Enum9.const_2)
                {
                    Class552.Class545 class6 = Class546.class552_0.arrayList_0[class5.int_0] as Class552.Class545;
                    if (Class519.class581_0[class6.int_1] != string_1)
                    {
                        return false;
                    }
                    if (enum3 != Enum69.const_2)
                    {
                        return false;
                    }
                    return true;
                }
                if (class5.enum9_0 == Enum9.const_3)
                {
                    num = class5.int_0;
                }
                else
                {
                    return false;
                }
            }
            Class547.Class528 class7 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            if (Class519.class581_0[class7.int_1] != string_1)
            {
                return false;
            }
            if (enum3 != Enum69.const_1)
            {
                return false;
            }
            return true;
        }

        private enum Enum69
        {
            const_0,
            const_1,
            const_2
        }
    }
}

