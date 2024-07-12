namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1022
    {
        private static ArrayList arrayList_0;

        internal static void smethod_0(Class522 A_0)
        {
            if (A_0.class867_0 == null)
            {
                Class536.class901_0 = new Class901(Enum58.const_0, 0, Class536.arrayList_0.Count - 1);
            }
            else
            {
                Class536.class901_0 = new Class901(Enum58.const_0);
                arrayList_0 = A_0.arrayList_0;
                smethod_1(Class536.class901_0, A_0.class867_0);
            }
        }

private static void smethod_1(Class901 A_0, Class867 A_1)
{
    if (A_1.arrayList_0 != null)
    {
        A_0.arrayList_0 = new ArrayList();
        ArrayList list = A_1.arrayList_0;
        for (int i = 0; i < list.Count; i++)
        {
            Class867 class3 = list[i] as Class867;
            Class901 class4 = null;
            Enum68 enum3 = class3.enum68_0;
            switch (enum3)
            {
                case Enum68.const_0:
                    class4 = new Class901(Enum58.const_0);
                    break;

                case Enum68.const_1:
                    class4 = new Class901(Enum58.const_1);
                    break;

                case Enum68.const_2:
                    class4 = new Class901(Enum58.const_2) {
                        uint_0 = class3.uint_0,
                        bool_0 = class3.bool_0,
                        ushort_0 = class3.ushort_0
                    };
                    break;

                case Enum68.const_3:
                    class4 = new Class901(Enum58.const_3);
                    break;

                default:
                    break;
            }
            A_0.arrayList_0.Add(class4);
            smethod_1(class4, class3);
        }
    }
    else
    {
        int num = A_1.int_0;
        if (A_1.bool_1)
        {
            num++;
        }
        int num2 = A_1.int_1;
        bool flag = true;
        while (true)
        {
            Class822 class2 = arrayList_0[num2] as Class822;
            if (!class2.QQQX && !class2.Boolean_0)
            {
                num2--;
            }
            else
            {
                flag = false;
            }
            if (!flag || (num2 <= 0))
            {
                if (num > num2)
                {
                    A_0.bool_1 = true;
                    return;
                }
                object obj2 = arrayList_0[num];
                flag = true;
                while (true)
                {
                    Enum45 enum2 = (obj2 as Class822).enum45_0;
                    if ((enum2 != Enum45.const_207) && (enum2 != Enum45.const_2))
                    {
                        flag = false;
                    }
                    else
                    {
                        num++;
                        obj2 = arrayList_0[num];
                    }
                    if (!flag || (num <= 0))
                    {
                        A_0.int_0 = (int) Class536.hashtable_3[Class536.hashtable_1[obj2]];
                        if (num2 == (arrayList_0.Count - 1))
                        {
                            A_0.int_1 = Class536.arrayList_0.Count - 1;
                            return;
                        }
                        if (num2 == num)
                        {
                            A_0.int_1 = A_0.int_0;
                            return;
                        }
                        flag = true;
                        while (true)
                        {
                            if (num2 == num)
                            {
                                A_0.int_1 = A_0.int_0;
                                flag = false;
                            }
                            else
                            {
                                object key = arrayList_0[num2];
                                if (!Class536.hashtable_1.ContainsKey(key))
                                {
                                    num2--;
                                }
                                else
                                {
                                    A_0.int_1 = (int) Class536.hashtable_3[Class536.hashtable_1[key]];
                                    flag = false;
                                }
                            }
                            if (!flag)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}


    }
}

