namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1112
    {
        internal static void smethod_0()
        {
            smethod_1(Class536.arrayList_0);
        }

        private static void smethod_1(ArrayList A_0)
        {
            for (int i = 0; i < A_0.Count; i++)
            {
                Class463 class3;
                Class445 class6;
                Enum17 type;
                Class398 class2 = A_0[i] as Class398;
                Class398 class4 = null;
                switch (class2.Type)
                {
                    case Enum26.const_22:
                    {
                        Class422 class9 = class2 as Class422;
                        class3 = class9.class445_1[class9.class445_1.Length - 1] as Class463;
                        if (class3 != null)
                        {
                            class4 = smethod_8(class9, class3);
                        }
                        goto Label_019C;
                    }
                    case Enum26.const_24:
                    {
                        Class424 class7 = class2 as Class424;
                        class3 = class7.class445_1 as Class463;
                        if (class3 != null)
                        {
                            class4 = smethod_6(class7, class3);
                        }
                        goto Label_019C;
                    }
                    case Enum26.const_0:
                    {
                        Class399 class5 = class2 as Class399;
                        class3 = class5.class445_1 as Class463;
                        if (class3 != null)
                        {
                            class6 = class5.class445_0;
                            type = class6.Type;
                            if (type > Enum17.const_36)
                            {
                                break;
                            }
                            if (type == Enum17.const_2)
                            {
                                class4 = smethod_3(class6 as Class456, class3);
                            }
                            else if (type == Enum17.const_36)
                            {
                                class4 = smethod_4(class6 as Class484, class3);
                            }
                        }
                        goto Label_019C;
                    }
                    case Enum26.const_30:
                    {
                        Class430 class10 = class2 as Class430;
                        class3 = class10.class445_0[class10.class445_0.Length - 1] as Class463;
                        if (class3 != null)
                        {
                            class4 = smethod_9(class10, class3);
                        }
                        goto Label_019C;
                    }
                    case Enum26.const_32:
                    {
                        Class432 class8 = class2 as Class432;
                        class3 = class8.class445_0 as Class463;
                        if (class3 != null)
                        {
                            class4 = smethod_7(class8, class3);
                        }
                        goto Label_019C;
                    }
                    default:
                        goto Label_019C;
                }
                if (type == Enum17.const_44)
                {
                    class4 = smethod_2(class6 as Class452, class3);
                }
                else if (type == Enum17.const_55)
                {
                    class4 = smethod_5(class6 as Class501, class3);
                }
            Label_019C:
                if (class4 != null)
                {
                    Class689.smethod_5(class2, class4);
                    A_0[i] = class4;
                    Class1021.bool_0 = true;
                }
                ArrayList qQSQ = class2.QQSQ;
                if (qQSQ != null)
                {
                    smethod_1(qQSQ);
                }
            }
        }

        private static bool smethod_10(Enum1 A_0)
        {
            switch (A_0)
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
                    return false;
            }
            return true;
        }

        private static Class398 smethod_11(Class445 A_0, Class445 A_1, Enum1 A_2)
        {
            if (A_2 == Enum1.const_0)
            {
                Class447 class2 = A_1 as Class447;
                if (class2 == null)
                {
                    return null;
                }
                if (class2.int_0 != 1)
                {
                    return null;
                }
                return new Class443(new Class480(A_0));
            }
            if (A_2 != Enum1.const_11)
            {
                return null;
            }
            Class447 class3 = A_1 as Class447;
            if (class3 == null)
            {
                return null;
            }
            if (class3.int_0 != 1)
            {
                return null;
            }
            return new Class443(new Class477(A_0));
        }

        private static Class398 smethod_2(Class452 A_0, Class463 A_1)
        {
            Class452 class2 = A_1.class445_0 as Class452;
            if (class2 == null)
            {
                return null;
            }
            if (class2.ushort_0 != A_0.ushort_0)
            {
                return null;
            }
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(A_0, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            return new Class401(A_0, A_1.class445_1, A_1.enum1_0);
        }

        private static Class398 smethod_3(Class456 A_0, Class463 A_1)
        {
            Class456 class2 = A_1.class445_0 as Class456;
            if (class2 == null)
            {
                return null;
            }
            if (class2.ushort_0 != A_0.ushort_0)
            {
                return null;
            }
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(A_0, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            return new Class401(A_0, A_1.class445_1, A_1.enum1_0);
        }

        private static Class398 smethod_4(Class484 A_0, Class463 A_1)
        {
            Class484 class2 = A_1.class445_0 as Class484;
            if (class2 == null)
            {
                return null;
            }
            if (class2.uint_0 != A_0.uint_0)
            {
                return null;
            }
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(A_0, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            return new Class401(A_0, A_1.class445_1, A_1.enum1_0);
        }

        private static Class398 smethod_5(Class501 A_0, Class463 A_1)
        {
            Class501 class2 = A_1.class445_0 as Class501;
            if (class2 == null)
            {
                return null;
            }
            if (class2.uint_0 != A_0.uint_0)
            {
                return null;
            }
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(A_0, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            return new Class401(A_0, A_1.class445_1, A_1.enum1_0);
        }

        private static Class398 smethod_6(Class424 A_0, Class463 A_1)
        {
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class489 class2 = A_1.class445_0 as Class489;
            if (class2 == null)
            {
                return null;
            }
            if (!A_0.class445_0.method_0(class2.class445_0))
            {
                return null;
            }
            if (!Class1030.smethod_0(class2.uint_0, A_0.uint_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(class2, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            return new Class423(A_0.class445_0, A_0.uint_0, A_1.class445_1, A_1.enum1_0);
        }

        private static Class398 smethod_7(Class432 A_0, Class463 A_1)
        {
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class507 class2 = A_1.class445_0 as Class507;
            if (class2 == null)
            {
                return null;
            }
            if (!Class1030.smethod_0(class2.uint_0, A_0.uint_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(class2, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            return new Class431(A_0.uint_0, A_1.class445_1, A_1.enum1_0);
        }

        private static Class398 smethod_8(Class422 A_0, Class463 A_1)
        {
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class486 class2 = A_1.class445_0 as Class486;
            if (class2 == null)
            {
                return null;
            }
            if (!A_0.class445_0.method_0(class2.class445_0))
            {
                return null;
            }
            Class445[] classArray = A_0.class445_1;
            Class445[] classArray2 = class2.class445_1;
            if ((classArray.Length - classArray2.Length) != 1)
            {
                return null;
            }
            for (int i = 0; i < classArray2.Length; i++)
            {
                if (!classArray[i].method_0(classArray2[i]))
                {
                    return null;
                }
            }
            if (!Class1030.smethod_1(class2.uint_0, A_0.uint_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(class2, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            classArray[classArray.Length - 1] = A_1.class445_1;
            return new Class421(A_0.class445_0, A_0.uint_0, classArray, A_1.enum1_0);
        }

        private static Class398 smethod_9(Class430 A_0, Class463 A_1)
        {
            if (smethod_10(A_1.enum1_0))
            {
                return null;
            }
            Class503 class2 = A_1.class445_0 as Class503;
            if (class2 == null)
            {
                return null;
            }
            Class445[] classArray = A_0.class445_0;
            Class445[] classArray2 = class2.class445_0;
            if ((classArray.Length - classArray2.Length) != 1)
            {
                return null;
            }
            for (int i = 0; i < classArray2.Length; i++)
            {
                if (!classArray[i].method_0(classArray2[i]))
                {
                    return null;
                }
            }
            if (!Class1030.smethod_1(class2.uint_0, A_0.uint_0))
            {
                return null;
            }
            Class398 class3 = smethod_11(class2, A_1.class445_1, A_1.enum1_0);
            if (class3 != null)
            {
                return class3;
            }
            classArray[classArray.Length - 1] = A_1.class445_1;
            return new Class429(A_0.uint_0, classArray, A_1.enum1_0);
        }
    }
}

