namespace ns0
{
    using System;
    using System.Collections;

    internal class Class1036
    {
        private static ArrayList arrayList_0 = new ArrayList();
        private static bool bool_0;
        private static bool bool_1;
        private static Class445 class445_0;
        internal static Class822 class822_0;
        private static Class822 class822_1;
        private static Class822 class822_2;
        private static Class822 class822_3;

        internal static void smethod_0(Class445 A_0, bool A_1, Class822 A_2, Class822 A_3)
        {
            arrayList_0.Clear();
            class445_0 = A_0;
            bool_0 = A_1;
            class822_1 = A_2;
            class822_2 = A_3;
            bool_1 = true;
        }

        internal static bool smethod_1(Class419 A_0)
        {
            if (A_0 != null)
            {
                Class822 class2 = (Class536.hashtable_0[A_0] as Class826).class822_0;
                Class822 class3 = Class536.hashtable_2[A_0] as Class822;
                if (bool_1)
                {
                    class822_3 = class3;
                    bool_1 = false;
                }
                Class1037 class4 = null;
                bool flag = false;
                if (class2 == class822_1)
                {
                    class4 = new Class1037(A_0, Enum47.const_1, class3, class2);
                    flag = true;
                }
                if (class2 == class822_2)
                {
                    class4 = new Class1037(A_0, Enum47.const_2, class3, class2);
                    flag = true;
                }
                if (!flag)
                {
                    for (int i = 0; i < arrayList_0.Count; i++)
                    {
                        Class1037 class5 = arrayList_0[i] as Class1037;
                        if (class5.class822_0 == class2)
                        {
                            class4 = new Class1037(A_0, Enum47.const_0, class5, class3, class2);
                            flag = true;
                            break;
                        }
                    }
                }
                if (flag)
                {
                    Class536.hashtable_1.Remove(class3);
                    Class536.hashtable_2.Remove(A_0);
                    arrayList_0.Add(class4);
                    class822_0 = class3;
                    return true;
                }
            }
            return false;
        }

        private static void smethod_2()
        {
            Class853.smethod_0();
            int num = arrayList_0.Count - 1;
            for (int i = num; i >= 0; i--)
            {
                Class1037 class2 = arrayList_0[i] as Class1037;
                class2.int_0 = num - i;
            }
            for (int j = num; j >= 0; j--)
            {
                Class1037 class3 = arrayList_0[j] as Class1037;
                if (class3.enum47_0 == Enum47.const_0)
                {
                    Class853.smethod_2(class3.class419_0, Enum47.const_0, class3.class1037_0.int_0);
                }
                else
                {
                    Class853.smethod_2(class3.class419_0, class3.enum47_0, 0);
                }
            }
        }

        internal static Class445 smethod_3()
        {
            smethod_2();
            if (!bool_0)
            {
                class445_0 = Class858.smethod_1(class445_0, true);
            }
            Class853.smethod_2(new Class419(class445_0, Enum66.const_1), Enum47.const_2, 0);
            Class465 class2 = Class856.smethod_3(true) as Class465;
            if (!bool_0)
            {
                Class858.smethod_2(class2);
            }
            return class2;
        }

        internal static Class445 smethod_4(bool A_0)
        {
            Class445 class2;
            smethod_2();
            if (Class853.int_1 == 1)
            {
                Class419 class3 = Class853.struct5_0[0].class419_0;
                Class858.smethod_6(class3, false, true, false);
                class2 = class3.class445_0;
            }
            else
            {
                Class465 class4 = Class856.smethod_3(true) as Class465;
                Class858.smethod_2(class4);
                class2 = class4;
            }
            return new Class509(class2, class445_0, A_0 ? new Class447(1) : new Class447(0));
        }

        internal static int Int32_0
        {
            get
            {
                return arrayList_0.Count;
            }
        }

        private class Class1037
        {
            internal Class1036.Class1037 class1037_0;
            internal Class419 class419_0;
            internal Class822 class822_0;
            internal Class822 class822_1;
            internal Enum47 enum47_0;
            internal int int_0;

            internal Class1037(Class419 A_1, Enum47 A_2, Class822 A_3, Class822 A_4)
            {
                this.class419_0 = A_1;
                this.enum47_0 = A_2;
                this.class822_0 = A_3;
                this.class822_1 = A_4;
            }

            internal Class1037(Class419 A_1, Enum47 A_2, Class1036.Class1037 A_3, Class822 A_4, Class822 A_5)
            {
                this.class419_0 = A_1;
                this.enum47_0 = A_2;
                this.class1037_0 = A_3;
                this.class822_0 = A_4;
                this.class822_1 = A_5;
            }
        }
    }
}

