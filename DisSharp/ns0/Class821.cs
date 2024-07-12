namespace ns0
{
    using System;
    using System.Collections;

    internal class Class821
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private static ArrayList arrayList_1 = new ArrayList();
        private static Class445 class445_0;

        internal static Class658 smethod_0(Class445 A_0)
        {
            Class658 class2 = Class658.smethod_1();
            switch (A_0.Type)
            {
                case Enum17.const_2:
                {
                    Class456 class3 = A_0 as Class456;
                    bool flag1 = Class519.class528_0.Boolean_18;
                    int num = (Class519.class528_0.int_6 + class3.ushort_0) - (Class519.class528_0.Boolean_8 ? 0 : 1);
                    if (num > 0)
                    {
                        Class568.Class623 class4 = Class546.class568_0.arrayList_0[num] as Class568.Class623;
                        class2.enum11_0 = smethod_8(class4.enum11_0);
                        class2.int_0 = class4.int_1;
                        class2.byte_0 = class4.byte_4;
                        return class2;
                    }
                    return class2;
                }
                case Enum17.const_4:
                {
                    Class458 class5 = A_0 as Class458;
                    return smethod_0(class5.class445_0);
                }
                case Enum17.const_5:
                {
                    Class459 class6 = A_0 as Class459;
                    return smethod_0(class6.class445_0);
                }
                case Enum17.const_7:
                {
                    Class461 class7 = A_0 as Class461;
                    return smethod_0(class7.class445_0);
                }
                case Enum17.const_9:
                {
                    Class463 class8 = A_0 as Class463;
                    switch (class8.enum1_0)
                    {
                        case Enum1.const_0:
                        case Enum1.const_2:
                        case Enum1.const_3:
                        case Enum1.const_4:
                        case Enum1.const_5:
                        case Enum1.const_6:
                        case Enum1.const_7:
                        case Enum1.const_9:
                        case Enum1.const_10:
                        case Enum1.const_11:
                            return smethod_0(class8.class445_0);

                        case Enum1.const_1:
                        case Enum1.const_8:
                            class2.enum11_0 = Enum11.const_16;
                            return class2;
                    }
                    class2.enum11_0 = Enum11.const_15;
                    return class2;
                }
                case Enum17.const_12:
                    class2.enum11_0 = Enum11.const_29;
                    return class2;

                case Enum17.const_13:
                {
                    Class467 class9 = A_0 as Class467;
                    return smethod_2(class9.uint_0);
                }
                case Enum17.const_16:
                    class2.enum11_0 = Enum11.const_16;
                    return class2;

                case Enum17.const_17:
                    class2.enum11_0 = Enum11.const_16;
                    return class2;

                case Enum17.const_18:
                    class2.enum11_0 = Enum11.const_17;
                    return class2;

                case Enum17.const_19:
                    class2.enum11_0 = Enum11.const_27;
                    return class2;

                case Enum17.const_20:
                    smethod_1(A_0 as Class472, class2);
                    return class2;

                case Enum17.const_21:
                    class2.enum11_0 = Enum11.const_26;
                    return class2;

                case Enum17.const_22:
                    class2.enum11_0 = Enum11.const_22;
                    return class2;

                case Enum17.const_23:
                    class2.enum11_0 = Enum11.const_24;
                    return class2;

                case Enum17.const_25:
                    class2.enum11_0 = Enum11.const_28;
                    return class2;

                case Enum17.const_28:
                {
                    Class476 class10 = A_0 as Class476;
                    class2.enum11_0 = smethod_4(class10.enum3_0);
                    return class2;
                }
                case Enum17.const_29:
                {
                    Class477 class11 = A_0 as Class477;
                    return smethod_0(class11.class445_0);
                }
                case Enum17.const_30:
                {
                    Class478 class12 = A_0 as Class478;
                    return smethod_0(class12.class445_0);
                }
                case Enum17.const_32:
                {
                    Class480 class13 = A_0 as Class480;
                    return smethod_0(class13.class445_0);
                }
                case Enum17.const_33:
                {
                    Class481 class14 = A_0 as Class481;
                    return smethod_0(class14.class445_0);
                }
                case Enum17.const_36:
                {
                    Class484 class15 = A_0 as Class484;
                    return smethod_2(class15.uint_0);
                }
                case Enum17.const_38:
                {
                    Class486 class16 = A_0 as Class486;
                    return smethod_2(class16.uint_0);
                }
                case Enum17.const_39:
                {
                    Class487 class17 = A_0 as Class487;
                    return smethod_2(class17.uint_0);
                }
                case Enum17.const_40:
                {
                    Class488 class18 = A_0 as Class488;
                    return smethod_2(class18.uint_0);
                }
                case Enum17.const_41:
                {
                    Class489 class19 = A_0 as Class489;
                    return smethod_2(class19.uint_0);
                }
                case Enum17.const_42:
                {
                    Class490 class20 = A_0 as Class490;
                    if (!class20.bool_1)
                    {
                        return smethod_2(class20.uint_0);
                    }
                    class2.enum11_0 = Enum11.const_16;
                    return class2;
                }
                case Enum17.const_43:
                    class2.enum11_0 = Enum11.const_22;
                    return class2;

                case Enum17.const_44:
                {
                    Class452 class21 = A_0 as Class452;
                    int num2 = Class519.class528_0.int_7 + class21.ushort_0;
                    Class574.Class636 class22 = Class546.class574_0.arrayList_0[num2] as Class574.Class636;
                    class2.enum11_0 = smethod_8(class22.enum11_0);
                    class2.int_0 = class22.int_1;
                    class2.byte_0 = class22.byte_0;
                    return class2;
                }
                case Enum17.const_46:
                {
                    Class492 class23 = A_0 as Class492;
                    class2.enum11_0 = smethod_8(class23.enum11_0);
                    class2.int_0 = class23.int_0;
                    class2.byte_0 = class23.byte_0;
                    return class2;
                }
                case Enum17.const_50:
                    class2.enum11_0 = Enum11.const_29;
                    return class2;

                case Enum17.const_52:
                    class2.enum11_0 = Enum11.const_22;
                    return class2;

                case Enum17.const_55:
                {
                    Class501 class24 = A_0 as Class501;
                    return smethod_2(class24.uint_0);
                }
                case Enum17.const_57:
                {
                    Class503 class25 = A_0 as Class503;
                    return smethod_2(class25.uint_0);
                }
                case Enum17.const_58:
                {
                    Class504 class26 = A_0 as Class504;
                    return smethod_2(class26.uint_0);
                }
                case Enum17.const_59:
                {
                    Class506 class27 = A_0 as Class506;
                    return smethod_2(class27.uint_0);
                }
                case Enum17.const_60:
                {
                    Class507 class28 = A_0 as Class507;
                    return smethod_2(class28.uint_0);
                }
                case Enum17.const_64:
                    class2.enum11_0 = Enum11.const_29;
                    return class2;

                case Enum17.const_65:
                {
                    Class512 class29 = A_0 as Class512;
                    return smethod_3(class29.uint_0);
                }
                case Enum17.const_66:
                {
                    Class513 class30 = A_0 as Class513;
                    if (class30.enum32_0 == Enum32.const_2)
                    {
                        class2.enum11_0 = Enum11.const_16;
                        return class2;
                    }
                    return smethod_0(class30.class445_0);
                }
            }
            class2.enum11_0 = Enum11.const_15;
            return class2;
        }

        private static void smethod_1(Class472 A_0, Class658 A_1)
        {
            A_1.int_0 = A_0.int_0;
            switch (A_0.enum0_0)
            {
                case Enum0.const_1:
                    A_1.enum11_0 = Enum11.const_38;
                    return;

                case Enum0.const_2:
                    A_1.enum11_0 = Enum11.const_36;
                    return;
            }
            A_1.enum11_0 = Enum11.const_15;
        }

        private static void smethod_10(Class445 A_0, Enum1 A_1)
        {
            if (A_0.Type == Enum17.const_9)
            {
                Class463 class2 = A_0 as Class463;
                if (smethod_11(class2.enum1_0, A_1))
                {
                    arrayList_0.Add(class2.class445_1);
                    arrayList_1.Add(class2.enum1_0);
                    class445_0 = class2.class445_0;
                    smethod_10(class2.class445_0, A_1);
                }
            }
        }

        private static bool smethod_11(Enum1 A_0, Enum1 A_1)
        {
            if (A_0 == A_1)
            {
                return true;
            }
            Enum1 enum2 = A_0;
            switch (enum2)
            {
                case Enum1.const_5:
                    if (A_1 != Enum1.const_7)
                    {
                        break;
                    }
                    return true;

                case Enum1.const_6:
                    break;

                case Enum1.const_7:
                    if (A_1 != Enum1.const_5)
                    {
                        break;
                    }
                    return true;

                case Enum1.const_0:
                    if (A_1 == Enum1.const_11)
                    {
                        return true;
                    }
                    break;

                default:
                    if ((enum2 == Enum1.const_11) && (A_1 == Enum1.const_0))
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }

        internal static Class658 smethod_2(uint A_0)
        {
            Class658 class2 = Class658.smethod_1();
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_1:
                    class2.enum11_0 = Enum11.const_38;
                    class2.int_0 = num;
                    return class2;

                case Enum0.const_2:
                    class2.enum11_0 = Enum11.const_36;
                    class2.int_0 = num;
                    return class2;

                case Enum0.const_4:
                {
                    Class549.Class530 class6 = Class546.class549_0.arrayList_0[num] as Class549.Class530;
                    class2.enum11_0 = smethod_8(class6.enum11_0);
                    class2.int_0 = class6.int_2;
                    class2.byte_0 = class6.byte_0;
                    return class2;
                }
                case Enum0.const_6:
                    break;

                case Enum0.const_10:
                {
                    Class551.Class544 class3 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class3.enum9_0 == Enum9.const_1)
                    {
                        Class555.Class600 class4 = Class546.class555_0.arrayList_0[class3.int_0] as Class555.Class600;
                        class2.enum11_0 = smethod_8(class4.enum11_0);
                        class2.int_0 = class4.int_2;
                        class2.byte_0 = class4.byte_0;
                        return class2;
                    }
                    if (class3.enum9_0 == Enum9.const_2)
                    {
                        Class552.Class545 class5 = Class546.class552_0.arrayList_0[class3.int_0] as Class552.Class545;
                        class2.enum11_0 = smethod_8(class5.enum11_0);
                        class2.int_0 = class5.int_2;
                        class2.byte_0 = class5.byte_5;
                        return class2;
                    }
                    if (class3.enum9_0 == Enum9.const_3)
                    {
                        num = class3.int_0;
                        break;
                    }
                    return class2;
                }
                default:
                    class2.enum11_0 = Enum11.const_15;
                    class2.int_0 = num;
                    return class2;
            }
            Class547.Class528 class7 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            class2.enum11_0 = smethod_8(class7.enum11_0);
            class2.int_0 = class7.int_5;
            class2.byte_0 = class7.byte_1;
            return class2;
        }

        internal static Class658 smethod_3(uint A_0)
        {
            Class658 class2 = Class658.smethod_1();
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_1:
                    if (!Class519.class604_0.method_2(num))
                    {
                        class2.enum11_0 = Enum11.const_38;
                        class2.int_0 = num;
                        return class2;
                    }
                    class2.enum11_0 = Class519.class604_0.enum11_0;
                    return class2;

                case Enum0.const_2:
                    class2.enum11_0 = Enum11.const_36;
                    class2.int_0 = num;
                    return class2;
            }
            class2.enum11_0 = Enum11.const_15;
            return class2;
        }

        private static Enum11 smethod_4(Enum3 A_0)
        {
            switch (A_0)
            {
                case Enum3.const_2:
                    return Enum11.const_18;

                case Enum3.const_3:
                    return Enum11.const_19;

                case Enum3.const_4:
                    return Enum11.const_20;

                case Enum3.const_5:
                    return Enum11.const_21;

                case Enum3.const_6:
                    return Enum11.const_22;

                case Enum3.const_7:
                    return Enum11.const_23;

                case Enum3.const_8:
                    return Enum11.const_24;

                case Enum3.const_9:
                    return Enum11.const_25;

                case Enum3.const_10:
                    return Enum11.const_26;

                case Enum3.const_11:
                    return Enum11.const_27;
            }
            return Enum11.const_15;
        }

        internal static Class957 smethod_5(uint A_0)
        {
            Class957 class2 = Class658.smethod_3();
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_6:
                    break;

                case Enum0.const_10:
                {
                    Class551.Class544 class3 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    if (class3.enum9_0 != Enum9.const_3)
                    {
                        if (class3.enum9_0 == Enum9.const_4)
                        {
                            Class556.Class601 class4 = Class546.class556_0.arrayList_0[class3.int_0] as Class556.Class601;
                            class2.enum0_0 = Enum0.const_49;
                            class2.int_0 = class4.int_5;
                            return class2;
                        }
                        Class552.Class545 class5 = Class546.class552_0.arrayList_0[class3.int_0] as Class552.Class545;
                        class2.enum0_0 = Enum0.const_10;
                        class2.int_0 = class5.int_3;
                        return class2;
                    }
                    num = class3.int_0;
                    break;
                }
                default:
                    class2.bool_0 = true;
                    return class2;
            }
            Class547.Class528 class6 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
            class2.enum0_0 = Enum0.const_6;
            class2.int_0 = class6.int_6;
            return class2;
        }

        internal static Class658 smethod_6(Class957 A_0, int A_1)
        {
            Class658 class2 = Class658.smethod_1();
            Enum0 enum2 = A_0.enum0_0;
            switch (enum2)
            {
                case Enum0.const_6:
                {
                    Class568.Class623 class5 = Class546.class568_0.arrayList_0[A_0.int_0 + A_1] as Class568.Class623;
                    class2.enum11_0 = smethod_8(class5.enum11_0);
                    class2.int_0 = class5.int_1;
                    class2.byte_0 = class5.byte_4;
                    return class2;
                }
                case Enum0.const_10:
                {
                    Class569.Class624 class3 = Class546.class569_0.arrayList_0[A_0.int_0 + A_1] as Class569.Class624;
                    class2.enum11_0 = smethod_8(class3.enum11_0);
                    class2.int_0 = class3.int_0;
                    class2.byte_0 = class3.byte_2;
                    return class2;
                }
            }
            if (enum2 != Enum0.const_49)
            {
                class2.enum11_0 = Enum11.const_15;
                return class2;
            }
            Class569.Class624 class4 = Class546.class569_0.arrayList_0[A_0.int_0 + A_1] as Class569.Class624;
            class2.enum11_0 = smethod_8(class4.enum11_0);
            class2.int_0 = class4.int_0;
            class2.byte_0 = class4.byte_2;
            return class2;
        }

        internal static Class658 smethod_7(uint A_0)
        {
            Class658 class2 = Class658.smethod_1();
            Enum0 enum2 = (Enum0) ((byte) ((A_0 & -16777216) >> 0x18));
            int num = ((int) A_0) & 0xffffff;
            switch (enum2)
            {
                case Enum0.const_6:
                {
                    Class547.Class528 class6 = Class546.class547_0.arrayList_0[num] as Class547.Class528;
                    Class568.Class623 class7 = Class546.class568_0.arrayList_0[class6.int_6] as Class568.Class623;
                    class2.enum11_0 = smethod_8(class7.enum11_0);
                    class2.int_0 = class7.int_1;
                    class2.byte_0 = class7.byte_4;
                    return class2;
                }
                case Enum0.const_10:
                {
                    Class551.Class544 class3 = Class546.class551_0.arrayList_0[num] as Class551.Class544;
                    Class552.Class545 class4 = Class546.class552_0.arrayList_0[class3.int_0] as Class552.Class545;
                    Class569.Class624 class5 = Class546.class569_0.arrayList_0[class4.int_3] as Class569.Class624;
                    class2.enum11_0 = smethod_8(class5.enum11_0);
                    class2.int_0 = class5.int_0;
                    class2.byte_0 = class5.byte_2;
                    return class2;
                }
            }
            class2.enum11_0 = Enum11.const_15;
            return class2;
        }

        private static Enum11 smethod_8(Enum11 A_0)
        {
            return A_0;
        }

        internal static Class445 smethod_9(Class445 A_0)
        {
            if (A_0.Type != Enum17.const_9)
            {
                return A_0;
            }
            Class463 class2 = A_0 as Class463;
            Enum1 enum2 = class2.enum1_0;
            smethod_10(class2.class445_0, enum2);
            if (arrayList_0.Count <= 0)
            {
                return A_0;
            }
            int count = arrayList_0.Count;
            Class445[] classArray = new Class445[count + 2];
            classArray[0] = class445_0;
            Enum1[] enumArray = new Enum1[count + 1];
            for (int i = 0; i < count; i++)
            {
                int num3 = (count - i) - 1;
                classArray[i + 1] = arrayList_0[num3] as Class445;
                enumArray[i] = (Enum1) arrayList_1[num3];
            }
            enumArray[count] = enum2;
            classArray[count + 1] = class2.class445_1;
            arrayList_0.Clear();
            arrayList_1.Clear();
            return new Class464(enumArray, classArray) { bool_0 = class2.bool_0 };
        }
    }
}

