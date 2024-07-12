namespace ns0
{
    using System;
    using System.Collections;

    internal class Class669 : Class668
    {
        private static Class556.Class601 class601_0 = new Class556.Class601();
        private static string string_55 = Class537.string_484;
        private static string string_56 = Class537.string_630;
        private static string string_57 = Class537.string_606;
        private static string string_58 = Class537.string_488;
        private static string string_59 = Class537.string_947;
        private static string string_60 = Class537.string_856;
        private static string string_61 = Class537.string_844;
        private static string string_62 = Class537.string_454;
        private static string string_63 = Class537.string_588;
        private static string string_64 = Class537.string_205;
        private static string string_65 = Class537.string_597;
        private static string string_66 = Class537.string_657;
        private static string string_67 = Class537.string_829;
        private static string string_68 = Class537.string_622;
        private static string string_69 = Class537.string_634;
        private static string string_70 = Class537.string_467;
        private static string string_71 = Class537.string_837;
        private static string string_72 = Class537.string_601;
        private static string string_73 = Class537.string_946;
        private static string string_74 = Class537.string_9;
        private static string string_75 = Class537.string_116;
        private static string string_76 = Class537.string_380;
        private static string string_77 = Class537.string_804;
        private static string string_78 = Class537.string_629;

        internal void method_64()
        {
            this.method_65();
            this.method_66();
            this.method_67();
        }

        private void method_65()
        {
            ArrayList list = base.class684_0.class549_0.arrayList_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class549.Class530 class2 = list[i] as Class549.Class530;
                base.class48_0.method_3(base.int_2 + class2.int_2);
                base.class48_0.method_21();
                if (base.class48_0.method_8() != 6)
                {
                    throw new Exception3();
                }
                base.method_8(class2);
            }
        }

        private void method_66()
        {
            ArrayList list = base.class684_0.class547_0.arrayList_0;
            ArrayList list2 = base.class684_0.class568_0.arrayList_0;
            int count = list2.Count;
            short[] numArray = base.class685_0.short_0;
            for (int i = 1; i < list.Count; i++)
            {
                Class547.Class528 class2 = list[i] as Class547.Class528;
                base.class48_0.method_3(base.int_2 + class2.int_5);
                base.class48_0.method_21();
                byte num3 = base.class48_0.method_8();
                Class547.smethod_1(class2, num3);
                if ((num3 & 0x10) != 0)
                {
                    base.class48_0.method_21();
                }
                int num4 = base.class48_0.method_21();
                class2.short_2 = (short) num4;
                base.method_10(class2);
                int index = class2.int_6;
                if (((num4 > 0) && (index < count)) && (numArray[index] == 0))
                {
                    class2.int_4 = index;
                    class2.int_6++;
                    index++;
                }
                int num6 = 0;
                for (int j = 0; j < num4; j++)
                {
                    Class568.Class623 class3;
                    if ((index + j) < count)
                    {
                        class3 = list2[index + j] as Class568.Class623;
                    }
                    else
                    {
                        class2.int_6 = list2.Count;
                        for (int k = 0; k < j; k++)
                        {
                            list2.Add(list2[index + k]);
                        }
                        class3 = new Class568.Class623 {
                            int_0 = base.class581_0.method_0(string_55 + num6.ToString())
                        };
                        num6++;
                        list2.Add(class3);
                    }
                    base.method_12(class3, class2);
                }
            }
        }

        private void method_67()
        {
            ArrayList list = base.class47_0.class17_0.arrayList_0;
            ArrayList list2 = base.class684_0.class551_0.arrayList_0;
            ArrayList list3 = base.class684_0.class555_0.arrayList_0;
            ArrayList list4 = base.class684_0.class552_0.arrayList_0;
            ArrayList list5 = base.class684_0.class556_0.arrayList_0;
            ArrayList list6 = base.class684_0.class569_0.arrayList_0;
            ArrayList list7 = base.class684_0.class553_0.arrayList_0;
            ArrayList list8 = base.class684_0.class548_0.arrayList_0;
            ArrayList list9 = base.class47_0.class3_0.arrayList_0;
            ArrayList list10 = base.class684_0.class547_0.arrayList_0;
            int num = base.class684_0.class562_0.method_4();
            int num2 = base.class684_0.class554_0.method_0();
            for (int i = 1; i < list.Count; i++)
            {
                Class17.Class880 class2 = list[i] as Class17.Class880;
                try
                {
                    int num10;
                    int num15;
                    int num16;
                    Class552.Class545 class13;
                    Class551.Class544 class3 = new Class551.Class544 {
                        enum9_0 = Enum9.const_0
                    };
                    string str = base.method_2(class2.int_1);
                    int num4 = base.class581_0.method_0(str);
                    base.class48_0.method_3(base.int_2 + class2.int_2);
                    base.class48_0.method_21();
                    byte num5 = base.class48_0.method_8();
                    if (class2.enum0_0 == Enum0.const_1)
                    {
                        if (num5 == 6)
                        {
                            Class555.Class600 class4 = new Class555.Class600 {
                                int_0 = class2.int_0,
                                int_1 = num4
                            };
                            base.method_9(class4);
                            class3.enum9_0 = Enum9.const_1;
                            class3.int_0 = list3.Count;
                            list3.Add(class4);
                        }
                        else
                        {
                            Class552.Class545 class5 = new Class552.Class545 {
                                int_0 = class2.int_0,
                                int_1 = num4
                            };
                            if (str == string_56)
                            {
                                class5.method_0();
                            }
                            if ((num5 & 0x10) != 0)
                            {
                                base.class48_0.method_21();
                            }
                            if ((num5 & 0x20) == 0)
                            {
                                class5.byte_4 = (byte) (class5.byte_4 | 2);
                            }
                            int num6 = base.class48_0.method_21();
                            class5.short_0 = (short) num6;
                            base.method_11(class5);
                            class5.int_3 = list6.Count;
                            for (int k = 0; k < num6; k++)
                            {
                                Class569.Class624 class6 = new Class569.Class624();
                                base.method_13(class6);
                                list6.Add(class6);
                            }
                            class3.enum9_0 = Enum9.const_2;
                            class3.int_0 = list4.Count;
                            this.method_69(i, str, num6, class5, class3, list7);
                            list4.Add(class5);
                        }
                    }
                    else if (class2.enum0_0 == Enum0.const_27)
                    {
                        Class3.Class690 class7 = list9[class2.int_0] as Class3.Class690;
                        base.class48_0.method_3(base.int_2 + class7.int_0);
                        base.class48_0.method_21();
                        byte num8 = base.class48_0.method_8();
                        switch (num8)
                        {
                            case 0x11:
                            case 0x12:
                            {
                                num10 = base.class48_0.method_21();
                                if ((num10 & 3) != 1)
                                {
                                    goto Label_0844;
                                }
                                Class552.Class545 class9 = new Class552.Class545 {
                                    int_0 = num10 >> 2,
                                    int_1 = num4
                                };
                                if (str == string_56)
                                {
                                    class9.method_0();
                                }
                                if ((num5 & 0x20) == 0)
                                {
                                    class9.byte_4 = (byte) (class9.byte_4 | 2);
                                }
                                base.class48_0.method_3(base.int_2 + class2.int_2);
                                base.class48_0.method_21();
                                base.class48_0.method_8();
                                int num11 = base.class48_0.method_21();
                                class9.short_0 = (short) num11;
                                base.method_11(class9);
                                class9.int_3 = list6.Count;
                                for (int m = 0; m < num11; m++)
                                {
                                    Class569.Class624 class10 = new Class569.Class624();
                                    base.method_13(class10);
                                    list6.Add(class10);
                                }
                                class3.enum9_0 = Enum9.const_2;
                                class3.int_0 = list4.Count;
                                this.method_69(i, str, num11, class9, class3, list7);
                                list4.Add(class9);
                                goto Label_096E;
                            }
                            case 14:
                            case 0x1c:
                                class13 = new Class552.Class545();
                                if (num8 != 14)
                                {
                                    goto Label_064C;
                                }
                                if (base.class604_0.int_3 == -1)
                                {
                                    Class553.Class531 class14 = new Class553.Class531 {
                                        enum0_0 = Enum0.const_35,
                                        int_0 = num2,
                                        int_1 = base.class581_0.method_0(Class537.string_937),
                                        int_2 = num
                                    };
                                    base.class604_0.int_3 = base.class684_0.class553_0.arrayList_0.Count;
                                    base.class684_0.class553_0.arrayList_0.Add(class14);
                                }
                                class13.int_0 = base.class604_0.int_3;
                                class13.int_1 = num4;
                                if (str.StartsWith(string_60))
                                {
                                    class3.enum21_0 = Enum21.const_1;
                                }
                                else
                                {
                                    class13.byte_4 = (byte) (class13.byte_4 | 2);
                                    if (str == string_67)
                                    {
                                        class13.enum23_0 = Enum23.const_4;
                                    }
                                }
                                goto Label_0667;

                            case 20:
                            {
                                bool flag = false;
                                if (str == string_56)
                                {
                                    class3.enum21_0 = Enum21.const_6;
                                    flag = true;
                                }
                                else if (str == string_57)
                                {
                                    class3.enum21_0 = Enum21.const_7;
                                    flag = true;
                                }
                                else if (str == string_58)
                                {
                                    class3.enum21_0 = Enum21.const_8;
                                    flag = true;
                                }
                                else if (str == string_59)
                                {
                                    class3.enum21_0 = Enum21.const_9;
                                    flag = true;
                                }
                                if (flag)
                                {
                                    Class552.Class545 class8 = new Class552.Class545 {
                                        int_1 = num4
                                    };
                                    base.method_11(class8);
                                    base.class48_0.method_3(base.int_2 + class2.int_2);
                                    base.class48_0.method_21();
                                    base.class48_0.method_8();
                                    int num9 = base.class48_0.method_21();
                                    class8.short_0 = (short) num9;
                                    class3.enum9_0 = Enum9.const_2;
                                    class3.int_0 = list4.Count;
                                    list4.Add(class8);
                                }
                                goto Label_096E;
                            }
                        }
                        if (num8 == 0x15)
                        {
                            class3.enum9_0 = Enum9.const_4;
                            base.class48_0.method_3(base.int_2 + class2.int_2);
                            base.class48_0.method_21();
                            Class556.Class601 class16 = new Class556.Class601 {
                                int_1 = class2.int_0,
                                int_3 = num4
                            };
                            byte num20 = base.class48_0.method_8();
                            if (num20 == 6)
                            {
                                class16.method_1();
                                base.method_14(class16);
                            }
                            else
                            {
                                if ((num20 & 0x20) == 0)
                                {
                                    class16.byte_3 = (byte) (class16.byte_3 | 2);
                                }
                                if (str == string_56)
                                {
                                    class16.method_0();
                                }
                                int num21 = base.class48_0.method_21();
                                class16.short_0 = (short) num21;
                                base.method_14(class16);
                                if ((num5 & 0x10) != 0)
                                {
                                    base.class48_0.method_21();
                                }
                                class16.int_5 = list6.Count;
                                for (int n = 0; n < num21; n++)
                                {
                                    Class569.Class624 class17 = new Class569.Class624();
                                    base.method_13(class17);
                                    list6.Add(class17);
                                }
                                this.method_68(class16, class2.int_0, base.int_2, num21, str);
                            }
                            class3.enum9_0 = Enum9.const_4;
                            class3.int_0 = list5.Count;
                            list5.Add(class16);
                        }
                    }
                    goto Label_096E;
                Label_064C:
                    class13.int_0 = base.class604_0.int_1;
                    class13.int_1 = num4;
                Label_0667:
                    if ((num5 & 0x20) == 0)
                    {
                        class13.byte_4 = (byte) (class13.byte_4 | 2);
                    }
                    base.class48_0.method_3(base.int_2 + class2.int_2);
                    base.class48_0.method_21();
                    base.class48_0.method_8();
                    int num18 = base.class48_0.method_21();
                    class13.short_0 = (short) num18;
                    base.method_11(class13);
                    class13.int_3 = list6.Count;
                    for (int j = 0; j < num18; j++)
                    {
                        Class569.Class624 class15 = new Class569.Class624();
                        base.method_13(class15);
                        list6.Add(class15);
                    }
                    class3.enum9_0 = Enum9.const_2;
                    class3.int_0 = list4.Count;
                    list4.Add(class13);
                    goto Label_096E;
                Label_0844:
                    if ((num10 & 3) == 0)
                    {
                        base.class48_0.method_3(base.int_2 + class2.int_2);
                        int num13 = base.class48_0.method_21();
                        byte[] buffer = base.class48_0.method_19(num13);
                        int num14 = num10 >> 2;
                        Class548.Class529 class11 = list8[num14] as Class548.Class529;
                        num15 = class11.int_8;
                        int[] numArray = base.class685_0.int_1;
                        num16 = 0;
                        while (num16 < class11.short_5)
                        {
                            Class547.Class528 class12 = list10[num15 + num16] as Class547.Class528;
                            if (base.class581_0[class12.int_1] != str)
                            {
                                goto Label_0944;
                            }
                            base.class48_0.method_3(base.int_2 + numArray[num15 + num16]);
                            num13 = base.class48_0.method_21();
                            if (num13 != buffer.Length)
                            {
                                goto Label_0944;
                            }
                            bool flag2 = true;
                            for (int num17 = 0; num17 < num13; num17++)
                            {
                                if (buffer[num17] != base.class48_0.method_8())
                                {
                                    goto Label_093D;
                                }
                            }
                            goto Label_0940;
                        Label_093D:
                            flag2 = false;
                        Label_0940:
                            if (flag2)
                            {
                                goto Label_095A;
                            }
                        Label_0944:
                            num16++;
                        }
                    }
                    goto Label_096E;
                Label_095A:
                    class3.enum9_0 = Enum9.const_3;
                    class3.int_0 = num15 + num16;
                Label_096E:
                    list2.Add(class3);
                }
                catch
                {
                }
            }
        }

        private void method_68(Class556.Class601 A_1, int A_2, int A_3, int A_4, string A_5)
        {
            Class3.Class690 class2 = base.class47_0.class3_0.arrayList_0[A_2] as Class3.Class690;
            base.class48_0.method_3(A_3 + class2.int_0);
            base.class48_0.method_21();
            base.class48_0.method_8();
            base.method_14(class601_0);
            if (class601_0.enum11_0 == Enum11.const_36)
            {
                A_1.enum0_0 = Enum0.const_2;
                A_1.int_0 = class601_0.int_4;
                Class548.Class529 class3 = base.class684_0.class548_0.arrayList_0[class601_0.int_4] as Class548.Class529;
                ArrayList list = base.class684_0.class547_0.arrayList_0;
                int num = class3.int_8;
                for (int i = 0; i < class3.short_5; i++)
                {
                    Class547.Class528 class4 = list[num + i] as Class547.Class528;
                    if ((class4.short_2 == A_4) && (base.class581_0[class4.int_1] == A_5))
                    {
                        A_1.int_3 = class4.int_1;
                        break;
                    }
                }
                if ((class3.enum0_0 == Enum0.const_1) && (class3.int_4 == base.class604_0.int_7))
                {
                    if (A_5 == string_68)
                    {
                        A_1.enum24_0 = Enum24.const_1;
                    }
                    else if (A_5 == string_69)
                    {
                        A_1.enum24_0 = Enum24.const_2;
                    }
                    else if (A_5 == string_70)
                    {
                        A_1.enum24_0 = Enum24.const_3;
                    }
                }
            }
        }

        private void method_69(int A_1, string A_2, int A_3, Class552.Class545 A_4, Class551.Class544 A_5, ArrayList A_6)
        {
            char ch = A_2[0];
            if (ch > 'W')
            {
                switch (ch)
                {
                    case 'o':
                        if ((A_2.Length > 3) && A_2.StartsWith(string_66))
                        {
                            A_4.byte_4 = (byte) (A_4.byte_4 | 4);
                        }
                        return;

                    case 'p':
                    case 'q':
                        return;

                    case 'r':
                        if ((A_2.Length > 7) && A_2.StartsWith(string_69))
                        {
                            A_4.enum23_0 = Enum23.const_2;
                        }
                        return;

                    case 's':
                        if ((A_2.Length > 4) && A_2.StartsWith(string_61))
                        {
                            if ((A_2 == string_63) || (A_2 == Class537.string_777))
                            {
                                A_5.enum21_0 = Enum21.const_4;
                                return;
                            }
                            if (A_3 != 1)
                            {
                                return;
                            }
                            A_5.enum21_0 = Enum21.const_2;
                        }
                        return;

                    case 'g':
                        if ((A_2.Length > 4) && A_2.StartsWith(string_60))
                        {
                            if ((A_2 == string_62) || (A_2 == Class537.string_791))
                            {
                                A_5.enum21_0 = Enum21.const_3;
                                return;
                            }
                            if (A_3 == 0)
                            {
                                A_5.enum21_0 = Enum21.const_1;
                                return;
                            }
                            if ((A_2 != string_75) || (A_4.int_0 != base.class604_0.int_3))
                            {
                                return;
                            }
                            base.class604_0.uint_9 = Class689.smethod_1(10, A_1);
                        }
                        return;

                    case 'a':
                        if ((A_2.Length > 4) && A_2.StartsWith(string_68))
                        {
                            A_4.enum23_0 = Enum23.const_1;
                            return;
                        }
                        return;
                }
            }
            else
            {
                switch (ch)
                {
                    case 'C':
                        if ((A_2 != string_67) || (A_4.int_0 != base.class604_0.int_3))
                        {
                            if ((A_2 != string_71) || (A_4.int_0 != base.class604_0.int_11))
                            {
                                break;
                            }
                            base.class604_0.uint_5 = Class689.smethod_1(10, A_1);
                            return;
                        }
                        A_4.enum23_0 = Enum23.const_4;
                        return;

                    case 'D':
                    case 'F':
                    case 'H':
                        break;

                    case 'E':
                        if ((A_2 != string_64) || (A_4.int_0 != base.class604_0.int_10))
                        {
                            if ((A_2 != string_65) || (A_4.int_0 != base.class604_0.int_10))
                            {
                                break;
                            }
                            base.class604_0.uint_3 = Class689.smethod_1(10, A_1);
                            return;
                        }
                        base.class604_0.uint_4 = Class689.smethod_1(10, A_1);
                        return;

                    case 'G':
                        if ((A_2 != string_77) || (A_4.int_0 != base.class604_0.int_4))
                        {
                            break;
                        }
                        base.class604_0.uint_8 = Class689.smethod_1(10, A_1);
                        return;

                    case 'I':
                    {
                        if (A_2 != string_70)
                        {
                            if ((A_2 != string_76) || (A_4.int_0 != base.class604_0.int_13))
                            {
                                break;
                            }
                            base.class604_0.uint_7 = Class689.smethod_1(10, A_1);
                            return;
                        }
                        Class553.Class531 class2 = A_6[A_4.int_0] as Class553.Class531;
                        if ((class2.enum0_0 != Enum0.const_1) || (class2.int_0 != base.class604_0.int_7))
                        {
                            if (!base.class581_0[class2.int_1].EndsWith(string_78))
                            {
                                break;
                            }
                            A_4.enum23_0 = Enum23.const_3;
                            return;
                        }
                        A_4.enum23_0 = Enum23.const_3;
                        return;
                    }
                    case 'R':
                        if ((A_2 != string_72) || (A_4.int_0 != base.class604_0.int_11))
                        {
                            break;
                        }
                        base.class604_0.uint_6 = Class689.smethod_1(10, A_1);
                        return;

                    case 'W':
                        if ((A_2 == string_73) && (A_4.int_0 == base.class604_0.int_12))
                        {
                            A_4.enum23_0 = Enum23.const_5;
                            return;
                        }
                        if ((A_2 == string_74) && (A_4.int_0 == base.class604_0.int_12))
                        {
                            A_4.enum23_0 = Enum23.const_6;
                        }
                        break;

                    default:
                        return;
                }
            }
        }
    }
}

