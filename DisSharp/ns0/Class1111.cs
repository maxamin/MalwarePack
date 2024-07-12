namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1111
    {
        private static ArrayList arrayList_0;
        private static bool bool_0;
        private static bool bool_1;
        private static bool bool_2;
        private static bool bool_3;
        private static Class399 class399_0;
        private static Class417 class417_0;
        private static Class417 class417_1;
        private static Class433 class433_0;
        private static Class445 class445_0;
        private static Class501 class501_0;
        private static Class893 class893_0 = new Class893(50);
        private static Class893 class893_1 = new Class893(50);
        private static int int_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1();
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 250))
                {
                    return;
                }
            }
        }

        internal static void smethod_1()
        {
            bool_1 = false;
            if (smethod_2())
            {
                smethod_3(Class536.arrayList_0);
                if (bool_1)
                {
                    if (bool_3)
                    {
                        smethod_6();
                    }
                    else
                    {
                        smethod_7();
                    }
                }
            }
        }

        private static int smethod_10(int A_0)
        {
            for (int i = 0; i < class893_1.int_1; i++)
            {
                if (class893_1[i] == A_0)
                {
                    return class893_0[i];
                }
            }
            return 0;
        }

        private static bool smethod_2()
        {
            if (Class536.arrayList_0.Count == 0)
            {
                return false;
            }
            Class418 class2 = Class536.arrayList_0[0] as Class418;
            if (class2 == null)
            {
                return false;
            }
            Class470 class3 = class2.class445_0 as Class470;
            if (class3 == null)
            {
                return false;
            }
            if (class3.enum31_0 != Enum31.const_0)
            {
                return false;
            }
            if (class3.class445_1.Type != Enum17.const_50)
            {
                return false;
            }
            class501_0 = class3.class445_0 as Class501;
            if (class501_0 == null)
            {
                return false;
            }
            ArrayList qQSQ = class2.QQSQ;
            if (qQSQ.Count < 3)
            {
                return false;
            }
            bool_2 = true;
            if (qQSQ[qQSQ.Count - 1] is Class418)
            {
                bool_2 = false;
            }
            int num = bool_2 ? 0 : 1;
            Class399 class5 = qQSQ[0] as Class399;
            if (class5 == null)
            {
                return false;
            }
            Class446 class6 = class5.class445_1 as Class446;
            if (class6 == null)
            {
                return false;
            }
            if ((class6.class445_0 == null) || (class6.class445_0.Length != 2))
            {
                return false;
            }
            Class500 class7 = class5.class445_0 as Class500;
            if (class7 == null)
            {
                return false;
            }
            if (class7.uint_0 != class6.uint_0)
            {
                return false;
            }
            class893_0.method_0();
            class893_1.method_0();
            for (int i = 1; i < ((qQSQ.Count - 1) - num); i++)
            {
                Class443 class8 = qQSQ[i] as Class443;
                if (class8 == null)
                {
                    return false;
                }
                Class487 class9 = class8.class445_0 as Class487;
                if (class9 == null)
                {
                    return false;
                }
                if (class9.class445_0.Type != Enum17.const_53)
                {
                    return false;
                }
                if ((class9.class445_1 == null) || (class9.class445_1.Length != 2))
                {
                    return false;
                }
                Class473 class10 = class9.class445_1[0] as Class473;
                if (class10 == null)
                {
                    return false;
                }
                Class466 class11 = class9.class445_1[1] as Class466;
                if (class11 == null)
                {
                    return false;
                }
                Class447 class12 = class11.class445_0 as Class447;
                if (class12 == null)
                {
                    return false;
                }
                class893_0.method_1(class10.int_0);
                class893_1.method_1(class12.int_0);
            }
            Class399 class13 = qQSQ[(qQSQ.Count - 1) - num] as Class399;
            if (class13 == null)
            {
                return false;
            }
            if (class13.class445_1.Type != Enum17.const_53)
            {
                return false;
            }
            Class501 class14 = class13.class445_0 as Class501;
            if (!class14.method_0(class501_0))
            {
                return false;
            }
            return true;
        }

        private static void smethod_3(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                Class399 class3 = class2 as Class399;
                if (class3 != null)
                {
                    if (smethod_4(A_0, i, class3))
                    {
                        bool_0 = true;
                        bool_1 = true;
                        arrayList_0 = A_0;
                        int_0 = i;
                        class399_0 = class3;
                        bool_3 = true;
                        return;
                    }
                    if (smethod_5(A_0, i, class3))
                    {
                        bool_0 = true;
                        bool_1 = true;
                        arrayList_0 = A_0;
                        int_0 = i;
                        class399_0 = class3;
                        bool_3 = false;
                        return;
                    }
                }
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    smethod_3(qQSQ);
                }
                if (bool_1)
                {
                    return;
                }
            }
        }

        private static bool smethod_4(ArrayList A_0, int A_1, Class399 A_2)
        {
            Class452 class2 = A_2.class445_0 as Class452;
            if (class2 != null)
            {
                if (Class525.enum11_0[class2.ushort_0] != Enum11.const_29)
                {
                    return false;
                }
                class445_0 = A_2.class445_1;
                if (A_1 > (A_0.Count - 2))
                {
                    return false;
                }
                Class418 class3 = A_0[A_1 + 1] as Class418;
                if (class3 == null)
                {
                    return false;
                }
                Class470 class4 = class3.class445_0 as Class470;
                if (class4 == null)
                {
                    return false;
                }
                if (class4.enum31_0 != Enum31.const_1)
                {
                    return false;
                }
                if (class4.class445_1.Type != Enum17.const_50)
                {
                    return false;
                }
                if (!class4.class445_0.method_0(class445_0))
                {
                    return false;
                }
                ArrayList qQSQ = class3.QQSQ;
                if ((qQSQ != null) && (qQSQ.Count == 2))
                {
                    Class399 class5 = qQSQ[0] as Class399;
                    if (class5 == null)
                    {
                        return false;
                    }
                    if (!class5.class445_0.method_0(class2))
                    {
                        return false;
                    }
                    Class486 class6 = class5.class445_1 as Class486;
                    if (class6 == null)
                    {
                        return false;
                    }
                    if (!class6.class445_0.method_0(class501_0))
                    {
                        return false;
                    }
                    Class418 class7 = qQSQ[1] as Class418;
                    if (class7 == null)
                    {
                        return false;
                    }
                    Class470 class8 = class7.class445_0 as Class470;
                    if (class8 == null)
                    {
                        return false;
                    }
                    if (class8.enum31_0 != Enum31.const_1)
                    {
                        return false;
                    }
                    if (class8.class445_1.Type != Enum17.const_50)
                    {
                        return false;
                    }
                    Class486 class9 = class8.class445_0 as Class486;
                    if (class9 == null)
                    {
                        return false;
                    }
                    if (!class9.class445_0.method_0(class501_0))
                    {
                        return false;
                    }
                    ArrayList list2 = class7.QQSQ;
                    if ((list2 == null) || (list2.Count > 2))
                    {
                        return false;
                    }
                    class433_0 = list2[0] as Class433;
                    if (class433_0 == null)
                    {
                        return false;
                    }
                    Class512 class10 = class433_0.class445_0 as Class512;
                    if (class10 == null)
                    {
                        return false;
                    }
                    if (!class10.class445_0.method_0(class2))
                    {
                        return false;
                    }
                    Class525.bool_1[class2.ushort_0] = true;
                    return true;
                }
            }
            return false;
        }

        private static bool smethod_5(ArrayList A_0, int A_1, Class399 A_2)
        {
            Class452 class2 = A_2.class445_0 as Class452;
            if (class2 != null)
            {
                if (Class525.enum11_0[class2.ushort_0] != Enum11.const_29)
                {
                    return false;
                }
                class445_0 = A_2.class445_1;
                if (A_1 > (A_0.Count - 5))
                {
                    return false;
                }
                Class418 class3 = A_0[A_1 + 1] as Class418;
                if (class3 == null)
                {
                    return false;
                }
                if ((class3.QQSQ == null) || (class3.QQSQ.Count != 1))
                {
                    return false;
                }
                class417_0 = class3.QQSQ[0] as Class417;
                if (class417_0 == null)
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
                if (class4.class445_1.Type != Enum17.const_50)
                {
                    return false;
                }
                if (!class4.class445_0.method_0(class445_0))
                {
                    return false;
                }
                Class399 class5 = A_0[A_1 + 2] as Class399;
                if (class5 == null)
                {
                    return false;
                }
                if (!class5.class445_0.method_0(class2))
                {
                    return false;
                }
                Class486 class6 = class5.class445_1 as Class486;
                if (class6 == null)
                {
                    return false;
                }
                if (!class6.class445_0.method_0(class501_0))
                {
                    return false;
                }
                Class418 class7 = A_0[A_1 + 3] as Class418;
                if (class7 == null)
                {
                    return false;
                }
                if ((class7.QQSQ != null) && (class7.QQSQ.Count == 1))
                {
                    class417_1 = class7.QQSQ[0] as Class417;
                    if (class417_1 == null)
                    {
                        return false;
                    }
                    Class470 class8 = class7.class445_0 as Class470;
                    if (class8 == null)
                    {
                        return false;
                    }
                    if (class8.enum31_0 != Enum31.const_0)
                    {
                        return false;
                    }
                    if (class8.class445_1.Type != Enum17.const_50)
                    {
                        return false;
                    }
                    Class486 class9 = class8.class445_0 as Class486;
                    if (class9 == null)
                    {
                        return false;
                    }
                    if (!class9.class445_0.method_0(class501_0))
                    {
                        return false;
                    }
                    class433_0 = A_0[A_1 + 4] as Class433;
                    if (class433_0 == null)
                    {
                        return false;
                    }
                    Class512 class10 = class433_0.class445_0 as Class512;
                    if (class10 == null)
                    {
                        return false;
                    }
                    if (!class10.class445_0.method_0(class2))
                    {
                        return false;
                    }
                    Class525.bool_1[class2.ushort_0] = true;
                    return true;
                }
            }
            return false;
        }

        private static void smethod_6()
        {
            smethod_8();
            Class689.smethod_2(arrayList_0, int_0, 2);
            Class689.smethod_5(class399_0, class433_0);
            arrayList_0.Insert(int_0, class433_0);
            smethod_9();
        }

        private static void smethod_7()
        {
            smethod_8();
            Class689.smethod_2(arrayList_0, int_0, 5);
            Class689.smethod_5(class399_0, class433_0);
            arrayList_0.Insert(int_0, class433_0);
            class417_0.class398_0.method_1(class417_0);
            class417_1.class398_0.method_1(class417_1);
            smethod_9();
        }

        private static void smethod_8()
        {
            if (bool_2)
            {
                Class536.arrayList_0.RemoveAt(0);
            }
            else
            {
                Class418 class2 = Class536.arrayList_0[0] as Class418;
                Class418 class3 = class2.QQSQ[class2.QQSQ.Count - 1] as Class418;
                Class536.arrayList_0.RemoveAt(0);
                Class536.arrayList_0.Insert(0, class3);
            }
        }

        private static void smethod_9()
        {
            class433_0.class445_0 = class445_0;
            ArrayList qQSQ = class433_0.QQSQ;
            for (int i = 0; i < qQSQ.Count; i++)
            {
                Class434 class2 = qQSQ[i] as Class434;
                int[] numArray = class2.int_0;
                for (int j = 0; j < numArray.Length; j++)
                {
                    numArray[j] = smethod_10(numArray[j]);
                }
            }
        }
    }
}

