namespace ns0
{
    using System;
    using System.Collections;

    internal class Class980
    {
        private static ArrayList arrayList_0;
        private static bool bool_0;
        private static bool bool_1;
        private static Class398 class398_0;
        private static Class398 class398_1;
        private static Class398 class398_2;
        private static int int_0;
        private static int int_1;
        private static int int_2;

        internal static void smethod_0()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_0 = false;
                class398_0 = null;
                smethod_1(Class536.arrayList_0);
                if (!bool_0)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 150))
                {
                    return;
                }
            }
        }

        private static void smethod_1(ArrayList A_0)
        {
            arrayList_0 = A_0;
            int count = A_0.Count;
            for (int i = 0; i < count; i++)
            {
                (arrayList_0[i] as Class398).ushort_1 = (ushort) i;
            }
            int_1 = count - 1;
            while (int_1 > 0)
            {
                Class398 class2 = arrayList_0[int_1] as Class398;
                class398_1 = class2.QQRX;
                if (class398_1 == null)
                {
                    goto Label_0181;
                }
                bool flag = false;
                int num3 = class2.ushort_1;
                for (int k = 0; k < num3; k++)
                {
                    if (arrayList_0[k] == class398_1)
                    {
                        goto Label_0099;
                    }
                }
                goto Label_009B;
            Label_0099:
                flag = true;
            Label_009B:
                if (!flag)
                {
                    goto Label_013B;
                }
                bool flag2 = true;
                ArrayList list = class398_1.arrayList_0;
                if (list.Count > 1)
                {
                    for (int m = 0; m < list.Count; m++)
                    {
                        Class398 class3 = list[m] as Class398;
                        if (class3.Type == Enum26.const_34)
                        {
                            goto Label_012A;
                        }
                        if ((class3.ushort_1 > 0) && (class3.ushort_1 < count))
                        {
                            class3 = arrayList_0[class3.ushort_1 - 1] as Class398;
                            if (class3.Type == Enum26.const_34)
                            {
                                goto Label_012F;
                            }
                        }
                    }
                }
                goto Label_0132;
            Label_012A:
                flag2 = false;
                goto Label_0132;
            Label_012F:
                flag2 = false;
            Label_0132:
                if (!flag2)
                {
                    goto Label_0181;
                }
                smethod_2(class2, class398_1);
                bool_0 = true;
                return;
            Label_013B:
                if (class2.QQRX == class2)
                {
                    Class419 class4 = class2 as Class419;
                    if (class4 != null)
                    {
                        Class441 class5 = new Class441(class4.class445_0);
                        Class689.smethod_5(class4, class5);
                        class5.method_1(class4);
                        arrayList_0[int_1] = class5;
                    }
                }
            Label_0181:
                class398_0 = class2;
                int_1--;
            }
            for (int j = 0; j < count; j++)
            {
                ArrayList qQSQ = (A_0[j] as Class398).QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static void smethod_10(Class398 A_0, int A_1, int A_2)
        {
            for (int i = int_0; i <= (((int_1 - int_2) - A_2) + 1); i++)
            {
                A_0.QQSR(arrayList_0[i] as Class398);
            }
            int num2 = int_0 - A_1;
            Class398 class2 = arrayList_0[num2] as Class398;
            Class689.smethod_5(class2, A_0);
            Class689.smethod_2(arrayList_0, num2, (int_1 - num2) + 1);
            arrayList_0.Insert(num2, A_0);
        }

        private static void smethod_11(Class441 A_0)
        {
            Class436 class2;
            ArrayList list2;
            bool flag;
            ArrayList qQSQ = A_0.QQSQ;
            if ((qQSQ != null) && (qQSQ.Count != 0))
            {
                class2 = qQSQ[qQSQ.Count - 1] as Class436;
                if (class2 == null)
                {
                    return;
                }
                list2 = class2.arrayList_0;
                if (list2 != null)
                {
                    goto Label_0079;
                }
            }
            return;
        Label_0079:
            flag = false;
            for (int i = 0; i < list2.Count; i++)
            {
                Class398 class3 = list2[i] as Class398;
                bool_1 = false;
                smethod_12(qQSQ, class3);
                if (!bool_1)
                {
                    Class689.smethod_4(class3, class2, A_0);
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                return;
            }
            goto Label_0079;
        }

        private static void smethod_12(ArrayList A_0, Class398 A_1)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class398 class2 = A_0[i] as Class398;
                if (A_0[i] == A_1)
                {
                    bool_1 = true;
                    return;
                }
                if (class2.QQSQ != null)
                {
                    smethod_12(class2.QQSQ, A_1);
                    if (bool_1)
                    {
                        return;
                    }
                }
            }
        }

        private static void smethod_2(Class398 A_0, Class398 A_1)
        {
            int_0 = A_1.ushort_1;
            if (int_0 < int_1)
            {
                if (int_0 > 0)
                {
                    class398_2 = arrayList_0[int_0 - 1] as Class398;
                    if (A_0.Type == Enum26.const_16)
                    {
                        if (class398_2.Type == Enum26.const_16)
                        {
                            smethod_4(class398_2.QQRX.ushort_1);
                            class398_2.QQRX.method_1(class398_2);
                        }
                        else
                        {
                            smethod_6();
                        }
                    }
                    else if (class398_2.Type == Enum26.const_16)
                    {
                        smethod_3(class398_2.QQRX.ushort_1);
                        class398_2.QQRX.method_1(class398_2);
                    }
                    else
                    {
                        smethod_5();
                    }
                }
                else if (A_0.Type == Enum26.const_16)
                {
                    smethod_6();
                }
                else
                {
                    smethod_5();
                }
            }
        }

        private static void smethod_3(int A_0)
        {
            smethod_7();
            smethod_8(int_2);
            bool flag = false;
            Class399 class2 = null;
            Class399 class3 = null;
            if ((Class981.bool_0 && (int_0 >= 2)) && (class398_2.arrayList_0 == null))
            {
                class2 = arrayList_0[int_0 - 2] as Class399;
                if (class2 != null)
                {
                    class3 = arrayList_0[int_1 - int_2] as Class399;
                    if (class3 != null)
                    {
                        Class452 class4 = class2.class445_0 as Class452;
                        if (class4 != null)
                        {
                            Class452 class5 = class3.class445_0 as Class452;
                            if ((class5 != null) && (class4.ushort_0 == class5.ushort_0))
                            {
                                flag = true;
                            }
                        }
                    }
                }
            }
            if (flag && (int_0 >= (int_1 - int_2)))
            {
                flag = false;
            }
            if (flag)
            {
                Class415 class6 = new Class415 {
                    class445_0 = class2.method_8(),
                    class445_1 = smethod_9(true),
                    class445_2 = class3.method_8()
                };
                arrayList_0[int_1 - int_2] = class3.method_7();
                smethod_10(class6, 2, 1);
            }
            else
            {
                Class441 class7 = new Class441 {
                    class445_0 = smethod_9(false)
                };
                smethod_10(class7, 1, 0);
                smethod_11(class7);
            }
        }

        private static void smethod_4(int A_0)
        {
            int_2 = 1;
            smethod_8(1);
            Class442 class2 = new Class442();
            arrayList_0[int_1] = (arrayList_0[int_1] as Class417).method_7();
            smethod_10(class2, 1, 0);
        }

        private static void smethod_5()
        {
            smethod_7();
            smethod_8(int_2);
            Class409 class2 = new Class409 {
                class445_0 = smethod_9(false)
            };
            smethod_10(class2, 0, 0);
        }

        private static void smethod_6()
        {
            int_2 = 1;
            smethod_8(1);
            Class442 class2 = new Class442();
            arrayList_0[int_1] = (arrayList_0[int_1] as Class417).method_7();
            smethod_10(class2, 0, 0);
        }

        private static void smethod_7()
        {
        int num = int_1 - 1;
    bool flag = true;
    while (true)
    {
        if (num == 0)
        {
            flag = false;
        }
        else
        {
            Class398 class2 = arrayList_0[num] as Class398;
            if (class2.Type != Enum26.const_19)
            {
                flag = false;
            }
            else
            {
                Class398 qQRX = class2.QQRX;
                if (!ReferenceEquals(qQRX, class398_1) && (!ReferenceEquals(qQRX, class398_0) && (qQRX.ushort_1 <= num)))
                {
                    flag = false;
                }
                else
                {
                    num--;
                }
            }
        }
        if (!flag)
        {
            int_2 = int_1 - num;
            return;
        }
    }

        }

        private static void smethod_8(int A_0)
        {
            if (Class981.bool_5)
            {
                for (int i = int_0; i <= (int_1 - A_0); i++)
                {
                    Class417 class2 = arrayList_0[i] as Class417;
                    if ((class2 != null) && (class2.QQRX == class398_0))
                    {
                        arrayList_0[i] = class2.method_8();
                    }
                }
            }
        }

        private static Class445 smethod_9(bool A_0)
        {
            int num = (int_1 - int_2) + 1;
            Class445 class2 = Class931.smethod_0(arrayList_0, num, int_2);
            if (A_0)
            {
                for (int j = 0; j < int_2; j++)
                {
                    Class398 class3 = arrayList_0[int_1 - j] as Class398;
                    class3.QQRX.method_1(class3);
                }
                return class2;
            }
            for (int i = 0; i < (int_2 - 1); i++)
            {
                Class398 class4 = arrayList_0[int_1 - i] as Class398;
                class4.QQRX.method_1(class4);
            }
            Class436 class5 = (arrayList_0[num] as Class419).method_7();
            if (int_0 > 0)
            {
                Class398 class6 = arrayList_0[int_0 - 1] as Class398;
                class5.method_1(class6);
            }
            arrayList_0[num] = class5;
            return class2;
        }
    }
}

