namespace ns0
{
    using System;
    using System.Collections;

    internal class Class991
    {
        private static bool bool_0;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                smethod_1(Class536.arrayList_0);
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

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = A_0.Count - 1; i >= 2; i--)
            {
                Class438 class3;
                ArrayList qQSQ;
                Class398 class2 = A_0[i] as Class398;
                if (class2.Type == Enum26.const_11)
                {
                    class3 = A_0[i - 1] as Class438;
                    if (class3 != null)
                    {
                        Class412 class4 = class2 as Class412;
                        qQSQ = class4.QQSQ;
                        if (qQSQ != null)
                        {
                            switch (qQSQ.Count)
                            {
                                case 1:
                                    if (!Class981.bool_1 || !smethod_3(A_0, qQSQ, class3, i - 2))
                                    {
                                        break;
                                    }
                                    bool_0 = true;
                                    return;

                                case 2:
                                    goto Label_0091;

                                case 3:
                                    if (!Class981.bool_3 || !smethod_5(A_0, qQSQ, class3, i - 2, 3))
                                    {
                                        break;
                                    }
                                    bool_0 = true;
                                    return;

                                case 4:
                                    if (Class981.bool_3 && smethod_5(A_0, qQSQ, class3, i - 2, 4))
                                    {
                                        bool_0 = true;
                                        return;
                                    }
                                    break;
                            }
                        }
                    }
                }
                continue;
            Label_0091:
                if (Class981.bool_2 && smethod_4(A_0, qQSQ, class3, i - 2))
                {
                    bool_0 = true;
                    return;
                }
                if (Class981.bool_3 && smethod_6(A_0, qQSQ, class3, i - 1))
                {
                    bool_0 = true;
                    return;
                }
            }
            for (int j = 0; j < A_0.Count; j++)
            {
                ArrayList list2 = (A_0[j] as Class398).QQSQ;
                if (list2 != null)
                {
                    smethod_1(list2);
                }
            }
        }

        private static bool smethod_2(Class438 A_0)
        {
            return false;
        }

        private static bool smethod_3(ArrayList A_0, ArrayList A_1, Class438 A_2, int A_3)
        {
            if (A_3 < 0)
            {
                return false;
            }
            Class443 class2 = A_1[0] as Class443;
            if (class2 == null)
            {
                return false;
            }
            Class504 class3 = class2.class445_0 as Class504;
            if (class3 == null)
            {
                return false;
            }
            if (class3.uint_0 != Class519.class604_0.uint_4)
            {
                return false;
            }
            Class445 class4 = class3.class445_0[0];
            Class443 class5 = A_0[A_3] as Class443;
            if (class5 == null)
            {
                return false;
            }
            Class504 class6 = class5.class445_0 as Class504;
            if (class6 == null)
            {
                return false;
            }
            if (class6.uint_0 != Class519.class604_0.uint_3)
            {
                return false;
            }
            Class445 class7 = class6.class445_0[0];
            if (class4.method_0(class7))
            {
                Class426 class8 = new Class426(class7);
                ArrayList qQSQ = A_2.QQSQ;
                if (qQSQ != null)
                {
                    for (int i = 0; i < qQSQ.Count; i++)
                    {
                        class8.QQSR(qQSQ[i] as Class398);
                    }
                }
                Class689.smethod_5(class5, class8);
                Class689.smethod_2(A_0, A_3, 3);
                A_0.Insert(A_3, class8);
            }
            else
            {
                if (A_3 == 0)
                {
                    return false;
                }
                Class399 class9 = A_0[A_3 - 1] as Class399;
                if (class9 == null)
                {
                    return false;
                }
                Class445 class10 = class9.class445_0;
                if (!class4.method_0(class10))
                {
                    return false;
                }
                Class445 class11 = class9.class445_1;
                if (!class7.method_0(class11))
                {
                    return false;
                }
                Class452 class12 = class10 as Class452;
                if (class12 != null)
                {
                    Class525.bool_1[class12.ushort_0] = true;
                }
                Class426 class13 = new Class426(class7);
                ArrayList list2 = A_2.QQSQ;
                if (list2 != null)
                {
                    for (int j = 0; j < list2.Count; j++)
                    {
                        class13.QQSR(list2[j] as Class398);
                    }
                }
                Class689.smethod_5(class9, class13);
                Class689.smethod_2(A_0, A_3 - 1, 4);
                A_0.Insert(A_3 - 1, class13);
            }
            return true;
        }

        private static bool smethod_4(ArrayList A_0, ArrayList A_1, Class438 A_2, int A_3)
        {
            Class418 class2 = A_1[0] as Class418;
            if (class2 == null)
            {
                return false;
            }
            Class470 class3 = class2.class445_0 as Class470;
            if (class3 == null)
            {
                return false;
            }
            if (class3.enum31_0 != Enum31.const_1)
            {
                return false;
            }
            if (!(class3.class445_1 is Class496))
            {
                return false;
            }
            Class452 class5 = class3.class445_0 as Class452;
            if (class5 == null)
            {
                return false;
            }
            ArrayList qQSQ = class2.QQSQ;
            if (qQSQ == null)
            {
                return false;
            }
            if (qQSQ.Count != 1)
            {
                return false;
            }
            Class443 class6 = qQSQ[0] as Class443;
            if (class6 == null)
            {
                return false;
            }
            Class487 class7 = class6.class445_0 as Class487;
            if (class7 == null)
            {
                return false;
            }
            Class452 class8 = class7.class445_0 as Class452;
            if (class8 == null)
            {
                return false;
            }
            if (class5.ushort_0 != class8.ushort_0)
            {
                return false;
            }
            Class399 class9 = A_0[A_3] as Class399;
            if (class9 == null)
            {
                return false;
            }
            Class452 class10 = class9.class445_0 as Class452;
            if (class10 == null)
            {
                return false;
            }
            if (class5.ushort_0 != class10.ushort_0)
            {
                return false;
            }
            Class525.bool_1[class5.ushort_0] = true;
            Class439 class11 = new Class439(class5, class9.class445_1);
            ArrayList list2 = A_2.QQSQ;
            if (list2 != null)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    class11.QQSR(list2[i] as Class398);
                }
            }
            Class689.smethod_5(class9, class11);
            Class689.smethod_2(A_0, A_3, 3);
            A_0.Insert(A_3, class11);
            return true;
        }

        private static bool smethod_5(ArrayList A_0, ArrayList A_1, Class438 A_2, int A_3, int A_4)
        {
            Class399 class2 = A_1[0] as Class399;
            if (class2 == null)
            {
                return false;
            }
            Class452 class3 = class2.class445_0 as Class452;
            if (class3 == null)
            {
                return false;
            }
            if ((A_4 != 3) && !(A_1[1] is Class419))
            {
                return false;
            }
            Class399 class5 = A_0[A_3] as Class399;
            if (class5 == null)
            {
                return false;
            }
            Class452 class6 = class5.class445_0 as Class452;
            if (class6 == null)
            {
                return false;
            }
            Class574.Class636 class7 = Class546.class574_0.arrayList_0[Class519.class528_0.int_7 + class6.ushort_0] as Class574.Class636;
            if ((class7.enum11_0 != Enum11.const_38) || (class7.int_1 != Class519.class604_0.int_9))
            {
                return false;
            }
            Class487 class8 = class5.class445_1 as Class487;
            if (class8 == null)
            {
                return false;
            }
            if (class8.class445_1 != null)
            {
                return false;
            }
            ArrayList qQSQ = A_2.QQSQ;
            if (qQSQ == null)
            {
                return false;
            }
            if (qQSQ.Count == 0)
            {
                return false;
            }
            if (qQSQ.Count <= 2)
            {
                if (qQSQ.Count == 2)
                {
                    Class425 class9 = qQSQ[1] as Class425;
                    if ((class9 != null) && !class9.bool_0)
                    {
                        return false;
                    }
                }
                Class441 class10 = qQSQ[0] as Class441;
                if (class10 == null)
                {
                    return false;
                }
                Class470 class11 = class10.class445_0 as Class470;
                if (class11 == null)
                {
                    return false;
                }
                Class487 class12 = class11.class445_0 as Class487;
                if (class12 == null)
                {
                    return false;
                }
                if (class12.class445_1 != null)
                {
                    return false;
                }
                Class452 class13 = class12.class445_0 as Class452;
                if (class13 == null)
                {
                    return false;
                }
                if (class6.ushort_0 != class13.ushort_0)
                {
                    return false;
                }
                ArrayList list2 = class10.QQSQ;
                if (list2 == null)
                {
                    return false;
                }
                if (list2.Count < 2)
                {
                    return false;
                }
                Class399 class14 = list2[0] as Class399;
                if (class14 == null)
                {
                    return false;
                }
                Class452 class15 = class14.class445_0 as Class452;
                if (class15 == null)
                {
                    return false;
                }
                Class525.bool_1[class6.ushort_0] = true;
                Class525.bool_1[class3.ushort_0] = true;
                if (Class981.bool_4)
                {
                    Class525.bool_1[class15.ushort_0] = true;
                }
                Class416 class16 = new Class416(class15.ushort_0, class8.class445_0);
                for (int j = 1; j < list2.Count; j++)
                {
                    class16.QQSR(list2[j] as Class398);
                }
                Class689.smethod_5(class5, class16);
                Class689.smethod_2(A_0, A_3, 3);
                A_0.Insert(A_3, class16);
                return true;
            }
            Class417 class17 = qQSQ[0] as Class417;
            if (class17 == null)
            {
                return false;
            }
            Class419 class18 = qQSQ[qQSQ.Count - 1] as Class419;
            if (class18 == null)
            {
                return false;
            }
            if (class17.class398_0 != class18)
            {
                return false;
            }
            Class487 class19 = class18.class445_0 as Class487;
            if (class19 == null)
            {
                return false;
            }
            if (class19.class445_1 != null)
            {
                return false;
            }
            Class452 class20 = class19.class445_0 as Class452;
            if (class20 == null)
            {
                return false;
            }
            if (class6.ushort_0 != class20.ushort_0)
            {
                return false;
            }
            Class399 class21 = qQSQ[1] as Class399;
            if (class18.class398_0 != class21)
            {
                return false;
            }
            Class452 class22 = class21.class445_0 as Class452;
            if (class22 == null)
            {
                return false;
            }
            Class525.bool_1[class6.ushort_0] = true;
            Class525.bool_1[class3.ushort_0] = true;
            if (Class981.bool_4)
            {
                Class525.bool_1[class22.ushort_0] = true;
            }
            Class416 class23 = new Class416(class22.ushort_0, class8.class445_0);
            for (int i = 2; i < (qQSQ.Count - 1); i++)
            {
                class23.QQSR(qQSQ[i] as Class398);
            }
            Class689.smethod_5(class5, class23);
            Class689.smethod_2(A_0, A_3, 3);
            A_0.Insert(A_3, class23);
            return true;
        }

        private static bool smethod_6(ArrayList A_0, ArrayList A_1, Class438 A_2, int A_3)
        {
            Class418 class2 = A_1[0] as Class418;
            if (class2 != null)
            {
                Class470 class3 = class2.class445_0 as Class470;
                if (class3 == null)
                {
                    return false;
                }
                Class490 class4 = class3.class445_0 as Class490;
                if (class4 == null)
                {
                    return false;
                }
                Class452 class5 = class4.class445_0 as Class452;
                if (class5 == null)
                {
                    return false;
                }
                ArrayList qQSQ = A_2.QQSQ;
                if (qQSQ == null)
                {
                    return false;
                }
                if (qQSQ.Count != 2)
                {
                    return false;
                }
                Class399 class6 = qQSQ[0] as Class399;
                if (class6 == null)
                {
                    return false;
                }
                Class452 class7 = class6.class445_0 as Class452;
                if (class7 == null)
                {
                    return false;
                }
                if (!class5.method_0(class7))
                {
                    return false;
                }
                Class574.Class636 class8 = Class546.class574_0.arrayList_0[Class519.class528_0.int_7 + class7.ushort_0] as Class574.Class636;
                if ((class8.enum11_0 == Enum11.const_38) && (class8.int_1 == Class519.class604_0.int_9))
                {
                    Class487 class9 = class6.class445_1 as Class487;
                    if (class9 == null)
                    {
                        return false;
                    }
                    if (class9.class445_1 != null)
                    {
                        return false;
                    }
                    Class445 class10 = class9.class445_0;
                    Class441 class11 = qQSQ[1] as Class441;
                    if (class11 == null)
                    {
                        return false;
                    }
                    Class470 class12 = class11.class445_0 as Class470;
                    if (class12 == null)
                    {
                        return false;
                    }
                    Class487 class13 = class12.class445_0 as Class487;
                    if (class13 == null)
                    {
                        return false;
                    }
                    if (class13.class445_1 != null)
                    {
                        return false;
                    }
                    Class452 class14 = class13.class445_0 as Class452;
                    if (class14 == null)
                    {
                        return false;
                    }
                    if (class7.ushort_0 != class14.ushort_0)
                    {
                        return false;
                    }
                    ArrayList list2 = class11.QQSQ;
                    if (list2 == null)
                    {
                        return false;
                    }
                    if (list2.Count < 3)
                    {
                        return false;
                    }
                    class2 = list2[0] as Class418;
                    if (class2 == null)
                    {
                        return false;
                    }
                    class12 = class2.class445_0 as Class470;
                    if (class12 == null)
                    {
                        return false;
                    }
                    Class489 class15 = class12.class445_0 as Class489;
                    if (class15 == null)
                    {
                        return false;
                    }
                    Class443 class16 = list2[1] as Class443;
                    if (class16 == null)
                    {
                        return false;
                    }
                    Class489 class17 = class16.class445_0 as Class489;
                    if (!class17.method_0(class15))
                    {
                        return false;
                    }
                    class6 = list2[2] as Class399;
                    if (class6 == null)
                    {
                        return false;
                    }
                    Class452 class18 = class6.class445_0 as Class452;
                    if (class18 == null)
                    {
                        return false;
                    }
                    if (!(class6.class445_1 is Class512))
                    {
                        return false;
                    }
                    Class525.bool_1[class7.ushort_0] = true;
                    if (Class981.bool_4)
                    {
                        Class525.bool_1[class18.ushort_0] = true;
                    }
                    Class416 class20 = new Class416(class18.ushort_0, class10);
                    for (int i = 3; i < list2.Count; i++)
                    {
                        class20.QQSR(list2[i] as Class398);
                    }
                    Class689.smethod_5(A_2, class20);
                    Class689.smethod_2(A_0, A_3, 2);
                    A_0.Insert(A_3, class20);
                    return true;
                }
            }
            return false;
        }
    }
}

