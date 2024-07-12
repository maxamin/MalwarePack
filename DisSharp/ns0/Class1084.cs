namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1084
    {
        private static ArrayList arrayList_0;
        private static ArrayList arrayList_1 = new ArrayList();
        private static bool bool_0;
        private static bool bool_1;
        private static bool bool_2;
        private static bool bool_3;
        private static Class1064 class1064_0 = new Class1064();
        private static Class1064 class1064_1 = new Class1064();
        private static Class398 class398_0;
        private static Class445 class445_0;
        internal static Class893 class893_0 = new Class893(40);
        internal static Class893 class893_1 = new Class893(40);
        private static int int_0;
        private static int int_1;
        private static int int_2;

        internal static void smethod_0()
        {
            bool_1 = false;
            try
            {
                int num = 0;
                bool flag = true;
                goto Label_0021;
            Label_000C:
                num++;
                if (flag && (num < 250))
                {
                    goto Label_0021;
                }
                return;
            Label_001D:
                flag = false;
                goto Label_000C;
            Label_0021:
                bool_0 = false;
                smethod_1(Class536.arrayList_0);
                if (bool_0)
                {
                    goto Label_000C;
                }
                goto Label_001D;
            }
            catch
            {
                Class526.bool_1 = true;
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                (A_0[i] as Class398).ushort_1 = (ushort) i;
            }
            int num2 = 0;
            int num3 = A_0.Count - 1;
            while (num2 < num3)
            {
                Class398 class2 = A_0[num2] as Class398;
                if (class2.Type == Enum26.const_34)
                {
                    int_0 = num2;
                    smethod_3(A_0, class2, num2);
                    return;
                }
                if (class2.Type == Enum26.const_19)
                {
                    int_0 = num2;
                    if (smethod_7(A_0, class2, num2))
                    {
                        return;
                    }
                }
                num2++;
            }
            for (int j = 0; j < A_0.Count; j++)
            {
                ArrayList qQSQ = (A_0[j] as Class398).QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        internal static void smethod_10(ArrayList A_0, Class398 A_1, Class445 A_2, int A_3, int A_4)
        {
            bool_1 = true;
            smethod_2(A_0);
            class398_0 = A_1;
            class445_0 = A_2;
            bool_2 = true;
            int_0 = A_3;
            smethod_8();
            smethod_11(arrayList_0[A_3 + A_4] as Class398);
        }

        private static void smethod_11(Class398 A_0)
        {
            Class417 class2 = A_0 as Class417;
            if (class2 != null)
            {
                class2.class398_0.method_1(class2);
                if (smethod_18(class2.class398_0))
                {
                    int_1 = class2.class398_0.ushort_1;
                }
                else
                {
                    int_1 = -1;
                }
            }
            else
            {
                int_1 = -1;
            }
            smethod_12();
            smethod_14(class2);
            smethod_16();
            smethod_15();
        }

        private static void smethod_12()
        {
            int num = 0xf4240;
            for (int i = 0; i < arrayList_1.Count; i++)
            {
                Class1064 class2 = arrayList_1[i] as Class1064;
                if (class2.int_0 < num)
                {
                    num = class2.int_0;
                }
            }
            int num3 = int_0 - 1;
            for (int j = num3; j >= 0; j--)
            {
                Class419 class3 = arrayList_0[j] as Class419;
                if (class3 == null)
                {
                    return;
                }
                Class470 class4 = class3.class445_0 as Class470;
                if (class4 == null)
                {
                    return;
                }
                if (class4.enum31_0 == Enum31.const_0)
                {
                    return;
                }
                if (!(class4.class445_1 is Class447))
                {
                    return;
                }
                Class398 class6 = class3.class398_0;
                if (!smethod_18(class6))
                {
                    return;
                }
                if (class6.ushort_1 < int_0)
                {
                    return;
                }
                if (class6.ushort_1 > num)
                {
                    return;
                }
                smethod_13(class6.ushort_1);
                class6.method_1(class3);
                int_0--;
            }
        }

        private static void smethod_13(int A_0)
        {
            for (int i = A_0; i < arrayList_0.Count; i++)
            {
                Class398 class2 = arrayList_0[i] as Class398;
                if (class2.Type == Enum26.const_19)
                {
                    Class419 class3 = class2 as Class419;
                    Class470 class4 = class3.class445_0 as Class470;
                    if (class4 == null)
                    {
                        smethod_5(class3);
                    }
                    else
                    {
                        Class447 class5 = class4.class445_1 as Class447;
                        if (class5 == null)
                        {
                            return;
                        }
                        if (class4.enum31_0 == Enum31.const_0)
                        {
                            smethod_5(class3);
                        }
                        else
                        {
                            if (class4.enum31_0 == Enum31.const_1)
                            {
                                smethod_6(i + 1, class5.int_0);
                                class3.class398_0.method_1(class3);
                                return;
                            }
                            smethod_13(class3.class398_0.ushort_1);
                        }
                    }
                }
                else
                {
                    if (class2.Type != Enum26.const_34)
                    {
                        Class417 class7 = class2 as Class417;
                        if (class7 != null)
                        {
                            class7.class398_0.method_1(class7);
                        }
                        return;
                    }
                    Class435 class6 = class2 as Class435;
                    smethod_4(class6);
                }
            }
        }

        private static void smethod_14(Class417 A_0)
        {
            bool_3 = false;
            if (int_1 != -1)
            {
                Class398 class2 = A_0.class398_0;
                for (int i = 0; i < int_0; i++)
                {
                    if (arrayList_0[i] == class2)
                    {
                        int_1 = -1;
                        bool_3 = true;
                        int_2 = i;
                        return;
                    }
                }
            }
        }

        private static void smethod_15()
        {
            if (bool_3)
            {
                Class442 class2 = new Class442();
                int num = arrayList_0.Count - int_2;
                for (int i = int_2; i < arrayList_0.Count; i++)
                {
                    class2.QQSR(arrayList_0[i] as Class398);
                }
                Class689.smethod_2(arrayList_0, int_2, num);
                arrayList_0.Insert(int_2, class2);
            }
        }

        private static void smethod_16()
        {
            int num14;
            bool flag = true;
            for (int i = 1; i < arrayList_1.Count; i++)
            {
                Class1064 class2 = arrayList_1[i] as Class1064;
                object obj2 = arrayList_0[class2.int_0 - 1];
                if (obj2 is Class417)
                {
                    Class398 class3 = (obj2 as Class417).class398_0;
                    if (((class3 != null) && (class3.ushort_1 != int_1)) && (int_1 != -1))
                    {
                        flag = false;
                    }
                }
            }
            Class1064 class4 = null;
            bool flag2 = false;
            for (int j = 0; j < arrayList_1.Count; j++)
            {
                Class1064 class5 = arrayList_1[j] as Class1064;
                if (class5.int_0 == int_1)
                {
                    class5.enum71_0 = Enum71.const_1;
                    class4 = class5;
                    flag2 = true;
                    break;
                }
            }
            if (!flag2 && (int_1 != -1))
            {
                Class1064 class6 = new Class1064(int_1, 0) {
                    enum71_0 = Enum71.const_1
                };
                class4 = class6;
                arrayList_1.Add(class6);
            }
            bool flag3 = false;
            if (flag && (flag2 || (int_1 == -1)))
            {
                flag3 = true;
            }
            Class1063.smethod_1(arrayList_1);
            for (int k = 0; k < arrayList_1.Count; k++)
            {
                Class1064 class7 = arrayList_1[k] as Class1064;
                Class892.smethod_1(class7.class893_0);
            }
            class1064_1.int_0 = -1;
            class1064_0.int_0 = -1;
            int count = arrayList_1.Count;
            Class1064 class8 = arrayList_1[0] as Class1064;
            for (int m = 1; m < arrayList_1.Count; m++)
            {
                Class1064 class12;
                Class1064 class9 = arrayList_1[m] as Class1064;
                object obj3 = arrayList_0[class9.int_0 - 1];
                if (obj3 is Class437)
                {
                    class8.bool_1 = true;
                    goto Label_02FD;
                }
                if (obj3 is Class428)
                {
                    class8.bool_0 = true;
                    goto Label_02FD;
                }
                Class417 class10 = obj3 as Class417;
                if (class10 == null)
                {
                    class8.class1064_0 = class1064_0;
                    goto Label_02FD;
                }
                Class398 class11 = class10.class398_0;
                if (class8.class1064_0 != null)
                {
                    class11.method_1(class10);
                }
                int num5 = class11.ushort_1;
                if (num5 == int_1)
                {
                    class8.class1064_0 = class4;
                    goto Label_02FD;
                }
                if (!smethod_18(class11))
                {
                    goto Label_02FD;
                }
                bool flag4 = false;
                for (int num6 = 0; num6 < arrayList_1.Count; num6++)
                {
                    class12 = arrayList_1[num6] as Class1064;
                    if (num5 == class12.int_0)
                    {
                        goto Label_027A;
                    }
                }
                goto Label_0286;
            Label_027A:
                class8.class1064_0 = class12;
                flag4 = true;
            Label_0286:
                if (!flag4)
                {
                    if (class1064_0.int_0 == -1)
                    {
                        class8.class1064_0 = class1064_0;
                        class1064_0.int_0 = num5;
                        class1064_0.class398_0 = class11;
                    }
                    else if (class1064_0.int_0 == num5)
                    {
                        class8.class1064_0 = class1064_0;
                    }
                    else
                    {
                        class8.class1064_0 = class1064_1;
                        class1064_1.int_0 = num5;
                        class1064_1.class398_0 = class11;
                    }
                }
            Label_02FD:
                class8.int_1 = class9.int_0 - 1;
                class8 = class9;
            }
            Class1064 class13 = arrayList_1[arrayList_1.Count - 1] as Class1064;
            if (class1064_1.int_0 == -1)
            {
                if (bool_1)
                {
                    if (flag)
                    {
                        class13.int_1 = arrayList_0.Count - 1;
                        class13.enum71_1 = Enum71.const_2;
                    }
                    else
                    {
                        class13.enum71_1 = Enum71.const_3;
                        smethod_20(class13);
                    }
                }
                else if (smethod_17(class1064_0))
                {
                    class1064_0.enum71_0 = Enum71.const_2;
                    class13.int_1 = class1064_0.int_0 - 1;
                    if (class13.int_1 < 0)
                    {
                        class13.int_1 = arrayList_0.Count - 1;
                    }
                    class13.enum71_1 = Enum71.const_2;
                    flag = false;
                }
                else if (flag)
                {
                    class1064_0.enum71_0 = Enum71.const_2;
                    class13.int_1 = class1064_0.int_0 - 1;
                    if (class13.int_1 < 0)
                    {
                        class13.int_1 = arrayList_0.Count - 1;
                    }
                    class13.enum71_1 = Enum71.const_2;
                }
                else
                {
                    class1064_0.enum71_0 = Enum71.const_3;
                    class13.enum71_1 = Enum71.const_3;
                    smethod_20(class13);
                }
            }
            else
            {
                flag = false;
                if (smethod_17(class1064_0))
                {
                    if (smethod_17(class1064_1))
                    {
                        if (class1064_0.int_0 < class1064_1.int_0)
                        {
                            class1064_0.enum71_0 = Enum71.const_2;
                            class1064_1.enum71_0 = Enum71.const_3;
                            class13.int_1 = class1064_0.int_0 - 1;
                            if ((arrayList_0[class1064_0.int_0 - 1] as Class398).Type == Enum26.const_16)
                            {
                                class13.enum71_1 = Enum71.const_3;
                            }
                        }
                        else
                        {
                            class1064_0.enum71_0 = Enum71.const_3;
                            class1064_1.enum71_0 = Enum71.const_2;
                            class13.int_1 = class1064_1.int_0 - 1;
                            if ((arrayList_0[class1064_1.int_0 - 1] as Class398).Type == Enum26.const_16)
                            {
                                class13.enum71_1 = Enum71.const_3;
                            }
                        }
                    }
                    else
                    {
                        class1064_0.enum71_0 = Enum71.const_2;
                        class1064_1.enum71_0 = Enum71.const_3;
                        class13.int_1 = class1064_0.int_0 - 1;
                    }
                }
                else
                {
                    class1064_0.enum71_0 = Enum71.const_3;
                    class1064_1.enum71_0 = Enum71.const_2;
                    class13.int_1 = class1064_1.int_0 - 1;
                }
            }
            ArrayList list = new ArrayList();
            Class433 class14 = new Class433(class445_0, list);
            int num7 = arrayList_1.Count - 1;
            for (int n = 0; n < arrayList_1.Count; n++)
            {
                Class1064 class15 = arrayList_1[n] as Class1064;
                if ((!flag || (n != num7)) || (((num7 == 0) || bool_1) || flag3))
                {
                    int num9 = (class15.int_1 - class15.int_0) + 1;
                    int num10 = class15.int_0;
                    ArrayList list2 = new ArrayList();
                    for (int num11 = 0; num11 < (num9 - 1); num11++)
                    {
                        list2.Add(arrayList_0[num10 + num11]);
                    }
                    int num12 = (num10 + num9) - 1;
                    Class398 class16 = arrayList_0[num12] as Class398;
                    if ((class16.Type == Enum26.const_16) && (class15.class1064_0 != null))
                    {
                        Class417 class17 = class16 as Class417;
                        class17.class398_0.method_1(class17);
                        class16 = class17.method_7();
                    }
                    arrayList_0[num12] = class16;
                    if ((class16.Type == Enum26.const_28) && !class15.bool_0)
                    {
                        Class428 class18 = class16 as Class428;
                        if (class18.class445_0 != null)
                        {
                            list2.Add(class16);
                        }
                    }
                    else
                    {
                        list2.Add(class16);
                    }
                    Enum27 enum2 = Enum27.const_0;
                    if (class15.enum71_0 == Enum71.const_1)
                    {
                        enum2 = Enum27.const_1;
                    }
                    Enum29 enum3 = Enum29.const_2;
                    int index = 0;
                    if (!class15.bool_1 && !class15.bool_0)
                    {
                        if (bool_1)
                        {
                            enum3 = Enum29.const_2;
                        }
                        else if (n < num7)
                        {
                            Class1064 class19 = class15.class1064_0;
                            if (class19 == null)
                            {
                                enum3 = Enum29.const_4;
                            }
                            else
                            {
                                switch (class19.enum71_0)
                                {
                                    case Enum71.const_0:
                                        enum3 = Enum29.const_0;
                                        index = arrayList_1.IndexOf(class19);
                                        break;

                                    case Enum71.const_1:
                                        enum3 = Enum29.const_1;
                                        break;

                                    case Enum71.const_2:
                                        enum3 = Enum29.const_2;
                                        break;

                                    case Enum71.const_3:
                                        enum3 = Enum29.const_3;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            switch (class15.enum71_1)
                            {
                                case Enum71.const_2:
                                    enum3 = Enum29.const_2;
                                    break;

                                case Enum71.const_3:
                                    enum3 = Enum29.const_3;
                                    break;
                            }
                        }
                    }
                    else
                    {
                        enum3 = Enum29.const_4;
                    }
                    bool flag5 = true;
                    if ((list2.Count > 0) && (list2[list2.Count - 1] is Class408))
                    {
                        enum3 = Enum29.const_4;
                        flag5 = false;
                    }
                    if ((flag && !class15.bool_0) && (!class15.bool_1 && flag5))
                    {
                        Class434 class21 = new Class434(class14, list2, class15.class893_0.method_2(), Enum27.const_0, Enum29.const_2, 0);
                        list.Add(class21);
                    }
                    else
                    {
                        Class434 class22 = new Class434(class14, list2, class15.class893_0.method_2(), enum2, enum3, index);
                        list.Add(class22);
                    }
                }
            }
            if (num7 == 0)
            {
                Class1064 class23 = arrayList_1[0] as Class1064;
                list.Add(new Class434(class14, new ArrayList(), class23.class893_0.method_2(), Enum27.const_1, Enum29.const_2, 0));
                num14 = (class23.int_1 - int_0) + 1;
                (arrayList_0[class23.int_0] as Class398).arrayList_0 = null;
            }
            else if ((flag && !bool_1) && !flag3)
            {
                num14 = ((arrayList_1[arrayList_1.Count - 2] as Class1064).int_1 - int_0) + 1;
                for (int num15 = 0; num15 < (arrayList_1.Count - 1); num15++)
                {
                    Class1064 class24 = arrayList_1[num15] as Class1064;
                    (arrayList_0[class24.int_0] as Class398).arrayList_0 = null;
                }
            }
            else
            {
                num14 = ((arrayList_1[arrayList_1.Count - 1] as Class1064).int_1 - int_0) + 1;
                for (int num16 = 0; num16 < arrayList_1.Count; num16++)
                {
                    Class1064 class25 = arrayList_1[num16] as Class1064;
                    (arrayList_0[class25.int_0] as Class398).arrayList_0 = null;
                }
            }
            Class689.smethod_5(class398_0, class14);
            Class689.smethod_2(arrayList_0, int_0, num14);
            arrayList_0.Insert(int_0, class14);
        }

        private static bool smethod_17(Class1064 A_0)
        {
            object obj2 = A_0.class398_0;
            if (obj2 != null)
            {
                for (int i = 0; i < arrayList_0.Count; i++)
                {
                    if (arrayList_0[i] == obj2)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool smethod_18(object A_0)
        {
            for (int i = 0; i < arrayList_0.Count; i++)
            {
                if (arrayList_0[i] == A_0)
                {
                    return true;
                }
            }
            return false;
        }

        private static int smethod_19(int A_0)
        {
            for (int i = A_0; i < arrayList_0.Count; i++)
            {
                Class398 class2 = arrayList_0[i] as Class398;
                if (class2.arrayList_0 != null)
                {
                    ArrayList list = class2.arrayList_0;
                    for (int j = 0; j < list.Count; j++)
                    {
                        Class398 class3 = arrayList_0[j] as Class398;
                        if (class3.ushort_1 < int_0)
                        {
                            return i;
                        }
                    }
                }
            }
            return (arrayList_0.Count - 1);
        }

        private static void smethod_2(ArrayList A_0)
        {
            arrayList_1.Clear();
            arrayList_0 = A_0;
            bool_2 = false;
            int_1 = -1;
        }

        private static void smethod_20(Class1064 A_0)
        {
            int num = A_0.int_0;
            while ((arrayList_0[num] as Class398).Type != Enum26.const_16)
            {
                if (num == (arrayList_0.Count - 1))
                {
                    break;
                }
                num++;
            }
            A_0.int_1 = num;
        }

        private static void smethod_21(Class1064 A_0)
        {
            int num = A_0.int_0;
            while ((arrayList_0[num] as Class398).Type != Enum26.const_16)
            {
                if (num == (arrayList_0.Count - 1))
                {
                    break;
                }
                num++;
            }
            if (num < (arrayList_0.Count - 1))
            {
                Class417 class2 = arrayList_0[num] as Class417;
                if (class2.class398_0.ushort_1 == class1064_0.int_0)
                {
                    A_0.enum71_0 = class1064_0.enum71_0;
                }
                else
                {
                    A_0.enum71_0 = class1064_1.enum71_0;
                }
            }
            else
            {
                A_0.enum71_0 = Enum71.const_3;
            }
            A_0.int_1 = num;
        }

        private static void smethod_22(Class1064 A_0)
        {
            Class398 class2 = arrayList_0[A_0.int_0] as Class398;
            ArrayList list = class2.arrayList_0;
            if (list != null)
            {
                while (true)
                {
                    bool flag = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        Class398 class3 = list[i] as Class398;
                        int num2 = class3.ushort_1;
                        if (((num2 >= 0) && (num2 < arrayList_0.Count)) && (class3 == arrayList_0[num2]))
                        {
                            list.Remove(class3);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        if (list.Count == 0)
                        {
                            class2.arrayList_0 = null;
                        }
                        return;
                    }
                }
            }
        }

        private static void smethod_3(ArrayList A_0, Class398 A_1, int A_2)
        {
            smethod_2(A_0);
            Class398 class2 = A_1;
            class398_0 = A_1;
            int num = A_2;
            while (class2.Type != Enum26.const_16)
            {
                if (class2.Type == Enum26.const_28)
                {
                    break;
                }
                if (class2.Type == Enum26.const_34)
                {
                    smethod_4(class2 as Class435);
                }
                if (class2.Type == Enum26.const_19)
                {
                    smethod_5(class2 as Class419);
                }
                num++;
                class2 = arrayList_0[num] as Class398;
            }
            smethod_11(class2);
            bool_0 = true;
        }

        private static void smethod_4(Class435 A_0)
        {
            int num = 0;
            if (A_0.class445_0.Type == Enum17.const_9)
            {
                Class463 class2 = A_0.class445_0 as Class463;
                if (!bool_2)
                {
                    class445_0 = class2.class445_0;
                    bool_2 = true;
                }
                if (class2.enum1_0 == Enum1.const_11)
                {
                    num = (class2.class445_1 as Class447).int_0;
                }
                else if (class2.enum1_0 == Enum1.const_0)
                {
                    num = -1 * (class2.class445_1 as Class447).int_0;
                }
            }
            else if (!bool_2)
            {
                class445_0 = A_0.class445_0;
                bool_2 = true;
            }
            ArrayList list = A_0.arrayList_1;
            for (int i = 0; i < list.Count; i++)
            {
                Class398 class3 = list[i] as Class398;
                smethod_6(class3.ushort_1, i + num);
                class3.method_1(A_0);
            }
        }

        private static void smethod_5(Class419 A_0)
        {
            Class470 class2 = A_0.class445_0 as Class470;
            if (class2 != null)
            {
                if (!bool_2)
                {
                    class445_0 = class2.class445_0;
                    bool_2 = true;
                }
                if (class2.class445_1.Type == Enum17.const_22)
                {
                    smethod_6(A_0.class398_0.ushort_1, (class2.class445_1 as Class447).int_0);
                }
            }
            else
            {
                smethod_6(A_0.class398_0.ushort_1, 0);
            }
        }

        private static void smethod_6(int A_0, int A_1)
        {
            for (int i = 0; i < arrayList_1.Count; i++)
            {
                Class1064 class2 = arrayList_1[i] as Class1064;
                if (class2.int_0 == A_0)
                {
                    class2.class893_0.method_1(A_1);
                    return;
                }
            }
            arrayList_1.Add(new Class1064(A_0, A_1));
        }

        private static bool smethod_7(ArrayList A_0, Class398 A_1, int A_2)
        {
            smethod_2(A_0);
            Class398 class2 = A_1;
            class398_0 = A_1;
            class893_0.method_0();
            class893_1.method_0();
            int num = A_2;
            int num2 = arrayList_0.Count - 1;
            while (true)
            {
                if ((class2.Type == Enum26.const_16) || (class2.Type == Enum26.const_28))
                {
                    break;
                }
                if (num == num2)
                {
                    return false;
                }
                if (class2.Type != Enum26.const_19)
                {
                    if (class2.Type != Enum26.const_34)
                    {
                        return false;
                    }
                    Class445 class7 = (class2 as Class435).class445_0;
                    if (class7.Type == Enum17.const_9)
                    {
                        if (!(class7 as Class463).class445_0.method_0(class445_0))
                        {
                            return false;
                        }
                    }
                    else if (!class7.method_0(class445_0))
                    {
                        return false;
                    }
                    smethod_8();
                    smethod_9(class2, num);
                    return true;
                }
                Class419 class3 = class2 as Class419;
                Class470 class4 = class3.class445_0 as Class470;
                if (class4 == null)
                {
                    return false;
                }
                if (class4.enum31_0 != Enum31.const_0)
                {
                    return false;
                }
                if (bool_2)
                {
                    if (!class4.class445_0.method_0(class445_0))
                    {
                        return false;
                    }
                    if (class3.arrayList_0 != null)
                    {
                        return false;
                    }
                }
                else
                {
                    class445_0 = class4.class445_0;
                    bool_2 = true;
                }
                Class447 class5 = class4.class445_1 as Class447;
                if (class5 == null)
                {
                    return false;
                }
                Class398 class6 = class3.class398_0;
                if (!smethod_18(class6))
                {
                    return false;
                }
                class893_1.method_1(class5.int_0);
                class893_0.method_1(class6.ushort_1);
                num++;
                class2 = arrayList_0[num] as Class398;
            }
            if (class893_0.int_1 < 2)
            {
                return false;
            }
            smethod_8();
            smethod_11(class2);
            bool_0 = true;
            return true;
        }

        private static void smethod_8()
        {
            for (int i = 0; i < class893_0.int_1; i++)
            {
                smethod_6(class893_0[i], class893_1[i]);
            }
        }

        private static void smethod_9(Class398 A_0, int A_1)
        {
            Class398 class2 = A_0;
            int num = A_1;
            while (class2.Type != Enum26.const_16)
            {
                if (class2.Type == Enum26.const_34)
                {
                    smethod_4(class2 as Class435);
                }
                if (class2.Type == Enum26.const_19)
                {
                    smethod_5(class2 as Class419);
                }
                num++;
                class2 = arrayList_0[num] as Class398;
            }
            smethod_11(class2);
            bool_0 = true;
        }
    }
}

