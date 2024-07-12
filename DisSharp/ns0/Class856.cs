namespace ns0
{
    using System;

    internal class Class856
    {
        private static bool bool_0;
        private static bool bool_1;
        private static bool bool_2;
        private static bool bool_3;
        private static Class857 class857_0;
        private static Class857[] class857_1 = new Class857[100];
        private static int int_0 = 100;

        internal static Class445 smethod_0(bool A_0)
        {
            bool_0 = false;
            bool_1 = false;
            bool_2 = false;
            return smethod_4(A_0);
        }

        internal static Class445 smethod_1(bool A_0)
        {
            bool_0 = true;
            bool_1 = false;
            bool_2 = false;
            return smethod_4(A_0);
        }

        private static void smethod_10(Class857 A_0, Class857[] A_1, int A_2)
        {
            Class857 class2 = A_0;
            for (int i = 0; i < A_2; i++)
            {
                A_1[i] = class2;
                class2 = class2.class857_1;
            }
        }

        private static Class445 smethod_11(Class857[] A_0, bool A_1, bool A_2)
        {
            Class445[] classArray = new Class445[A_0.Length];
            int index = A_0.Length - 1;
            for (int i = 0; i < index; i++)
            {
                classArray[i] = smethod_12(A_0[i], A_1, A_2, Enum49.const_0);
            }
            classArray[index] = smethod_12(A_0[index], A_1, A_2, Enum49.const_1);
            if (bool_0)
            {
                return new Class465(A_1 ? Enum1.const_8 : Enum1.const_1, classArray);
            }
            return new Class465(A_1 ? Enum1.const_1 : Enum1.const_8, classArray);
        }

        private static Class445 smethod_12(Class857 A_0, bool A_1, bool A_2, Enum49 A_3)
        {
            if (A_3 == Enum49.const_0)
            {
                if (A_1)
                {
                    if (A_2)
                    {
                        if (A_0.class857_3 == null)
                        {
                            return smethod_13(A_0.class419_0, false, A_2);
                        }
                        return smethod_11(A_0.class857_3, !A_1, false);
                    }
                    if (A_0.class857_3 == null)
                    {
                        return smethod_13(A_0.class419_0, false, A_2);
                    }
                    return smethod_11(A_0.class857_3, !A_1, false);
                }
                if (A_2)
                {
                    if (A_0.class857_3 == null)
                    {
                        return smethod_13(A_0.class419_0, true, A_2);
                    }
                    return smethod_11(A_0.class857_3, !A_1, true);
                }
                if (A_0.class857_3 == null)
                {
                    return smethod_13(A_0.class419_0, true, A_2);
                }
                return smethod_11(A_0.class857_3, !A_1, true);
            }
            if (A_1)
            {
                if (A_2)
                {
                    if (A_0.class857_3 == null)
                    {
                        return smethod_13(A_0.class419_0, true, A_2);
                    }
                    return smethod_11(A_0.class857_3, !A_1, true);
                }
                if (A_0.class857_3 == null)
                {
                    return smethod_13(A_0.class419_0, false, A_2);
                }
                return smethod_11(A_0.class857_3, !A_1, false);
            }
            if (A_2)
            {
                if (A_0.class857_3 == null)
                {
                    return smethod_13(A_0.class419_0, true, A_2);
                }
                return smethod_11(A_0.class857_3, !A_1, true);
            }
            if (A_0.class857_3 == null)
            {
                return smethod_13(A_0.class419_0, false, A_2);
            }
            return smethod_11(A_0.class857_3, !A_1, false);
        }

        private static Class445 smethod_13(Class419 A_0, bool A_1, bool A_2)
        {
            if (bool_0)
            {
                Class858.smethod_5(A_0, !A_1, !A_1);
            }
            else
            {
                Class858.smethod_5(A_0, !A_1, A_1);
            }
            return A_0.class445_0;
        }

        private static void smethod_14()
        {
            int num = 0;
            bool flag = true;
            while (true)
            {
                bool_3 = false;
                smethod_15(class857_0);
                if (!bool_3)
                {
                    flag = false;
                }
                num++;
                if (!flag || (num >= 200))
                {
                    return;
                }
            }
        }

        private static void smethod_15(Class857 A_0)
        {
            if (A_0.class857_3 != null)
            {
                Class857[] classArray = A_0.class857_3;
                bool flag = A_0.bool_0;
                for (int i = 0; i < classArray.Length; i++)
                {
                    Class857 class2 = classArray[i];
                    if (class2.class857_3 != null)
                    {
                        if (class2.bool_0 == flag)
                        {
                            smethod_16(A_0, i);
                            bool_3 = true;
                            return;
                        }
                        smethod_15(class2);
                    }
                }
            }
        }

        private static void smethod_16(Class857 A_0, int A_1)
        {
            Class857[] classArray = A_0.class857_3;
            Class857 class2 = classArray[A_1];
            Class857[] classArray2 = class2.class857_3;
            Class857[] classArray3 = new Class857[classArray.Length + classArray2.Length];
            for (int i = 0; i < A_1; i++)
            {
                classArray3[i] = classArray[i];
            }
            for (int j = 0; j < classArray2.Length; j++)
            {
                classArray3[A_1 + j] = classArray2[j];
            }
            for (int k = 0; k < ((classArray.Length - A_1) - 1); k++)
            {
                classArray3[(A_1 + classArray2.Length) + k] = classArray[((classArray.Length - A_1) + k) - 1];
            }
        }

        private static void smethod_17()
        {
            smethod_18(class857_0.class857_3);
        }

        private static void smethod_18(Class857[] A_0)
        {
            Class857 class2 = A_0[A_0.Length - 1];
            if (class2.class857_3 != null)
            {
                smethod_18(class2.class857_3);
            }
            else
            {
                Class858.smethod_5(class2.class419_0, true, false);
            }
        }

        internal static Class445 smethod_2(bool A_0)
        {
            bool_0 = false;
            bool_1 = true;
            bool_2 = false;
            return smethod_4(A_0);
        }

        internal static Class445 smethod_3(bool A_0)
        {
            bool_0 = false;
            bool_1 = false;
            bool_2 = true;
            return smethod_4(A_0);
        }

        internal static Class445 smethod_4(bool A_0)
        {
        if (Class853.int_1 > int_0)
    {
        int_0 = Class853.int_1;
        class857_1 = new Class857[int_0];
    }
    for (int i = 0; i < Class853.int_1; i++)
    {
        if (Class853.struct5_0[i].enum47_0 == Enum47.const_3)
        {
            return null;
        }
        class857_1[i] = new Class857(Class853.struct5_0[i].class419_0, Class853.struct5_0[i].enum47_0);
    }
    for (int j = 0; j < Class853.int_1; j++)
    {
        if (class857_1[j].enum47_0 == Enum47.const_0)
        {
            class857_1[j].class857_2 = class857_1[Class853.struct5_0[j].int_0];
        }
    }
    int index = Class853.int_1 - 1;
    for (int k = 0; k < Class853.int_1; k++)
    {
        if (k > 0)
        {
            class857_1[k].class857_0 = class857_1[k - 1];
        }
        if (k < index)
        {
            class857_1[k].class857_1 = class857_1[k + 1];
        }
    }
    class857_0 = class857_1[index];
    int num5 = 0;
    bool flag = false;
    while (true)
    {
        flag = (class857_0.class857_0 != null) ? smethod_5() : false;
        num5++;
        if (!flag || (num5 >= 200))
        {
            if (num5 == 200)
            {
                return null;
            }
            smethod_14();
            if (bool_0 || bool_1)
            {
                smethod_17();
            }
            return smethod_11(class857_0.class857_3, class857_0.bool_0, A_0);
        }
    }

        }

        private static bool smethod_5()
        {
            Class857 class3;
            for (Class857 class2 = class857_0; class2.class857_0 != null; class2 = class3)
            {
                class3 = class2.class857_0;
                if (smethod_6(class2))
                {
                    if (class2 == class857_0)
                    {
                        if (class3.enum47_0 == Enum47.const_1)
                        {
                            smethod_7(class2, class3, null, Enum48.const_0);
                            return true;
                        }
                        if (class3.enum47_0 == Enum47.const_2)
                        {
                            smethod_7(class2, class3, null, Enum48.const_1);
                            return true;
                        }
                    }
                    else if (class3.enum47_0 == Enum47.const_0)
                    {
                        if (class3.class857_2 == class2.class857_1)
                        {
                            smethod_7(class2, class3, class2.class857_1, Enum48.const_2);
                            return true;
                        }
                        if (class3.class857_2 == class2.class857_2)
                        {
                            smethod_7(class2, class3, class2.class857_2, Enum48.const_3);
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static bool smethod_6(Class857 A_0)
        {
            for (Class857 class2 = A_0.class857_0; class2 != null; class2 = class2.class857_0)
            {
                if (class2.class857_2 == A_0)
                {
                    return false;
                }
            }
            return true;
        }

        private static void smethod_7(Class857 A_0, Class857 A_1, Class857 A_2, Enum48 A_3)
        {
            int num = 0;
            Class857 class2 = A_0;
            bool flag = false;
            bool flag2 = true;
            goto Label_004B;
        Label_0015:
            num++;
            if (flag && !smethod_6(class2))
            {
                num++;
                flag2 = false;
                goto Label_0081;
            }
            if (class2.class857_0 == null)
            {
                flag2 = false;
                if (flag)
                {
                    num++;
                }
                goto Label_0081;
            }
            if (!flag)
            {
                goto Label_0081;
            }
        Label_004B:
            class2 = class2.class857_0;
            flag = false;
            switch (A_3)
            {
                case Enum48.const_0:
                    if (class2.enum47_0 == Enum47.const_1)
                    {
                        flag = true;
                    }
                    goto Label_0015;

                case Enum48.const_1:
                    if (class2.enum47_0 == Enum47.const_2)
                    {
                        flag = true;
                    }
                    goto Label_0015;

                case Enum48.const_2:
                case Enum48.const_3:
                    if (class2.class857_2 == A_2)
                    {
                        flag = true;
                    }
                    goto Label_0015;

                default:
                    goto Label_0015;
            }
        Label_0081:
            if (flag2 || !flag)
            {
                class2 = class2.class857_1;
            }
            bool flag3 = false;
            switch (A_3)
            {
                case Enum48.const_0:
                case Enum48.const_2:
                    flag3 = false;
                    break;

                case Enum48.const_1:
                case Enum48.const_3:
                    flag3 = true;
                    break;
            }
            Class857[] classArray = new Class857[num];
            Class857 class3 = new Class857(classArray, flag3);
            smethod_8(class2, class3);
            smethod_9(A_0, class3);
            smethod_10(class2, classArray, num);
            if (A_0 == class857_0)
            {
                class857_0 = class3;
            }
        }

        private static void smethod_8(Class857 A_0, Class857 A_1)
        {
            for (Class857 class2 = A_0.class857_0; class2 != null; class2 = class2.class857_0)
            {
                if ((class2.enum47_0 == Enum47.const_0) && (class2.class857_2 == A_0))
                {
                    class2.class857_2 = A_1;
                }
            }
            if (A_0.class857_0 != null)
            {
                A_1.class857_0 = A_0.class857_0;
                A_0.class857_0.class857_1 = A_1;
                A_0.class857_0 = null;
            }
        }

        private static void smethod_9(Class857 A_0, Class857 A_1)
        {
            A_1.enum47_0 = A_0.enum47_0;
            if (A_0.enum47_0 == Enum47.const_0)
            {
                A_1.class857_2 = A_0.class857_2;
            }
            if (A_0.class857_1 != null)
            {
                A_1.class857_1 = A_0.class857_1;
                A_0.class857_1.class857_0 = A_1;
                A_0.class857_1 = null;
            }
        }

        private class Class857
        {
            internal bool bool_0;
            internal Class419 class419_0;
            internal Class856.Class857 class857_0;
            internal Class856.Class857 class857_1;
            internal Class856.Class857 class857_2;
            internal Class856.Class857[] class857_3;
            internal Enum47 enum47_0;

            internal Class857(Class419 A_1, Enum47 A_2)
            {
                this.class419_0 = A_1;
                this.enum47_0 = A_2;
            }

            internal Class857(Class856.Class857[] A_1, bool A_2)
            {
                this.class857_3 = A_1;
                this.bool_0 = A_2;
            }
        }

        private enum Enum48
        {
            const_0,
            const_1,
            const_2,
            const_3
        }

        private enum Enum49
        {
            const_0,
            const_1
        }
    }
}

