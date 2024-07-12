namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1029
    {
        private static ArrayList arrayList_0;
        private static Class48 class48_0 = new Class48();
        private static Class640 class640_0;

        internal static void smethod_0(ArrayList A_0)
        {
            arrayList_0 = A_0;
            smethod_4();
            if (arrayList_0.Count > 1)
            {
                smethod_3(0, arrayList_0.Count - 1);
            }
        }

        private static int smethod_1(Class640 A_0, Class640 A_1)
        {
            Enum11 enum2 = A_0.enum11_0;
            Enum11 enum3 = A_1.enum11_0;
            if (enum2 == Enum11.const_16)
            {
                if (enum3 == Enum11.const_16)
                {
                    return 0;
                }
                return -1;
            }
            if (enum3 != Enum11.const_16)
            {
                if (enum2 == Enum11.const_1)
                {
                    if (enum3 == Enum11.const_1)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_1)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_17)
                {
                    if (enum3 == Enum11.const_17)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_17)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_2)
                {
                    if (enum3 == Enum11.const_2)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_2)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_18)
                {
                    if (enum3 == Enum11.const_18)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_18)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_3)
                {
                    if (enum3 == Enum11.const_3)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_3)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_19)
                {
                    if (enum3 == Enum11.const_19)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_19)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_4)
                {
                    if (enum3 == Enum11.const_4)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_4)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_20)
                {
                    if (enum3 == Enum11.const_20)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_20)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_5)
                {
                    if (enum3 == Enum11.const_5)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_5)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_21)
                {
                    if (enum3 == Enum11.const_21)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_21)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_6)
                {
                    if (enum3 == Enum11.const_6)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_6)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_22)
                {
                    if (enum3 == Enum11.const_22)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_22)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_7)
                {
                    if (enum3 == Enum11.const_7)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_7)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_23)
                {
                    if (enum3 == Enum11.const_23)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_23)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_8)
                {
                    if (enum3 == Enum11.const_8)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_8)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_24)
                {
                    if (enum3 == Enum11.const_24)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_24)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_9)
                {
                    if (enum3 == Enum11.const_9)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_9)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_25)
                {
                    if (enum3 == Enum11.const_25)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_25)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_10)
                {
                    if (enum3 == Enum11.const_10)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_10)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_26)
                {
                    if (enum3 == Enum11.const_26)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_26)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_11)
                {
                    if (enum3 == Enum11.const_11)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_11)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_27)
                {
                    if (enum3 == Enum11.const_27)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_27)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_12)
                {
                    if (enum3 == Enum11.const_12)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_12)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_28)
                {
                    if (enum3 == Enum11.const_28)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_28)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_13)
                {
                    if (enum3 == Enum11.const_13)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_13)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_29)
                {
                    if (enum3 == Enum11.const_29)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_29)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_14)
                {
                    if (enum3 == Enum11.const_14)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_14)
                {
                    return 1;
                }
                if ((enum2 == Enum11.const_38) && (A_0.int_0 == Class519.class604_0.int_2))
                {
                    if ((enum3 == Enum11.const_38) && (A_1.int_0 == Class519.class604_0.int_2))
                    {
                        return 0;
                    }
                    return -1;
                }
                if ((enum3 == Enum11.const_38) && (A_1.int_0 == Class519.class604_0.int_2))
                {
                    return 1;
                }
                if (enum2 == Enum11.const_30)
                {
                    if (enum3 == Enum11.const_30)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_30)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_32)
                {
                    if (enum3 == Enum11.const_32)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_32)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_31)
                {
                    if (enum3 == Enum11.const_31)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_31)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_33)
                {
                    if (enum3 == Enum11.const_33)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_33)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_34)
                {
                    if (enum3 == Enum11.const_34)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_34)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_35)
                {
                    if (enum3 == Enum11.const_35)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 != Enum11.const_35)
                {
                    if ((enum2 != Enum11.const_41) && (enum3 != Enum11.const_41))
                    {
                        return string.Compare(A_0.string_0, A_1.string_0);
                    }
                    if (enum2 != Enum11.const_41)
                    {
                        return -1;
                    }
                    if (enum3 == Enum11.const_41)
                    {
                        return smethod_2(A_0, A_1);
                    }
                }
            }
            return 1;
        }

        private static int smethod_2(Class640 A_0, Class640 A_1)
        {
            Enum11 enum2 = A_0.enum11_1;
            Enum11 enum3 = A_1.enum11_1;
            if (enum2 == Enum11.const_16)
            {
                if (enum3 == Enum11.const_16)
                {
                    return 0;
                }
                return -1;
            }
            if (enum3 != Enum11.const_16)
            {
                if (enum2 == Enum11.const_17)
                {
                    if (enum3 == Enum11.const_17)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_17)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_18)
                {
                    if (enum3 == Enum11.const_18)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_18)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_19)
                {
                    if (enum3 == Enum11.const_19)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_19)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_20)
                {
                    if (enum3 == Enum11.const_20)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_20)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_21)
                {
                    if (enum3 == Enum11.const_21)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_21)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_22)
                {
                    if (enum3 == Enum11.const_22)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_22)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_23)
                {
                    if (enum3 == Enum11.const_23)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_23)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_24)
                {
                    if (enum3 == Enum11.const_24)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_24)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_25)
                {
                    if (enum3 == Enum11.const_25)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_25)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_26)
                {
                    if (enum3 == Enum11.const_26)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_26)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_27)
                {
                    if (enum3 == Enum11.const_27)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_27)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_28)
                {
                    if (enum3 == Enum11.const_28)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_28)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_29)
                {
                    if (enum3 == Enum11.const_29)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_29)
                {
                    return 1;
                }
                if ((enum2 == Enum11.const_38) && (A_0.int_1 == Class519.class604_0.int_2))
                {
                    if ((enum3 == Enum11.const_38) && (A_1.int_1 == Class519.class604_0.int_2))
                    {
                        return 0;
                    }
                    return -1;
                }
                if ((enum3 == Enum11.const_38) && (A_1.int_1 == Class519.class604_0.int_2))
                {
                    return 1;
                }
                if (enum2 == Enum11.const_30)
                {
                    if (enum3 == Enum11.const_30)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_30)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_31)
                {
                    if (enum3 == Enum11.const_31)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 == Enum11.const_31)
                {
                    return 1;
                }
                if (enum2 == Enum11.const_34)
                {
                    if (enum3 == Enum11.const_34)
                    {
                        return 0;
                    }
                    return -1;
                }
                if (enum3 != Enum11.const_34)
                {
                    if ((enum2 != Enum11.const_41) && (enum3 != Enum11.const_41))
                    {
                        return string.Compare(A_0.string_1, A_1.string_1);
                    }
                    if (enum2 != Enum11.const_41)
                    {
                        return -1;
                    }
                    if (enum3 == Enum11.const_41)
                    {
                        return 0;
                    }
                }
            }
            return 1;
        }

        private static void smethod_3(int A_0, int A_1)
        {
while (true)
    {
        int num;
        int num2;
        Class640 class2;
        while (true)
        {
            num = A_0;
            num2 = A_1;
            class2 = arrayList_0[(A_0 + A_1) >> 1] as Class640;
            break;
        }
        while (true)
        {
            if (smethod_1(arrayList_0[num] as Class640, class2) < 0)
            {
                num++;
                continue;
            }
            while (true)
            {
                if (smethod_1(arrayList_0[num2] as Class640, class2) > 0)
                {
                    num2--;
                    continue;
                }
                if (num <= num2)
                {
                    arrayList_0[num] = arrayList_0[num2];
                    arrayList_0[num2] = arrayList_0[num];
                    num++;
                    num2--;
                }
                if (num > num2)
                {
                    if (A_0 < num2)
                    {
                        smethod_3(A_0, num2);
                    }
                    A_0 = num;
                    if (num >= A_1)
                    {
                        return;
                    }
                }
                else
                {
                    continue;
                }
                break;
            }
            break;
        }
    }

        }

        private static void smethod_4()
        {
            for (int i = 0; i < arrayList_0.Count; i++)
            {
                class640_0 = arrayList_0[i] as Class640;
                class640_0.enum11_1 = Enum11.const_41;
                class640_0.string_1 = string.Empty;
                if (class640_0.enum11_0 == Enum11.const_41)
                {
                    smethod_5(class640_0.int_0);
                }
            }
        }

        private static void smethod_5(int A_0)
        {
            Class558.Class606 class2 = Class546.class558_0.arrayList_0[A_0] as Class558.Class606;
            class48_0.Byte_0 = class2.byte_0;
            switch (class48_0.method_8())
            {
                case 20:
                    smethod_7();
                    break;

                case 0x1d:
                    smethod_6();
                    break;
            }
        }

        private static void smethod_6()
        {
            smethod_8();
        }

        private static void smethod_7()
        {
            smethod_8();
        }

        private static void smethod_8()
        {
            switch (class48_0.method_8())
            {
                case 2:
                    class640_0.enum11_1 = Enum11.const_16;
                    return;

                case 3:
                    class640_0.enum11_1 = Enum11.const_17;
                    return;

                case 4:
                    class640_0.enum11_1 = Enum11.const_18;
                    return;

                case 5:
                    class640_0.enum11_1 = Enum11.const_19;
                    return;

                case 6:
                    class640_0.enum11_1 = Enum11.const_20;
                    return;

                case 7:
                    class640_0.enum11_1 = Enum11.const_21;
                    return;

                case 8:
                    class640_0.enum11_1 = Enum11.const_22;
                    return;

                case 9:
                    class640_0.enum11_1 = Enum11.const_23;
                    return;

                case 10:
                    class640_0.enum11_1 = Enum11.const_24;
                    return;

                case 11:
                    class640_0.enum11_1 = Enum11.const_25;
                    return;

                case 12:
                    class640_0.enum11_1 = Enum11.const_26;
                    return;

                case 13:
                    class640_0.enum11_1 = Enum11.const_27;
                    return;

                case 14:
                    class640_0.enum11_1 = Enum11.const_28;
                    return;

                case 15:
                case 0x10:
                case 0x13:
                case 0x15:
                case 0x17:
                case 0x1a:
                case 0x1b:
                    break;

                case 0x11:
                    smethod_9();
                    return;

                case 0x12:
                    smethod_9();
                    return;

                case 20:
                    smethod_7();
                    return;

                case 0x16:
                    class640_0.enum11_1 = Enum11.const_34;
                    return;

                case 0x18:
                    class640_0.enum11_1 = Enum11.const_30;
                    return;

                case 0x19:
                    class640_0.enum11_1 = Enum11.const_30;
                    return;

                case 0x1c:
                    class640_0.enum11_1 = Enum11.const_29;
                    return;

                case 0x1d:
                    smethod_6();
                    break;

                default:
                    return;
            }
        }

        private static void smethod_9()
        {
            int num = class48_0.method_21();
            int num2 = num & 3;
            num = num >> 2;
            switch (num2)
            {
                case 0:
                {
                    Class548.Class529 class2 = Class546.class548_0.arrayList_0[num] as Class548.Class529;
                    class640_0.enum11_1 = Enum11.const_36;
                    class640_0.string_1 = Class519.class581_0[class2.int_1];
                    return;
                }
                case 1:
                {
                    Class553.Class531 class3 = Class546.class553_0.arrayList_0[num] as Class553.Class531;
                    class640_0.enum11_1 = Enum11.const_38;
                    class640_0.int_1 = num;
                    class640_0.string_1 = Class519.class581_0[class3.int_1];
                    break;
                }
            }
        }
    }
}

