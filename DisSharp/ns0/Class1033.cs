namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1033
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private static ArrayList arrayList_1;
        private static bool bool_0 = false;
        internal static Class445 class445_0;
        internal static Class822 class822_0;
        private static Class822 class822_1;
        private static Class822 class822_2;
        private static Class822 class822_3;
        private static Stack stack_0 = new Stack(8);

        internal static void smethod_0()
        {
            bool_0 = false;
        }

        internal static void smethod_1(Class445 A_0, Class822 A_1, Class822 A_2, ArrayList A_3)
        {
            if (bool_0)
            {
                smethod_2();
                arrayList_0 = new ArrayList();
            }
            else
            {
                arrayList_0.Clear();
            }
            class445_0 = A_0;
            class822_1 = A_1;
            class822_2 = null;
            class822_3 = A_2;
            arrayList_1 = A_3;
            bool_0 = true;
        }

        private static void smethod_2()
        {
            Class1034 class2 = new Class1034(class445_0, class822_0, class822_1, class822_2, class822_3, arrayList_0);
            stack_0.Push(class2);
        }

        internal static Class822 smethod_3()
        {
            if (stack_0.Count == 0)
            {
                bool_0 = false;
                return null;
            }
            Class1034 class2 = stack_0.Pop() as Class1034;
            class822_0 = class2.class822_0;
            class445_0 = class2.class445_0;
            class822_1 = class2.class822_1;
            class822_2 = class2.class822_2;
            class822_3 = class2.class822_3;
            arrayList_0 = class2.arrayList_0;
            return class822_1;
        }

        internal static bool smethod_4(Class419 A_0)
        {
            if (A_0 != null)
            {
                Class826 class2 = Class536.hashtable_0[A_0] as Class826;
                Class822 class3 = class2.class822_0;
                Class822 class4 = Class536.hashtable_2[A_0] as Class822;
                if (class822_2 == null)
                {
                    for (int i = 0; i < arrayList_1.Count; i++)
                    {
                        if (arrayList_1[i] == class2)
                        {
                            class822_2 = arrayList_1[i + 1] as Class822;
                            break;
                        }
                    }
                }
                Class1035 class5 = null;
                bool flag = false;
                if (class3 == class822_2)
                {
                    class5 = new Class1035(A_0, Enum47.const_1, class4, class3);
                    flag = true;
                }
                if (class3 == class822_3)
                {
                    class5 = new Class1035(A_0, Enum47.const_2, class4, class3);
                    flag = true;
                }
                if (!flag)
                {
                    for (int j = 0; j < arrayList_0.Count; j++)
                    {
                        Class1035 class6 = arrayList_0[j] as Class1035;
                        if (class6.class822_0 == class3)
                        {
                            class5 = new Class1035(A_0, Enum47.const_0, class6, class4, class3);
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    Class536.hashtable_1.Remove(class4);
                    Class536.hashtable_2.Remove(A_0);
                    arrayList_0.Add(class5);
                    class822_0 = class4;
                    return true;
                }
            }
            return false;
        }

        internal static Class445 smethod_5()
        {
            Class853.smethod_0();
            int num = arrayList_0.Count - 1;
            for (int i = num; i >= 0; i--)
            {
                Class1035 class2 = arrayList_0[i] as Class1035;
                class2.int_0 = num - i;
            }
            for (int j = num; j >= 0; j--)
            {
                Class1035 class3 = arrayList_0[j] as Class1035;
                if (class3.enum47_0 == Enum47.const_0)
                {
                    Class853.smethod_2(class3.class419_0, Enum47.const_0, class3.class1035_0.int_0);
                }
                else
                {
                    Class853.smethod_2(class3.class419_0, class3.enum47_0, 0);
                }
            }
            if (Class853.int_1 == 1)
            {
                Class419 class4 = Class853.struct5_0[0].class419_0;
                Class858.smethod_6(class4, false, true, false);
                return class4.class445_0;
            }
            Class465 class5 = Class856.smethod_2(true) as Class465;
            Class858.smethod_2(class5);
            return class5;
        }

        private class Class1034
        {
            internal ArrayList arrayList_0;
            internal Class445 class445_0;
            internal Class822 class822_0;
            internal Class822 class822_1;
            internal Class822 class822_2;
            internal Class822 class822_3;

            internal Class1034(Class445 A_1, Class822 A_2, Class822 A_3, Class822 A_4, Class822 A_5, ArrayList A_6)
            {
                this.class445_0 = A_1;
                this.class822_0 = A_2;
                this.class822_1 = A_3;
                this.class822_2 = A_4;
                this.class822_3 = A_5;
                this.arrayList_0 = A_6;
            }
        }

        private class Class1035
        {
            internal Class1033.Class1035 class1035_0;
            internal Class419 class419_0;
            internal Class822 class822_0;
            internal Class822 class822_1;
            internal Enum47 enum47_0;
            internal int int_0;

            internal Class1035(Class419 A_1, Enum47 A_2, Class822 A_3, Class822 A_4)
            {
                this.class419_0 = A_1;
                this.enum47_0 = A_2;
                this.class822_0 = A_3;
                this.class822_1 = A_4;
            }

            internal Class1035(Class419 A_1, Enum47 A_2, Class1033.Class1035 A_3, Class822 A_4, Class822 A_5)
            {
                this.class419_0 = A_1;
                this.enum47_0 = A_2;
                this.class1035_0 = A_3;
                this.class822_0 = A_4;
                this.class822_1 = A_5;
            }
        }
    }
}

