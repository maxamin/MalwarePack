namespace ns0
{
    using System;
    using System.Collections;

    internal class Class520
    {
        private static Class548.Class529 class529_0;
        private static Hashtable hashtable_0;

        internal static Class445 smethod_0(Class445 A_0, uint A_1)
        {
            Class456 class2 = A_0 as Class456;
            if (class2 == null)
            {
                return A_0;
            }
            if (class2.ushort_0 != 0)
            {
                return A_0;
            }
            Enum0 enum2 = (Enum0) ((byte) ((A_1 & -16777216) >> 0x18));
            int num = ((int) A_1) & 0xffffff;
            bool flag = false;
            bool flag2 = false;
            bool flag3 = false;
            Class547.Class528 class3 = null;
            string key = string.Empty;
            Enum0 enum3 = enum2;
            switch (enum3)
            {
                case Enum0.const_4:
                {
                    Class549.Class530 class8 = Class546.class549_0.arrayList_0[num] as Class549.Class530;
                    key = Class519.class581_0[class8.int_1];
                    goto Label_0185;
                }
                case Enum0.const_5:
                    return class2;

                case Enum0.const_6:
                    break;

                default:
                {
                    if (enum3 != Enum0.const_10)
                    {
                        return class2;
                    }
                    Class551.Class544 class4 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class4.enum9_0 == Enum9.const_1)
                    {
                        Class555.Class600 class5 = Class546.class555_0.arrayList_0[class4.int_0] as Class555.Class600;
                        key = Class519.class581_0[class5.int_1];
                    }
                    else if (class4.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class6 = Class546.class552_0.arrayList_0[class4.int_0] as Class552.Class545;
                        key = Class519.class581_0[class6.int_1];
                        flag3 = class6.Boolean_3;
                    }
                    else if (class4.enum9_0 == Enum9.const_3)
                    {
                        num = class4.int_0;
                        break;
                    }
                    flag = true;
                    goto Label_0185;
                }
            }
            class3 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            if (smethod_1(class3) != Class519.class529_0)
            {
                flag = true;
            }
            key = Class519.class581_0[class3.int_1];
            flag2 = true;
            flag3 = class3.Boolean_12;
        Label_0185:
            if (flag)
            {
                if ((!hashtable_0.ContainsKey(key) && (key != Class537.string_454)) && (key != Class537.string_588))
                {
                    class2.enum30_0 = Enum30.const_2;
                }
                else
                {
                    class2.enum30_0 = Enum30.const_1;
                }
            }
            else if ((!Class525.hashtable_0.ContainsKey(key) && (key != Class537.string_454)) && (key != Class537.string_588))
            {
                class2.enum30_0 = Enum30.const_2;
            }
            else
            {
                class2.enum30_0 = Enum30.const_0;
            }
            if ((class2.enum30_0 == Enum30.const_2) && flag2)
            {
                Class369 class9 = class3.class369_0.class369_0;
                if ((class9.QQQS == Enum10.const_18) || (class9.QQQS == Enum10.const_21))
                {
                    key = class9.Name;
                    if (flag)
                    {
                        if (hashtable_0.ContainsKey(key))
                        {
                            class2.enum30_0 = Enum30.const_1;
                        }
                        return class2;
                    }
                    if (Class525.hashtable_0.ContainsKey(key))
                    {
                        class2.enum30_0 = Enum30.const_0;
                    }
                }
                return class2;
            }
            if ((class2.enum30_0 == Enum30.const_1) && flag3)
            {
                if ((!Class525.hashtable_0.ContainsKey(key) && (key != Class537.string_454)) && (key != Class537.string_588))
                {
                    class2.enum30_0 = Enum30.const_2;
                    return class2;
                }
                class2.enum30_0 = Enum30.const_0;
            }
            return class2;
        }

        internal static Class548.Class529 smethod_1(Class547.Class528 A_0)
        {
            Class369 class2 = A_0.class369_0.class369_0;
            while (!(class2 is Class370))
            {
                class2 = class2.class369_0;
            }
            return (class2 as Class370).class529_0;
        }

        internal static void smethod_2(Class547.Class528 A_0)
        {
            Class369 class2 = A_0.class369_0.class369_0;
            while (!(class2 is Class370))
            {
                class2 = class2.class369_0;
            }
            Class548.Class529 class3 = (class2 as Class370).class529_0;
            if (class3 != class529_0)
            {
                class529_0 = class3;
                if (class3.hashtable_0 != null)
                {
                    hashtable_0 = class3.hashtable_0;
                }
                else
                {
                    if (class2.QQTY)
                    {
                        hashtable_0 = smethod_4(class2.class619_0);
                    }
                    else
                    {
                        hashtable_0 = new Hashtable();
                    }
                    class3.hashtable_0 = hashtable_0;
                }
            }
        }

        internal static void smethod_3(Class548.Class529 A_0)
        {
            if (A_0.hashtable_0 == null)
            {
                class529_0 = null;
                Class369 class2 = A_0.class369_0;
                if (class2 != null)
                {
                    Hashtable hashtable;
                    if (!class2.QQTY && !class2.QQUR)
                    {
                        hashtable = new Hashtable();
                    }
                    else
                    {
                        hashtable = smethod_4(class2.class619_0);
                    }
                    A_0.hashtable_0 = hashtable;
                }
            }
        }

        private static Hashtable smethod_4(Class619 A_0)
        {
            Hashtable hashtable = new Hashtable();
            for (int i = 0; i < A_0.Int32_0; i++)
            {
                Class369 class2 = A_0[i];
                string name = class2.Name;
                if (!hashtable.ContainsKey(name))
                {
                    hashtable.Add(name, null);
                }
                if (class2.class619_0.Int32_0 > 0)
                {
                    Class619 class3 = class2.class619_0;
                    for (int j = 0; j < class3.Int32_0; j++)
                    {
                        name = class3[j].Name;
                        if (!hashtable.ContainsKey(name))
                        {
                            hashtable.Add(name, null);
                        }
                    }
                }
            }
            return hashtable;
        }
    }
}

