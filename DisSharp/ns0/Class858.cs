namespace ns0
{
    using System;
    using System.Collections;

    internal class Class858
    {
        internal static Class445 smethod_0(Class445 A_0, bool A_1)
        {
            if (A_0.Type == Enum17.const_63)
            {
                return A_0;
            }
            return new Class510(smethod_1(A_0, A_1));
        }

        internal static Class445 smethod_1(Class445 A_0, bool A_1)
        {
            Class470 class2 = A_0 as Class470;
            if (class2 == null)
            {
                if (A_1)
                {
                    A_0.QQUW();
                    return new Class513(A_0, Enum32.const_2);
                }
                return A_0;
            }
            switch (class2.enum31_0)
            {
                case Enum31.const_0:
                    class2.enum31_0 = Enum31.const_1;
                    return class2;

                case Enum31.const_1:
                    class2.enum31_0 = Enum31.const_0;
                    return class2;

                case Enum31.const_2:
                    class2.enum31_0 = Enum31.const_5;
                    return class2;

                case Enum31.const_3:
                    class2.enum31_0 = Enum31.const_4;
                    return class2;

                case Enum31.const_4:
                    class2.enum31_0 = Enum31.const_3;
                    return class2;

                case Enum31.const_5:
                    class2.enum31_0 = Enum31.const_2;
                    return class2;
            }
            return A_0;
        }

        internal static void smethod_2(Class465 A_0)
        {
            Class445[] classArray = A_0.class445_0;
            for (int i = 0; i < classArray.Length; i++)
            {
                Class445 class2 = classArray[i];
                if (class2.Type == Enum17.const_11)
                {
                    smethod_2(class2 as Class465);
                }
                else
                {
                    classArray[i] = smethod_1(class2, true);
                }
            }
            if (A_0.enum1_0 == Enum1.const_1)
            {
                A_0.enum1_0 = Enum1.const_8;
            }
            else
            {
                A_0.enum1_0 = Enum1.const_1;
            }
        }

        internal static void smethod_3(Class470 A_0)
        {
            if (A_0 != null)
            {
                switch (A_0.enum31_0)
                {
                    case Enum31.const_0:
                        A_0.enum31_0 = Enum31.const_1;
                        return;

                    case Enum31.const_1:
                        A_0.enum31_0 = Enum31.const_0;
                        return;

                    case Enum31.const_2:
                        A_0.enum31_0 = Enum31.const_5;
                        return;

                    case Enum31.const_3:
                        A_0.enum31_0 = Enum31.const_4;
                        return;

                    case Enum31.const_4:
                        A_0.enum31_0 = Enum31.const_3;
                        return;

                    case Enum31.const_5:
                        A_0.enum31_0 = Enum31.const_2;
                        return;
                }
            }
        }

        internal static void smethod_4(Class419 A_0, bool A_1)
        {
            smethod_6(A_0, A_1, false, true);
        }

        internal static void smethod_5(Class419 A_0, bool A_1, bool A_2)
        {
            smethod_6(A_0, A_1, A_2, true);
        }

        internal static void smethod_6(Class419 A_0, bool A_1, bool A_2, bool A_3)
        {
            Enum66 enum2 = A_0.enum66_0;
            Class445 class2 = A_0.class445_0;
            if ((class2.Type != Enum17.const_16) && class2.QQVV)
            {
                Class445 class3 = class2;
                Class445 class4 = Class859.smethod_0(class2);
                if (enum2 == Enum66.const_1)
                {
                    if (class4 != class3)
                    {
                        A_0.class445_0 = smethod_1(class4, true);
                    }
                    else
                    {
                        A_0.class445_0 = class4;
                    }
                }
                else if (class4 != class3)
                {
                    A_0.class445_0 = class4;
                }
                else
                {
                    A_0.class445_0 = smethod_1(class4, true);
                }
            }
            switch (enum2)
            {
                case Enum66.const_0:
                    if (A_1)
                    {
                        A_0.class445_0 = smethod_1(A_0.class445_0, true);
                    }
                    return;

                case Enum66.const_1:
                case Enum66.const_2:
                    if (!A_2)
                    {
                        A_0.class445_0 = smethod_1(A_0.class445_0, true);
                    }
                    return;
            }
        }

        internal static bool smethod_7(object A_0)
        {
            ArrayList list = Class973.arrayList_0;
            for (int i = Class973.int_0 + 1; i < list.Count; i++)
            {
                if (list[i] == A_0)
                {
                    return true;
                }
            }
            return false;
        }

        internal static void smethod_8()
        {
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class853.struct5_0[i].class398_0.method_1(Class853.struct5_0[i].class419_0);
            }
        }

        internal static Enum46 smethod_9()
        {
            object obj1 = Class973.arrayList_0[Class973.int_0];
            Class398 class2 = null;
            Enum46 enum2 = Enum46.const_0;
            for (int i = 0; i < Class853.int_1; i++)
            {
                Class398 class3 = (Class973.arrayList_0[Class973.int_0 + i] as Class419).class398_0;
                switch (enum2)
                {
                    case Enum46.const_0:
                        class2 = class3;
                        enum2 = Enum46.const_1;
                        break;

                    case Enum46.const_1:
                        if (class3 != class2)
                        {
                            enum2 = Enum46.const_2;
                        }
                        break;

                    case Enum46.const_2:
                        enum2 = Enum46.const_3;
                        break;
                }
            }
            return enum2;
        }
    }
}

