namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1044
    {
        internal static bool smethod_0()
        {
            Class1084.class893_0.method_0();
            Class1084.class893_1.method_0();
            Class445 class2 = null;
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class419 class3 = Class853.struct5_0[i].class419_0;
                if (class3.arrayList_0 != null)
                {
                    return false;
                }
                Class470 class4 = class3.class445_0 as Class470;
                if (class4 == null)
                {
                    return false;
                }
                if (class4.enum31_0 != Enum31.const_0)
                {
                    return false;
                }
                if (class2 == null)
                {
                    class2 = class4.class445_0;
                }
                else if (!class4.class445_0.method_0(class2))
                {
                    return false;
                }
                Class473 class5 = class4.class445_1 as Class473;
                if (class5 == null)
                {
                    return false;
                }
                Class398 class6 = class3.class398_0;
                if (!smethod_2(class6))
                {
                    return false;
                }
                Class1084.class893_1.method_1(class5.int_0);
                Class1084.class893_0.method_1(class6.ushort_1);
            }
            Class1084.smethod_10(Class973.arrayList_0, Class853.struct5_0[0].class419_0, class2, Class973.int_0, Class853.int_1);
            smethod_1(class2);
            return true;
        }

        private static void smethod_1(Class445 A_0)
        {
            int index = Class929.int_0 - 1;
            if (index >= 0)
            {
                Struct8 struct2 = Class929.struct8_0[index];
                ArrayList list = Class973.arrayList_0;
                ArrayList list2 = struct2.arrayList_0;
                int num2 = struct2.int_0;
                if (list.Count == 2)
                {
                    Class433 class2 = list[1] as Class433;
                    if (class2 != null)
                    {
                        Class399 class3 = list[0] as Class399;
                        if ((class3 != null) && class3.class445_0.method_0(A_0))
                        {
                            Class452 class4 = class3.class445_0 as Class452;
                            if (((class4 != null) && (class3.class445_1 is Class504)) && (num2 >= 1))
                            {
                                Class418 class6 = list2[num2] as Class418;
                                if (class6 != null)
                                {
                                    Class470 class7 = class6.class445_0 as Class470;
                                    if (((class7 != null) && (class7.enum31_0 == Enum31.const_1)) && (class7.class445_1.Type == Enum17.const_50))
                                    {
                                        Class445 class8 = class7.class445_0;
                                        Class399 class9 = list2[num2 - 1] as Class399;
                                        if (((class9 != null) && class9.class445_0.method_0(class4)) && class9.class445_1.method_0(class8))
                                        {
                                            Class525.bool_1[class4.ushort_0] = true;
                                            class2.class445_0 = class8;
                                            if (class9.arrayList_0 != null)
                                            {
                                                ArrayList list3 = class9.arrayList_0;
                                                for (int i = 0; i < list3.Count; i++)
                                                {
                                                    Class398 class10 = list3[i] as Class398;
                                                    Class689.smethod_4(class10, class9, class2);
                                                }
                                            }
                                            list2.RemoveAt(num2 - 1);
                                            list2.RemoveAt(num2 - 1);
                                            list2.Insert(num2 - 1, class2);
                                            if (num2 <= (list2.Count - 1))
                                            {
                                                Class410 class11 = list2[num2] as Class410;
                                                if (class11 != null)
                                                {
                                                    Class434 class12 = new Class434(class2, class11.QQSQ, new int[0], Enum27.const_1, Enum29.const_2, 0);
                                                    class2.QQSQ.Add(class12);
                                                    list2.RemoveAt(num2);
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
        }

        private static bool smethod_2(Class398 A_0)
        {
            for (int i = 0; i < Class973.arrayList_0.Count; i++)
            {
                if (Class973.arrayList_0[i] == A_0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

